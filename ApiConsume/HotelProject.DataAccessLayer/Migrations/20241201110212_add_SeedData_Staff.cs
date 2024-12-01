using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class add_SeedData_Staff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Name", "SocialMedia1", "SocialMedia2", "SocialMedia3", "Title" },
                values: new object[] { 1, "Hadi", "/hotel-html-template/img/team-1.jpg", "x", "y", "House Keaper" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Name", "SocialMedia1", "SocialMedia2", "SocialMedia3", "Title" },
                values: new object[] { 2, "Ali", "/hotel-html-template/img/team-2.jpg", "x", "y", "Genel Müdür" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 2);
        }
    }
}
