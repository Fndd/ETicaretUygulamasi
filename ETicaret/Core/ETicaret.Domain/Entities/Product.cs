using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Product : BaseEntity
    { 
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; } 
        public string Description { get; set; }
        public int BrandId { get; set; }
        //public virtual Brand Brand { get; set; }
        //public ICollection<Seller> Sellers { get; set; }
        //public ICollection<Order> Orders { get; set; }
        //public ICollection<Offered> Offereds { get; set; }
    }
}
