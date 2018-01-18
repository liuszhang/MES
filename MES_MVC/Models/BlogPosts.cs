using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MES_MVC.Models
{
    [XmlRoot("BlogPosts")]
    public class BlogPostsProvider
    {
        [XmlElement("BlogPost")]
        public List<BlogPost> BlogPosts { get; set; }

        static BlogPostsProvider current;
        static BlogPostsProvider Current
        {
            get
            {
                if(current == null)
                {
                    string filePath = HttpContext.Current.Server.MapPath("~/App_Data/BlogPosts.xml");
                    using(StreamReader reader = new StreamReader(filePath))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(BlogPostsProvider));
                        current = (BlogPostsProvider)serializer.Deserialize(reader);
                    }
                }
                return current;
            }
        }
        public static BlogPost GetBlogPost(int? id)
        {
            if(!id.HasValue)
                return null;
            return Current.BlogPosts.FirstOrDefault(p => p.Id == id);
        }

        public static List<BlogPost> GetBlogPosts() {
            return GetBlogPosts(null, null);
        }
        public static List<BlogPost> GetBlogPosts(int? year, int? month)
        {
            List<BlogPost> blogPosts = Current.BlogPosts;
            if(blogPosts == null)
                return null;

            if(year.HasValue)
                blogPosts = blogPosts.FindAll(p => p.Date.Year == year);
            if(month.HasValue)
                blogPosts = blogPosts.FindAll(p => p.Date.Month == month);
            return blogPosts;
        }
        public static Dictionary<int, Dictionary<int, IEnumerable<BlogPost>>> GetBlogsByCategories()
        {
            var result = new Dictionary<int, Dictionary<int, IEnumerable<BlogPost>>>();
            var yearsGroup = Current.BlogPosts.GroupBy(p => p.Date.Year).OrderByDescending(g => g.Key);
            foreach(var yearGroup in yearsGroup)
            {
                result[yearGroup.Key] = new Dictionary<int, IEnumerable<BlogPost>>();
                var monthGroups = yearGroup.GroupBy(p => p.Date.Month).OrderByDescending(g => g.Key);
                foreach(var monthGroup in monthGroups)
                {
                    result[yearGroup.Key][monthGroup.Key] = monthGroup.ToList();
                }
            }
            return result;
        }
    }

    public class BlogPost
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }

        [XmlIgnore]
        public DateTime Date { get; set; }
        public string DateString
        {
            get { return this.Date.ToString("yyyy-MM-dd HH:mm:ss"); }
            set { this.Date = DateTime.Parse(value); }
        }
    }
}