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
    public class CustomerServiceTest : MockEntities
    {
        private readonly CustomerService _customerService;
        private readonly Mock<IRepository<Customers>> _repository = new Mock<IRepository<Customers>>();


        public CustomerServiceTest()
        {
            _customerService = new CustomerService(_repository.Object);
        }

        public DbSet<Customers> CreateMockDbSetEntity()
        {
            return DbSetSetup.GetQueryableMockDbSet(MockCustomers());
        }


        [Fact]
        public void GetList()
        {

            _repository.Setup(a => a.GetDbSet()).Returns(CreateMockDbSetEntity());
            _repository.Setup(a => a.GetListAsync()).ReturnsAsync(MockCustomers());

            var list = _customerService.GetList();

            Assert.Equal(2, list.ToList().Count());
        }

        [Fact]
        public void GetListKo()
        {

            _repository.Setup(a => a.GetDbSet()).Returns(CreateMockDbSetEntity());
            _repository.Setup(a => a.GetListAsync()).ReturnsAsync(MockCustomers());

            var list = _customerService.GetList();

            Assert.NotEqual(99, list.ToList().Count());
        }

        [Fact]
        public async void GetByIdAsyncOk()
        {
            var id = 1;
            _repository.Setup(a => a.GetDbSet()).Returns(CreateMockDbSetEntity());
            Customers customer = await _customerService.GetItem(id);
            //Assert (comprobar el resultado)
            Assert.Equal(id, customer.Id);
            Assert.Null(customer.FechaDelete);
        }      

    }
}
