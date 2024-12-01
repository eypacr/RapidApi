using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelProject.DataAccessLayer.Config
{
    public class RoomConfig : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room { RoomId=1,RoomNumber="101",RoomCoverImage= "/hotel-html-template/img/room-1.jpg",Price=1240,Title= "Tek Kişilik Oda",BathCount="1",BedCount="1",Wifi="Var",Description= "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet diam sed stet lorem." }
                );
        }
    }
}
