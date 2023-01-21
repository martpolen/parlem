using parlem.domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace parlem.api.Services
{
    public interface ICustomerService
    {
        IQueryable<Customers> GetList();
        Task<Customers> CreateAsync(Customers customers);     
        Task<Customers> GetItem(int id);    

    }
}
