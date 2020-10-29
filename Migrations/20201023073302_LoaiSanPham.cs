using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class LoaiSanPham : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoaiSanPhamid",
                table: "SanPham",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    tenloaisp = table.Column<string>(nullable: true),
                    trangthai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamid",
                table: "SanPham",
                column: "LoaiSanPhamid");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_LoaiSanPhamid",
                table: "SanPham",
                column: "LoaiSanPhamid",
                principalTable: "LoaiSanPham",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_LoaiSanPhamid",
                table: "SanPham");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_LoaiSanPhamid",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "LoaiSanPhamid",
                table: "SanPham");
        }
    }
}
