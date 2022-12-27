using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    /// <summary>
    /// Sipariş
    /// </summary>
    public class Order : BaseEntity
    {
        public string OrderNumber { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PayDate { get; set; }
        public long Total { get; set; }
        public long RowQuantity { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int GeneralDiscountAmount { get; set; }
        public int GeneralDiscountPercent { get; set; } 
        public int SellerId { get; set; }
        public int SystemId { get; set; }
        public int WiringId { get; set; }
        public int BuildingId { get; set; }
        public Seller Seller { get; set; }
        public ProductSystem System { get; set; }
        public Wiring Wiring { get; set; }
        public Building Building { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
