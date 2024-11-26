using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomService : GenericService<Room>, IRoomService
    {
        public RoomService(IGenericRepository<Room> repository) : base(repository)
        {
        }
    }
}
