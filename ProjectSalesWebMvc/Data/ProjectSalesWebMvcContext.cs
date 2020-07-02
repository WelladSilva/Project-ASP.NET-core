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

        public DbSet<ProjectSalesWebMvc.Models.Classe.Department> Department { get; set; }
    }
}
