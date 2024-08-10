using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace firstlearning.Migrations
{
    /// <inheritdoc />
    public partial class THIRDmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://pics7.baidu.com/feed/6a63f6246b600c3371c5886e47f0c209d8f9a11f.jpeg@f_auto?token=a3b880c0e120616b680421c1b7a3731f");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://assets.reluctantgourmet.com/wp-content/uploads/2012/07/02133125/braised-chilean-sea-bass-d3.jpeg");
        }
    }
}
