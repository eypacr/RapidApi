using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelProject.DataAccessLayer.Config
{
    public class StaffConfig : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff { StaffId = 1, Name = "Hadi", Title = "House Keaper", SocialMedia1 = "/hotel-html-template/img/team-1.jpg", SocialMedia2 = "x", SocialMedia3 = "y" },
                new Staff { StaffId = 2, Name = "Ali", Title = "Genel Müdür", SocialMedia1 = "/hotel-html-template/img/team-2.jpg", SocialMedia2 = "x", SocialMedia3 = "y" }
                );
        }
    }
}
