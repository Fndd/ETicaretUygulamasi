using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    /// <summary>
    /// Sistem
    /// </summary>
    public class ProductSystem:BaseEntity
    {
        public int Name { get; set; }
        public int Description { get; set; } 
    }
}
