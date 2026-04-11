using MyFirstProject.Models;

namespace MyFirstProject.Data
{
    public class CustomerRepository
    {
        public CustomerResponse GetCustomerById(int customerId)
        {
            // Fake DB data
            return new CustomerResponse
            {
                CustomerId = 101,
                Name = "Anand",
                Status = "Active"
            };
        }
    }
}