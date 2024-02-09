using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_EMSproject.Models;

namespace WebAPI_EMSproject.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_EMSproject.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
