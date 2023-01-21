using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using parlem.web.Services;
using System.Threading.Tasks;

namespace parlem.web.Controllers
{
    public class ProductosController : Controller
    {

        private readonly ProductosService _productosService;


        public ProductosController(ProductosService productosService)
        {
            _productosService = productosService;
        }

        // GET: CustomerController
        public ActionResult Index()
        {           
            return View();
        }

        public async Task<ActionResult> ProductosCustomer(int id)
        {
            var productos = await _productosService.GetProductsByCustomerId(id);
            return View(productos);
        }

        // GET: CustomerController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var producto = await _productosService.GetProductsDetails(id);
            return View(producto);
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
