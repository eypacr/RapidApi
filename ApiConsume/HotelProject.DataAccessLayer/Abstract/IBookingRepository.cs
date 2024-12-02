using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingRepository : IGenericRepository<Booking>
    {
        Task BookingStatusChangeApprovedAsync(int id);
        Task BookingStatusChangeCancelAsync(int id);
        Task BookingStatusChangeWaitAsync(int id);
    }
}
