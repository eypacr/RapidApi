using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : GenericManager<Booking>, IBookingService
    {
        public BookingManager(IGenericRepository<Booking> repository) : base(repository)
        {
        }
    }
}
