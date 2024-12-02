using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        private readonly Context _context;
        public BookingRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task BookingStatusChangeApprovedAsync(int id)
        {
            // Veritabanından eşleşen Booking nesnesini al
            var values = await _context.Bookings.FindAsync(id);

            // Status değerini güncelle
            values.Status = "Onaylandı";

            // Değişiklikleri kaydet
            await _context.SaveChangesAsync();
        }

        public async Task BookingStatusChangeCancelAsync(int id)
        {
            var values = await _context.Bookings.FindAsync(id);
            values.Status = "İptal Edildi";
            await _context.SaveChangesAsync();
        }

        public async Task BookingStatusChangeWaitAsync(int id)
        {
            var values = await _context.Bookings.FindAsync(id);
            values.Status = "Müşteri Aranacak";
            await _context.SaveChangesAsync();
        }
    }
}
