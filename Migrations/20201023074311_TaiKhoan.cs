using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class TaiKhoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanid",
                table: "HoaDon",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    matkhau = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    sdt = table.Column<string>(nullable: true),
                    diachi = table.Column<int>(nullable: false),
                    hoten = table.Column<string>(nullable: true),
                    laAdmin = table.Column<bool>(nullable: false),
                    anhdaidien = table.Column<string>(nullable: true),
                    trangthai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_TaiKhoanid",
                table: "HoaDon",
                column: "TaiKhoanid");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_TaiKhoan_TaiKhoanid",
                table: "HoaDon",
                column: "TaiKhoanid",
                principalTable: "TaiKhoan",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_TaiKhoan_TaiKhoanid",
                table: "HoaDon");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_TaiKhoanid",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "TaiKhoanid",
                table: "HoaDon");
        }
    }
}
