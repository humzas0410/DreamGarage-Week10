using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamGarage.Migrations
{
    /// <inheritdoc />
    public partial class AddImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/mclaren720s.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://media.carsandbids.com/cdn-cgi/image/width=2080,quality=70/9004500a220bf3a3d455d15ee052cf8c332606f8/photos/3gq6xaNP-5Zzhy1THp9-(edit).jpg?t=165820835234");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.exclusiveautomotivegroup.com/imagetag/3448/main/l/Used-2022-Lamborghini-Aventador-1669662938.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.hgmsites.net/med/2021-bmw-5-series_100749425_m.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCzXMrQ-8uctEwhXVIFMlsXrUwDXIsD-10xRob7ip8Yg&s=10");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://hips.hearstapps.com/hmg-prod/images/2025-rimac-nevera-pr-101-691b428773e01.jpg?crop=0.780xw:0.656xh;0.175xw,0.344xh&resize=2048:*");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cars");
        }
    }
}
