using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelProject.DataAccessLayer.Config
{
    public class TestimonialConfig : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasData(
                new Testimonial { TestimonialId = 1, Name = "Eylül Acar", Title = "İşletme Müdürü", Description = "Rastgele Bir Açıklama Ekledim", Image = "/hotel-html-template/img/testimonial-4.jpg" },
                new Testimonial { TestimonialId = 2, Name = "Hadi Acar", Title = "Mağaza Ceosu", Description = "Rastgele Bir Açıklama Ekledim", Image = "/hotel-html-template/img/testimonial-3.jpg" },
                new Testimonial { TestimonialId = 3, Name = "Musa Acar", Title = "İşletme Yöneticisi", Description = "Rastgele Bir Açıklama Ekledim", Image = "/hotel-html-template/img/testimonial-2.jpg" }
                );
        }
    }
}
