using parlem.domain.Abstract;
using parlem.domain.Entities;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace parlem.api.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly IRepository<Customers> _repository;

        public CustomerService(IRepository<Customers> repository
             )
        {
            _repository = repository;

        }

        public async Task<Customers> CreateAsync(Customers customers)
        {
            await _repository.CreateAsync(customers);
            return customers;
        }    

        public IQueryable<Customers> GetList()
        {
            return (from d in _repository.GetDbSet()
                    where d.FechaDelete == null
                    select d);
        }

        public async Task<Customers> GetItem(int id)
        {
            return _repository.GetDbSet().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
