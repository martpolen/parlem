using Microsoft.EntityFrameworkCore;
using Moq;
using parlem.api.Services;
using parlem.domain.Abstract;
using parlem.domain.Entities;
using parlem.test.Common;
using System;
using System.Linq;
using Xunit;

namespace parlem.test
{
    public class ProductosServiceTest : MockEntities
    {
        private readonly ProductosService _productosService;
        private readonly Mock<IRepository<Producto>> _repository = new Mock<IRepository<Producto>>();


        public ProductosServiceTest()
        {
            _productosService = new ProductosService(_repository.Object);
        }

        public DbSet<Producto> CreateMockDbSetEntity()
        {
            return DbSetSetup.GetQueryableMockDbSet(MockProductos());
        }


        [Fact]
        public void GetList()
        {
            var idCustomer = 1;

            _repository.Setup(a => a.GetDbSet()).Returns(CreateMockDbSetEntity());
            _repository.Setup(a => a.GetListAsync()).ReturnsAsync(MockProductos());

            var list = _productosService.GetList(idCustomer);

            Assert.Equal(2, list.ToList().Count());
        }

        [Fact]
        public void GetListKo()
        {
            var idCustomer = 1;

            _repository.Setup(a => a.GetDbSet()).Returns(CreateMockDbSetEntity());
            _repository.Setup(a => a.GetListAsync()).ReturnsAsync(MockProductos());

            var list = _productosService.GetList(idCustomer);

            Assert.NotEqual(99, list.ToList().Count());
        }

        [Fact]
        public async void GetByIdAsyncOk()
        {
            var id = 1;

            _repository.Setup(a => a.GetDbSet()).Returns(CreateMockDbSetEntity());

            Producto producto = await _productosService.GetItem(id);

            Assert.Equal(id, producto.Id);
            Assert.Null(producto.FechaDelete);
        }      

    }
}
