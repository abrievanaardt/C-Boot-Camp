using System.Collections.Generic;

namespace CustomerApi.Models
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        IEnumerable<Customer> GetAll();
        Customer Find(long customerId);
        void Remove(long customerId);
        void Update(Customer customer);
    }
}
