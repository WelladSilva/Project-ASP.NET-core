using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSalesWebMvc.Models.Classe;

namespace ProjectSalesWebMvc.Data
{
    public class ProjectSalesWebMvcContext : DbContext
    {
        public ProjectSalesWebMvcContext (DbContextOptions<ProjectSalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
