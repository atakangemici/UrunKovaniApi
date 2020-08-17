using Microsoft.EntityFrameworkCore.Migrations;

namespace urunKovaniApi.Migrations
{
    public partial class migration13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shops_ShopCategories_ShopCategoryId",
                table: "Shops");

            migrationBuilder.RenameColumn(
                name: "ShopCategoryId",
                table: "Shops",
                newName: "SystemCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Shops_ShopCategoryId",
                table: "Shops",
                newName: "IX_Shops_SystemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_ShopCategories_SystemCategoryId",
                table: "Shops",
                column: "SystemCategoryId",
                principalTable: "ShopCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shops_ShopCategories_SystemCategoryId",
                table: "Shops");

            migrationBuilder.RenameColumn(
                name: "SystemCategoryId",
                table: "Shops",
                newName: "ShopCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Shops_SystemCategoryId",
                table: "Shops",
                newName: "IX_Shops_ShopCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_ShopCategories_ShopCategoryId",
                table: "Shops",
                column: "ShopCategoryId",
                principalTable: "ShopCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
