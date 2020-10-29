using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebASP.NetCoreMVCTemplate.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    fullname = table.Column<string>(nullable: true),
                    isAdmin = table.Column<bool>(nullable: false),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "productTypes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountId = table.Column<int>(nullable: false),
                    productId = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Carts_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "Accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountId = table.Column<int>(nullable: false),
                    issuedDate = table.Column<DateTime>(nullable: false),
                    shippingAddress = table.Column<string>(nullable: true),
                    shippingPhone = table.Column<string>(nullable: true),
                    totalPrice = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.id);
                    table.ForeignKey(
                        name: "FK_Invoices_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "Accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invoiceId = table.Column<int>(nullable: false),
                    productId = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    unitPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoices_invoiceId",
                        column: x => x.invoiceId,
                        principalTable: "Invoices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    info = table.Column<string>(nullable: true),
                    unitPrice = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    productTypeId = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    InvoiceDetailid = table.Column<int>(nullable: true),
                    Cartid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_Carts_Cartid",
                        column: x => x.Cartid,
                        principalTable: "Carts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_InvoiceDetails_InvoiceDetailid",
                        column: x => x.InvoiceDetailid,
                        principalTable: "InvoiceDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_productTypes_productTypeId",
                        column: x => x.productTypeId,
                        principalTable: "productTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_accountId",
                table: "Carts",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_invoiceId",
                table: "InvoiceDetails",
                column: "invoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_accountId",
                table: "Invoices",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_products_Cartid",
                table: "products",
                column: "Cartid");

            migrationBuilder.CreateIndex(
                name: "IX_products_InvoiceDetailid",
                table: "products",
                column: "InvoiceDetailid");

            migrationBuilder.CreateIndex(
                name: "IX_products_productTypeId",
                table: "products",
                column: "productTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "productTypes");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
