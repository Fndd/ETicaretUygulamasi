using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repositories
{
    public class OfferedWriteRepository :WriteRepository<Offered>, IOfferedWriteRepository
    {
        public OfferedWriteRepository(dbContext context) : base(context)
        {

        } 
    }
}
