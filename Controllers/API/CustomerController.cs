
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using MovieRental.Dtos;
using MovieRental.Models;

namespace MovieRental.Controllers.API
{
    public class CustomerController : ApiController
    {
        private MyDbContext _context;

        public CustomerController()
        {
            _context = new MyDbContext();
        }

        //GET /api/customer
        [HttpGet]
        public IEnumerable<CustomerDto> GetAll()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);
        }

        //GET /api/customer/1
        [HttpGet]
        public CustomerDto Get(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Customer, CustomerDto>(customer);
        }

        //POST api/customer
        [HttpPost]
        public CustomerDto Add(CustomerDto customerDto)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return customerDto;
        }

        //PUT api/customer/1
        [HttpPut]
        public CustomerDto Update(int id , CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.Single(m => m.Id == id);
            
            if(customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

           Mapper.Map<CustomerDto, Customer>(customerDto, customerInDb);

            /* if (!string.IsNullOrEmpty(customerDto.Name) && !customerDto.Name.Equals(customerInDb.Name))
                customerInDb.Name = customerDto.Name;

            if (customerDto.MembershipTypeId != customerInDb.MembershipTypeId)
            {
                customerInDb.MembershipTypeId = customerDto.MembershipTypeId;
                customerInDb.MembershipType = _context.MembershipTypes.SingleOrDefault(m => m.Id == customerDto.MembershipTypeId);
            }
         
            if (!string.IsNullOrEmpty(customerDto.Email) && !customerDto.Email.Equals(customerInDb.Email))
                customerInDb.Email = customerDto.Email;

            if (customerDto.IsSubscribedToNewsLetter!=customerInDb.IsSubscribedToNewsLetter)
                customerInDb.IsSubscribedToNewsLetter = customerDto.IsSubscribedToNewsLetter;

            if (customerDto.BirthDate != customerInDb.BirthDate)
                customerInDb.BirthDate = customerDto.BirthDate;
*/
            _context.SaveChanges();

            return customerDto;
        }

        //DELETE api/customer/1
        [HttpDelete]
  
        public void Deleter(int id)
        {
            var customer = _context.Customers.Single(m => m.Id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customer);

            _context.SaveChanges();
        }
    }
}