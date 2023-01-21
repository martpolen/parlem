using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using parlem.web.Services;

namespace parlem.web.Controllers
{
    public class CustomersController : Controller
    {

        private readonly CustomerService _customerService;


        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = _customerService.GetAllCustomers().GetAwaiter().GetResult();
            return View(customers);
        }

        public ActionResult Customers()
        {
            var customers = _customerService.GetAllCustomers().GetAwaiter().GetResult();
            return View(customers);
        }     

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
