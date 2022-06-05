using Microsoft.EntityFrameworkCore.Migrations;

namespace ProniaWepCoreApp.Migrations
{
    public partial class AddCoulumnSliderTableDiscountPercent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountPercent",
                table: "Sliders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountPercent",
                table: "Sliders");
        }
    }
}
