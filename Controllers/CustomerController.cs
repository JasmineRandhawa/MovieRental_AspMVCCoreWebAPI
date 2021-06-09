using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext _context;
        List<MembershipType> dbMembershipTypeList = new List<MembershipType>();

        public CustomerController()
        {
            _context = new MyDbContext();
            dbMembershipTypeList.AddRange(_context.MembershipTypes.ToList());
        }
        public ViewResult Index()
        {
            List<Customer> customerList = _context.Customers.Include(c => c.MembershipType).ToList();
            return View("Index",customerList);
        }
        public ViewResult New()
        {
            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer() ,
                MembershipTypes = dbMembershipTypeList
            };
            return View("AddUpdateCustomer", viewModel);
        }

        public ViewResult Edit(int id)
        {
            Customer customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                    throw new HttpResponseException(HttpStatusCode.NotFound);

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = dbMembershipTypeList
            };
            return View("AddUpdateCustomer", viewModel);
        }

        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {

                var viewModel = new CustomerFormViewModel()
                {
                    Customer = customer,
                    MembershipTypes = dbMembershipTypeList
                };

                return View("AddUpdateCustomer", viewModel);
            }

            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(m => m.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.Email = customer.Email;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                customerInDb.BirthDate = customer.BirthDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }


        public IActionResult Delete(int id)
        {
            Customer customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customer);

            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }
    }
}
