using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        Task TBookingStatusChangeApprovedAsync(int id);
        Task TBookingStatusChangeCancelAsync(int id);
        Task TBookingStatusChangeWaitAsync(int id);
    }
}
