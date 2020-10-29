﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBanHang.Data;

namespace WebBanHang.Migrations
{
    [DbContext(typeof(MvcBanHangContext))]
    [Migration("20201023073456_HoaDon")]
    partial class HoaDon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebBanHang.Models.HoaDon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diachigiaohang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaymua")
                        .HasColumnType("datetime2");

                    b.Property<string>("sdtgiaohang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tentaikhoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tongtien")
                        .HasColumnType("int");

                    b.Property<bool>("trangthai")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("WebBanHang.Models.LoaiSanPham", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tenloaisp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangthai")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("LoaiSanPham");
                });

            modelBuilder.Entity("WebBanHang.Models.SanPham", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoaiSanPhamid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("anhminhhoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("giatien")
                        .HasColumnType("int");

                    b.Property<string>("maloaisp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soluongtonkho")
                        .HasColumnType("int");

                    b.Property<string>("tensp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thongtin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangthai")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("LoaiSanPhamid");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("WebBanHang.Models.SanPham", b =>
                {
                    b.HasOne("WebBanHang.Models.LoaiSanPham", "LoaiSanPham")
                        .WithMany("SanPhams")
                        .HasForeignKey("LoaiSanPhamid");
                });
#pragma warning restore 612, 618
        }
    }
}
