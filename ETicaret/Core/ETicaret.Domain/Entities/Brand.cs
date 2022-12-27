using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Brand :BaseEntity
    {
        public string Name { get; set; }
        public string Website { get; set; }
    }
}
