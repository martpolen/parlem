using parlem.domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace parlem.api.Services
{
    public interface IProductoService
    {
        IQueryable<Producto> GetList(int id);
        Task<Producto> CreateAsync(Producto Productos);
     
        Task<Producto> GetItem(int id);    

    }
}
