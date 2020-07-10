using Microsoft.EntityFrameworkCore.Migrations;

namespace urunKovaniApi.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Shops_shopId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "shopId",
                table: "Categories",
                newName: "ShopId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_shopId",
                table: "Categories",
                newName: "IX_Categories_ShopId");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Shops_ShopId",
                table: "Categories",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Shops_ShopId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ShopId",
                table: "Categories",
                newName: "shopId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ShopId",
                table: "Categories",
                newName: "IX_Categories_shopId");

            migrationBuilder.AlterColumn<int>(
                name: "shopId",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ShopId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Shops_shopId",
                table: "Categories",
                column: "shopId",
                principalTable: "Shops",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
