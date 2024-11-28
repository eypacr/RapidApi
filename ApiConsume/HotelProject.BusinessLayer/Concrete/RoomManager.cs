using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : GenericManager<Room>, IRoomService
    {
        public RoomManager(IGenericRepository<Room> repository) : base(repository)
        {
        }
    }
}
