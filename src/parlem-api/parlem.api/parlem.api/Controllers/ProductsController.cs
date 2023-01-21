using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using parlem.api.Services;
using parlem.domain.Entities;

namespace parlem.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly ILogger<CustomersController> _logger;
        private readonly IProductoService _productosService;

        public ProductsController(ILogger<CustomersController> logger, IProductoService productosService)
        {
            _logger = logger;
            _productosService = productosService;
        }

        [Route("CustomerProducts/{id}")]
        public IEnumerable<Producto> Get(int id)
        {
            return _productosService.GetList(id);
        }

        [Route("{id}")]
        public async Task<Producto> GetProductDetails(int id)
        {
            return await _productosService.GetItem(id);
        }
    }
}
