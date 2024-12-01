using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelProject.DataAccessLayer.Config
{
    public class ServiceConfig : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasData(
                new Service { ServiceId = 1, ServiceIcon = "fa fa-hotel fa-2x text-primary", Title = "Odalarımız", Description = "Odalarımız Çok Rahat" },
                new Service { ServiceId = 2, ServiceIcon = "fa fa-utensils fa-2x text-primary", Title = "Yemek & Restorant", Description = "Yemek Ve Restorant Açıklaması" },
                new Service { ServiceId = 3, ServiceIcon = "fa fa-spa fa-2x text-primary", Title = "Spa & Fitness", Description = "Spa Ve Fitnes Açıklaması" },
                new Service { ServiceId = 4, ServiceIcon = "fa fa-swimmer fa-2x text-primary", Title = "Spor & Oyunlar", Description = "Spor ve oyunlar Oynama İmkanı" },
                new Service { ServiceId = 5, ServiceIcon = "fa fa-glass-cheers fa-2x text-primary", Title = "Kutlama & Eğlence", Description = "Kutlama Ve Eğlence Organizasyonu" },
                new Service { ServiceId = 6, ServiceIcon = "fa fa-dumbbell fa-2x text-primary", Title = "Yoga & Meditasyon", Description = "Yoga ve Meditasyon" }
                );
        }
    }
}
