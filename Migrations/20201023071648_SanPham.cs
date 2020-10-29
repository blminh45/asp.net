using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class SanPham : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    tensp = table.Column<string>(nullable: true),
                    thongtin = table.Column<string>(nullable: true),
                    giatien = table.Column<int>(nullable: false),
                    soluongtonkho = table.Column<int>(nullable: false),
                    maloaisp = table.Column<string>(nullable: true),
                    anhminhhoa = table.Column<string>(nullable: true),
                    trangthai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
