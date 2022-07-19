using Api_projeto_Zenvia.Models.Customer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_projeto_Zenvia.Repositories
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();
        Task<Customer> GetById(int id);
        Task<IList<Customer>> GetAllCustomers(int page, int size, string customerName);
        int GetTotalCount();
    }
}
