using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutManager : GenericManager<About>, IAboutService
    {
        public AboutManager(IGenericRepository<About> repository) : base(repository)
        {
        }
    }
}
