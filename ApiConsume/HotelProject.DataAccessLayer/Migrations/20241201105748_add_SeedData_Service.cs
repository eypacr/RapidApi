using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class add_SeedData_Service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "Description", "ServiceIcon", "Title" },
                values: new object[,]
                {
                    { 1, "Odalarımız Çok Rahat", "fa fa-hotel fa-2x text-primary", "Odalarımız" },
                    { 2, "Yemek Ve Restorant Açıklaması", "fa fa-utensils fa-2x text-primary", "Yemek & Restorant" },
                    { 3, "Spa Ve Fitnes Açıklaması", "fa fa-spa fa-2x text-primary", "Spa & Fitness" },
                    { 4, "Spor ve oyunlar Oynama İmkanı", "fa fa-swimmer fa-2x text-primary", "Spor & Oyunlar" },
                    { 5, "Kutlama Ve Eğlence Organizasyonu", "fa fa-glass-cheers fa-2x text-primary", "Kutlama & Eğlence" },
                    { 6, "Yoga ve Meditasyon", "fa fa-dumbbell fa-2x text-primary", "Yoga & Meditasyon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 6);
        }
    }
}
