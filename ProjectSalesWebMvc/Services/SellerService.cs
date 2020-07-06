using ProjectSalesWebMvc.Data;
using ProjectSalesWebMvc.Models.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSalesWebMvc.Services
{
    public class SellerService
    {
        private readonly ProjectSalesWebMvcContext _context;

        public SellerService(ProjectSalesWebMvcContext context)
        {
            _context = context; 
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
