using Microsoft.EntityFrameworkCore.Migrations;

namespace urunKovaniApi.Migrations
{
    public partial class migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "top_stores",
                table: "Shops",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "top_stores",
                table: "Shops");
        }
    }
}
