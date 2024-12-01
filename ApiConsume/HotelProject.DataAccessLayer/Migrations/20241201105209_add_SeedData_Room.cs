using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class add_SeedData_Room : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "BathCount", "BedCount", "Description", "Price", "RoomCoverImage", "RoomNumber", "Title", "Wifi" },
                values: new object[] { 1, "1", "1", "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet diam sed stet lorem.", 1240, "/hotel-html-template/img/room-1.jpg", "101", "Tek Kişilik Oda", "Var" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);
        }
    }
}
