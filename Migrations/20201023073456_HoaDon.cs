using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class HoaDon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tentaikhoan = table.Column<string>(nullable: true),
                    ngaymua = table.Column<DateTime>(nullable: false),
                    diachigiaohang = table.Column<string>(nullable: true),
                    sdtgiaohang = table.Column<string>(nullable: true),
                    tongtien = table.Column<int>(nullable: false),
                    trangthai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon");
        }
    }
}
