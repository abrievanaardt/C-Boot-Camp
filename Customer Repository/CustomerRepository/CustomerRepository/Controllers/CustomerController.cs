using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerApi.Models;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetCustomer")]
        public IActionResult GetById(long id)
        {
            var customer = _customerRepository.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return new ObjectResult(customer);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            _customerRepository.Add(customer);

            return CreatedAtRoute("GetCustomer", new { id = customer.CustomerId }, customer);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Customer customer)
        {
            if (customer == null || customer.CustomerId != id)
            {
                return BadRequest();
            }

            var currentCustomer = _customerRepository.Find(id);

            if (currentCustomer == null)
            {
                return NotFound();
            }

            currentCustomer.FirstName = customer.FirstName;
            currentCustomer.LastName = customer.LastName;
            currentCustomer.Phone = customer.Phone;
            currentCustomer.Address = customer.Address;
            currentCustomer.PostalAddress = customer.PostalAddress;
            currentCustomer.State = customer.State;
            currentCustomer.Email = customer.Email;
            currentCustomer.City = customer.City;

            _customerRepository.Update(currentCustomer);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var customer = _customerRepository.Find(id);

            if (customer == null)
            {
                return NotFound();
            }

            _customerRepository.Remove(id);

            return new NoContentResult();
        }
    }
}
