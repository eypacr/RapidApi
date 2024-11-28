using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : GenericManager<Staff>, IStaffService
    {
        public StaffManager(IGenericRepository<Staff> repository) : base(repository)
        {
        }
    }
}
