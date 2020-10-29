using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class CTHoaDon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GioHangid",
                table: "SanPham",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tentaikhoan = table.Column<string>(nullable: true),
                    TaiKhoanid = table.Column<string>(nullable: true),
                    masp = table.Column<string>(nullable: true),
                    soluong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.id);
                    table.ForeignKey(
                        name: "FK_GioHang_TaiKhoan_TaiKhoanid",
                        column: x => x.TaiKhoanid,
                        principalTable: "TaiKhoan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_GioHangid",
                table: "SanPham",
                column: "GioHangid");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_TaiKhoanid",
                table: "GioHang",
                column: "TaiKhoanid");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_GioHang_GioHangid",
                table: "SanPham",
                column: "GioHangid",
                principalTable: "GioHang",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_GioHang_GioHangid",
                table: "SanPham");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_GioHangid",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "GioHangid",
                table: "SanPham");
        }
    }
}
