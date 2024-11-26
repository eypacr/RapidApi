using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeService : GenericService<Subscribe>, ISubscribeService
    {
        public SubscribeService(IGenericRepository<Subscribe> repository) : base(repository)
        {
        }
    }
}
