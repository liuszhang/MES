using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace Lsz.MES.Data
{
    public class MESProduct
    {
        public MESProduct() { }

        //public ICollection<QuoteItem> QuoteItems { get; set; }
        //public virtual List<ProductImage> Images { get; set; }
        //[InverseProperty("Product")]
        //public virtual List<OrderItem> OrderItems { get; set; }
        //[InverseProperty("Product")]
        //public virtual List<ProductCatalog> Catalog { get; set; }
        public MESProductCategory Category { get; set; }
        public double ConsumerRating { get; set; }
        [DataType(DataType.Currency)]
        public decimal RetailPrice { get; set; }
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }
        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }
        public long? PrimaryImageId { get; set; }
        //public virtual Picture PrimaryImage { get; set; }
        public Stream Brochure { get; }
        public byte[] Barcode { get; set; }
        public int Backorder { get; set; }
        public int? CurrentInventory { get; set; }
        public long? EngineerId { get; set; }
        //public virtual Employee Engineer { get; set; }
        public long? SupportId { get; set; }
        //public virtual Employee Support { get; set; }
        public byte[] Image { get; set; }
        public bool Available { get; set; }
        public DateTime ProductionStart { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Manufacturing { get; set; }
        //public Image ProductImage { get; }
    }
}
