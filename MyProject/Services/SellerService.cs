using MyProject.Data;
using MyProject.Models;

namespace MyProject.Services
{
    public class SellerService
    {
        private readonly MyProjectContext _context;

        public SellerService(MyProjectContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

