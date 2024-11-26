using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceService : GenericService<Service>, IServiceService
    {
        public ServiceService(IGenericRepository<Service> repository) : base(repository)
        {
        }
    }
}
