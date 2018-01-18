using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lsz.MES.Data.Filters
{
    public class FilterItem
    {
        public virtual string Name { get; set; }

        public virtual int EntitiesCount { get; set; }

        public virtual string DisplayText { get; set; }

        public virtual string ImageUri { get; set; }

        //public List<FilterItem> filterItems {get;set;}
    }
}
