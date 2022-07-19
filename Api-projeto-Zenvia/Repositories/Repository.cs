using Api_projeto_Zenvia.Context;
using Api_projeto_Zenvia.Models.Customer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_projeto_Zenvia.Repositories
{
    public class Repository : IRepository
    {
        private readonly EntityContext _context;

        public Repository(EntityContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
        
        public async Task<Customer> GetById(int id)
        { 
            IQueryable<Customer> query = _context.Customer;

            return await query.Include(a => a.Telephones)
            .Include(ad => ad.Adresses)
            .AsNoTracking()
            .OrderBy(a => a.Id)
            .FirstOrDefaultAsync();

        }

        public async Task<IList<Customer>> GetAllCustomers(int page, int size, string customerName)
        {
            IQueryable<Customer> query = _context.Customer;

            var skip = (page - 1) * size;

            query = query
                .OrderBy(x => x.Id)
                .Include(x => x.Telephones)
                .Include(x => x.Adresses)
                .Skip(skip)
                .Take(size);

            if (!string.IsNullOrEmpty(customerName))
            {
                query = query.Where(x => x.Name.Contains(customerName));
            }

            return await query.ToListAsync();
        }

        public int GetTotalCount()
        {
            return _context.Customer
            .Count();
        }
    }
}
