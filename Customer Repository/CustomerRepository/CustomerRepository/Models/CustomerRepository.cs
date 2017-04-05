using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerApi.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;

        public CustomerRepository(CustomerContext context)
        {
            _context = context;
            //Add(new Customer { FirstName = "John", LastName = "Doe" });
        }
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public Customer Find(long customerId)
        {
            return _context.Customers.FirstOrDefault(t => t.CustomerId == customerId);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Remove(long customerId)
        {
            var entity = _context.Customers.First(t => t.CustomerId == customerId);
            _context.Customers.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
