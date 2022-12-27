using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    /// <summary>
    /// Teklif
    /// </summary>
    public class Offered : BaseEntity
    {
        public string OfferNumber { get; set; }
        public Seller Seller { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
