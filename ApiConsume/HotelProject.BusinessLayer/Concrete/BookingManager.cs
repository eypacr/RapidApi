using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : GenericManager<Booking>, IBookingService
    {
        private readonly IBookingRepository _bookingrepository;
        public BookingManager(IGenericRepository<Booking> repository,IBookingRepository bookingRepository) : base(repository)
        {
            _bookingrepository = bookingRepository;
        }

        public async Task TBookingStatusChangeApprovedAsync(int id)
        {
            await _bookingrepository.BookingStatusChangeApprovedAsync(id);
        }

        public async Task TBookingStatusChangeCancelAsync(int id)
        {
            await _bookingrepository.BookingStatusChangeCancelAsync(id);
        }

        public async Task TBookingStatusChangeWaitAsync(int id)
        {
            await _bookingrepository.BookingStatusChangeWaitAsync(id);
        }
    }
}
