    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product:BaseEntity
    {
        [MaxLength(100)]
        public string name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ushort InStock { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Discount { get; set; }
        public string SKU { get; set; }
        public DateTime  PublishDate { get; set; }
        public string Barcode { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }




    }
}
