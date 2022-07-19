using Api_projeto_Zenvia.Models.Customer;
using System.Threading.Tasks;

namespace Api_projeto_Zenvia.Services
{
    public interface ICustomerService
    {
        Task<CustomerSearch> GetAll(int page, int size, string customerName);

        Task<Customer> GetById(int id);

        Task<Customer> Create(Customer customer);

        Task<Customer> Update(Customer customer);

        void Remove(Customer customer);

    }
}
