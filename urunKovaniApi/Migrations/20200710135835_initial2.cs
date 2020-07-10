using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace urunKovaniApi.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shops_ShopCategory_ShopCategoryId",
                table: "Shops");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ShopCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeUserteriUser",
                table: "EmployeeUserteriUser");

            migrationBuilder.RenameTable(
                name: "EmployeeUserteriUser",
                newName: "EmployeeUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeUser",
                table: "EmployeeUser",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_by = table.Column<int>(nullable: true),
                    updated_by = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: true),
                    deleted = table.Column<bool>(nullable: false),
                    employee_id = table.Column<int>(nullable: false),
                    shop_id = table.Column<int>(nullable: false),
                    shop_name = table.Column<string>(nullable: true),
                    product_id = table.Column<int>(nullable: false),
                    order_total = table.Column<int>(nullable: false),
                    payment_type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ShopCategories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_by = table.Column<int>(nullable: true),
                    updated_by = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: true),
                    deleted = table.Column<bool>(nullable: false),
                    category_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCategories", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_ShopCategories_ShopCategoryId",
                table: "Shops",
                column: "ShopCategoryId",
                principalTable: "ShopCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shops_ShopCategories_ShopCategoryId",
                table: "Shops");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ShopCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeUser",
                table: "EmployeeUser");

            migrationBuilder.RenameTable(
                name: "EmployeeUser",
                newName: "EmployeeUserteriUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeUserteriUser",
                table: "EmployeeUserteriUser",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<int>(nullable: true),
                    deleted = table.Column<bool>(nullable: false),
                    employee_id = table.Column<int>(nullable: false),
                    order_total = table.Column<int>(nullable: false),
                    payment_type = table.Column<string>(nullable: true),
                    product_id = table.Column<int>(nullable: false),
                    shop_id = table.Column<int>(nullable: false),
                    shop_name = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true),
                    updated_by = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ShopCategory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<int>(nullable: true),
                    deleted = table.Column<bool>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: true),
                    updated_by = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCategory", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_ShopCategory_ShopCategoryId",
                table: "Shops",
                column: "ShopCategoryId",
                principalTable: "ShopCategory",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
