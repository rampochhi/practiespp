using Microsoft.AspNetCore.Mvc;
using practiespp.Data;
using practiespp.Models;
using System.Runtime.InteropServices;

namespace practiespp.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        #region APICALL
        public IActionResult AllCustomers()
        {
            var customer = _context.Customers.ToList();
            return Json(new { data = customer });
        }

        #endregion

        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddCustomer()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCustomer(Customer customer)//object of the model class 
        {
            var cust = new Customer();//create temp variable of model class
            if (ModelState.IsValid)
            {
                cust.Name = customer.Name;
                cust.Email = customer.Email;
                cust.Address = customer.Address;
                cust.Number = customer.Number;
                await _context.Customers.AddAsync(customer);//pass the model object
                await _context.SaveChangesAsync();
                TempData["sucssess"] = "Customer Added Sucssesfully";
                return RedirectToAction("Index");
            }

            return View("AddCustomer");
        }

        //Edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Customer customer, int? id)
        {
            var edit = new Customer();
            if (edit.Id == id || id != null)
            {
                edit.Name = customer.Name;
                edit.Email = customer.Email;
                edit.Address = customer.Address;
                edit.Number = customer.Number;
                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
                TempData["sucssess"] = "Record Updated..!";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        //delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }



        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> Deletes(int? id, Customer customer)
        {
            var cust = new Customer();
            if (customer == null)
            {
                return NotFound();
            }
            cust.Name = customer.Name;
            cust.Address = customer.Address;
            cust.Number = customer.Number;
            cust.Email = customer.Email;
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            TempData["sucssess"] = "Delete Record...!";
            return RedirectToAction("Index");


        }


    }
}

