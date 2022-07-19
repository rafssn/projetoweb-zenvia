using Api_projeto_Zenvia.Models.Customer;
using Api_projeto_Zenvia.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Api_projeto_Zenvia.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomerSearch> GetAll(int page, int size, string customerName){

            var result = new CustomerSearch();
            page = page <= 0 ? 1 : page;
            size = size <= 0 ? 10 : size;

            result.TotalCount = _repository.GetTotalCount();
            result.Customers = await _repository.GetAllCustomers(page, size, customerName);

            return result;
        }

        public async Task<Customer> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Customer> Create(Customer customer)
        {
            _unitOfWork.BeginTransaction();

            _repository.Add<Customer>(customer);
            _unitOfWork.Commit();

            _unitOfWork.BeginCommit();

            return customer;
        }

        public async Task<Customer> Update(Customer customer)
        {
            var current = await _repository.GetById(customer.Id);

            _unitOfWork.BeginTransaction();

            _repository.Update<Customer>(customer);
            _unitOfWork.Commit();

            _unitOfWork.BeginCommit();

            return customer;
        }

        public void Remove(Customer customer)
        {
            _repository.Delete(customer);
        }
    }
}
