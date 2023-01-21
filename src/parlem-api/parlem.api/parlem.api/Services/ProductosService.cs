using parlem.domain.Entities;
using parlem.domain.Abstract;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace parlem.api.Services
{
    public class ProductosService : IProductoService
    {
      
        private readonly IRepository<Producto> _repository;       

        public ProductosService(IRepository<Producto> repository
             )
        {
            _repository = repository;          

        }

        public async Task<Producto> CreateAsync(Producto administracionMenuRoles)
        {
            await _repository.CreateAsync(administracionMenuRoles);
            return administracionMenuRoles;
        }

      

        public IQueryable<Producto> GetList(int id)
        {
            return (from d in _repository.GetDbSet()
                    where d.FechaDelete == null && d.CustomerId == id
                    select d);
        }

        public async Task<Producto> GetItem(int id)
        {
            return _repository.GetDbSet().Where(x => x.Id == id).FirstOrDefault();
        }      
    }
}
