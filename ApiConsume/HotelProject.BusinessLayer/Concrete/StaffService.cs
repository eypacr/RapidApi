using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffService : GenericService<Staff>, IStaffService
    {
        public StaffService(IGenericRepository<Staff> repository) : base(repository)
        {
        }
    }
}
