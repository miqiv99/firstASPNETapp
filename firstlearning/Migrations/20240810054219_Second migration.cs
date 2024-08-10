using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace firstlearning.Migrations
{
    /// <inheritdoc />
    public partial class Secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://assets.reluctantgourmet.com/wp-content/uploads/2012/07/02133125/braised-chilean-sea-bass-d3.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.reluctantgourmet.com%2Fbraised-sea-bass-recipe%2F&psig=AOvVaw1ablhu2JCVZ8Vi5cXnfSxl&ust=1723350623840000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCMCJ-brL6YcDFQAAAAAdAAAAABAE");
        }
    }
}
