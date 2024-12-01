using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class add_SeedData_Testimonial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "TestimonialId", "Description", "Image", "Name", "Title" },
                values: new object[] { 1, "Rastgele Bir Açıklama Ekledim", "/hotel-html-template/img/testimonial-4.jpg", "Eylül Acar", "İşletme Müdürü" });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "TestimonialId", "Description", "Image", "Name", "Title" },
                values: new object[] { 2, "Rastgele Bir Açıklama Ekledim", "/hotel-html-template/img/testimonial-3.jpg", "Hadi Acar", "Mağaza Ceosu" });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "TestimonialId", "Description", "Image", "Name", "Title" },
                values: new object[] { 3, "Rastgele Bir Açıklama Ekledim", "/hotel-html-template/img/testimonial-2.jpg", "Musa Acar", "İşletme Yöneticisi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialId",
                keyValue: 3);
        }
    }
}
