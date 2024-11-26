using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialService : GenericService<Testimonial>, ITestimonialService
    {
        public TestimonialService(IGenericRepository<Testimonial> repository) : base(repository)
        {
        }
    }
}
