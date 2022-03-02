using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingProject.Migrations
{
    public partial class secondone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeriodsId",
                table: "BusySlots");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PeriodsId",
                table: "BusySlots",
                type: "bigint",
                nullable: true);
        }
    }
}
