using Castle.Core.Resource;
using parlem.domain.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace parlem.test.Common
{
    public class MockEntities
    {
        public List<Customers> MockCustomers()
        {
            var customer1 = new Customers()
            {
                Id = 1,
                DocType = "DNI",
                DocNum = "111111H",
                Email = "customer1@customer.cat",
                CustomerId = 1,
                IdSeccion = 1,
                GivenName = "Apellido1",
                FamilyName = "Nombre1",
                phone = "661661662",
                FechaDelete = null,
                FechaInsert = DateTime.Now,
                FechaUpdate = DateTime.Now,
                UserInsert = "e6a592a3-8ecc-48ba-bc8c-308c97482887",
                UserUpdate = "e6a592a3-8ecc-48ba-bc8c-308c97482887",
            };

            var customer2 = new Customers()
            {
                Id = 2,
                DocType = "DNI",
                DocNum = "111112H",
                Email = "customer2@customer.cat",
                CustomerId = 2,
                IdSeccion = 1,
                GivenName = "Apellido2",
                FamilyName = "Nombre2",
                phone = "661661663",
                FechaDelete = null,
                FechaInsert = DateTime.Now,
                FechaUpdate = DateTime.Now,
                UserInsert = "e6a592a3-8ecc-48ba-bc8c-308c97482887",
                UserUpdate = "e6a592a3-8ecc-48ba-bc8c-308c97482887",
            };

            var customers = new List<Customers>
            {
                customer1,
                customer2
            };
            return customers;
        }
        public List<Producto> MockProductos()
        {
            var producto1 = new Producto()
            {
                Id = 1,
                ProductName = "Fibra + Movil",
                ProductTypeName = "FibraMovil",
                numeracioTerminal = 123,
                SoldAt = DateTime.Now,
                CustomerId = 1,
                IdSeccion = 1,
                FamilyName = "Nombre1",
                phone = "123123123",
                FechaDelete = null,
                FechaInsert = DateTime.Now,
                FechaUpdate = DateTime.Now,
                UserInsert = "e6a592a3-8ecc-48ba-bc8c-308c97482887",
                UserUpdate = "e6a592a3-8ecc-48ba-bc8c-308c97482887",
            };

            var producto2 = new Producto()
            {
                Id = 2,
                ProductName = "Fibra + Movil",
                ProductTypeName = "FibraMovil",
                numeracioTerminal = 123,
                SoldAt = DateTime.Now,
                CustomerId = 1,
                IdSeccion = 1,
                FamilyName = "Nombre2",
                phone = "123123123",
                FechaDelete = null,
                FechaInsert = DateTime.Now,
                FechaUpdate = DateTime.Now,
                UserInsert = "e6a592a3-8ecc-48ba-bc8c-308c97482887",
                UserUpdate = "e6a592a3-8ecc-48ba-bc8c-308c97482887",
            };

            var producto = new List<Producto>
            {
                producto1,
                producto2
            };
            return producto;
        }
    }


}
