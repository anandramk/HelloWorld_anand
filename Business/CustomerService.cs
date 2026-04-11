using MyFirstProject.Models;
using MyFirstProject.Data;

namespace MyFirstProject.Business
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo;

        public CustomerService()
        {
            _repo = new CustomerRepository();
        }

        public CustomerResponse GetCustomer(CustomerRequest request)
        {
            return _repo.GetCustomerById(request.CustomerId);
        }
    }
}