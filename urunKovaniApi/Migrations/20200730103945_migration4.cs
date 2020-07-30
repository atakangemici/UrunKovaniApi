using Microsoft.EntityFrameworkCore.Migrations;

namespace urunKovaniApi.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "Shops",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "ShopCategories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "Complaints",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "Basket",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner",
                table: "AdminUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "owner",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "ShopCategories");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "url",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "AdminUsers");
        }
    }
}
