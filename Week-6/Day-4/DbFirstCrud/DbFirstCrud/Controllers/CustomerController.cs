using DbFirstCrud.Data;
using DbFirstCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbFirstCrud.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DbFirstCrudContext _context;
        public CustomerController(DbFirstCrudContext context)
        {
            _context = context;
        }
        /* Tis code is for Pagination
         * public IActionResult Index(int pg = 1 )
        {
            const int pageSize = 10;

            if (pg < 1)
                pg = 1;
            int recsCount = _context.Customers.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            List<Customers> customers = _context.Customers.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(customers);
        }*/
        public IActionResult Index()
        {
            List<Customers> customers = _context.Customers.ToList();
            return View(customers);
        }
        public IActionResult Details(string Id)
        {
            Customers customer = _context.Customers.Where(p => p.CustomerId == Id).FirstOrDefault();
            return View(customer);
        }
        
        [HttpGet]
        public IActionResult Edit(string Id)
        {
            Customers customer = _context.Customers.Where(p => p.CustomerId == Id).FirstOrDefault();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customers customer)
        {
            _context.Attach(customer);
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(string Id)
        {
            Customers customer = _context.Customers.Where(p => p.CustomerId == Id).FirstOrDefault();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(Customers customer)
        {
            _context.Attach(customer);
            _context.Entry(customer).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            Customers customer = new Customers();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Create(Customers customer)
        {
            /*var customerid = _context.Customers.Max(custid => custid.CustomerId);
            long customerNo;

            Int64.TryParse(customerid.Substring(2, customerid.Length - 2), out customerNo);
            if (customerNo > 0)
            {
                customerNo = customerNo + 1;
                customerid = "CS" + customerNo.ToString();
            }

            customer.CustomerId = customerid;
            */
            _context.Attach(customer);
            _context.Entry(customer).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
