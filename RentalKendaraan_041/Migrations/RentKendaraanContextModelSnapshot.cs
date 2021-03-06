﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentalKendaraan_041.Models;

namespace RentalKendaraan_041.Migrations
{
    [DbContext(typeof(RentKendaraanContext))]
    partial class RentKendaraanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RentalKendaraan_041.Models.Customer", b =>
                {
                    b.Property<int>("IdCustomerr")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Customerr")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alamat")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<int?>("IdGender")
                        .HasColumnName("ID_Gender");

                    b.Property<string>("NamaCustomer")
                        .HasColumnName("Nama_Customer")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Nik")
                        .HasColumnName("NIK")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("NoHp")
                        .HasColumnName("No_HP")
                        .HasMaxLength(13)
                        .IsUnicode(false);

                    b.HasKey("IdCustomerr");

                    b.HasIndex("IdGender");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Gender", b =>
                {
                    b.Property<int>("IdGender")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Gender")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NamaGender")
                        .HasColumnName("Nama_Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.HasKey("IdGender");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Jaminan", b =>
                {
                    b.Property<int>("IdJaminan")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Jaminan")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NamaJaminan")
                        .HasColumnName("Nama_Jaminan")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.HasKey("IdJaminan");

                    b.ToTable("Jaminan");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.JenisKendaraan", b =>
                {
                    b.Property<int>("IdJenisKendaraan")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Jenis_Kendaraan")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NamaJenisKendaraan")
                        .HasColumnName("Nama_Jenis_Kendaraan")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdJenisKendaraan");

                    b.ToTable("Jenis_Kendaraan");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Kendaraan", b =>
                {
                    b.Property<int>("IdKendaraan")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Kendaraan")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdJenisKendaraan")
                        .HasColumnName("ID_Jenis_Kendaraan");

                    b.Property<string>("Ketersediaan")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("NamaKendaraan")
                        .HasColumnName("Nama_Kendaraan")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("NoPolisi")
                        .HasColumnName("No_Polisi")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("NoStnk")
                        .HasColumnName("No_STNK")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.HasKey("IdKendaraan");

                    b.HasIndex("IdJenisKendaraan");

                    b.ToTable("Kendaraan");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.KondisiKendaraan", b =>
                {
                    b.Property<int>("IdKondisi")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Kondisi")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NamaKondisi")
                        .HasColumnName("Nama_Kondisi")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdKondisi");

                    b.ToTable("Kondisi_Kendaraan");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Peminjaman", b =>
                {
                    b.Property<int>("IdPeminjaman")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Peminjaman")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Biaya");

                    b.Property<int?>("IdCostumer")
                        .HasColumnName("ID_Costumer");

                    b.Property<int?>("IdJaminan")
                        .HasColumnName("ID_Jaminan");

                    b.Property<int?>("IdKendaraan")
                        .HasColumnName("ID_Kendaraan");

                    b.Property<DateTime?>("TglPeminjaman")
                        .HasColumnName("Tgl_Peminjaman")
                        .HasColumnType("datetime");

                    b.HasKey("IdPeminjaman");

                    b.HasIndex("IdCostumer");

                    b.HasIndex("IdJaminan");

                    b.HasIndex("IdKendaraan");

                    b.ToTable("Peminjaman");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Pengembalian", b =>
                {
                    b.Property<int>("IdPengembalian")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Pengembalian")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Denda");

                    b.Property<int?>("IdKondisi")
                        .HasColumnName("ID_Kondisi");

                    b.Property<int?>("IdPeminjaman")
                        .HasColumnName("ID_Peminjaman");

                    b.Property<DateTime?>("TglPengembalian")
                        .HasColumnName("Tgl_Pengembalian")
                        .HasColumnType("datetime");

                    b.HasKey("IdPengembalian");

                    b.HasIndex("IdKondisi");

                    b.HasIndex("IdPeminjaman");

                    b.ToTable("Pengembalian");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Customer", b =>
                {
                    b.HasOne("RentalKendaraan_041.Models.Gender", "IdGenderNavigation")
                        .WithMany("Customer")
                        .HasForeignKey("IdGender")
                        .HasConstraintName("FK_Customer_Gender");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Kendaraan", b =>
                {
                    b.HasOne("RentalKendaraan_041.Models.JenisKendaraan", "IdJenisKendaraanNavigation")
                        .WithMany("Kendaraan")
                        .HasForeignKey("IdJenisKendaraan")
                        .HasConstraintName("FK_Kendaraan_Jenis_Kendaraan");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Peminjaman", b =>
                {
                    b.HasOne("RentalKendaraan_041.Models.Customer", "IdCostumerNavigation")
                        .WithMany("Peminjaman")
                        .HasForeignKey("IdCostumer")
                        .HasConstraintName("FK_Peminjaman_Customer");

                    b.HasOne("RentalKendaraan_041.Models.Jaminan", "IdJaminanNavigation")
                        .WithMany("Peminjaman")
                        .HasForeignKey("IdJaminan")
                        .HasConstraintName("FK_Peminjaman_Jaminan");

                    b.HasOne("RentalKendaraan_041.Models.Kendaraan", "IdKendaraanNavigation")
                        .WithMany("Peminjaman")
                        .HasForeignKey("IdKendaraan")
                        .HasConstraintName("FK_Peminjaman_Kendaraan");
                });

            modelBuilder.Entity("RentalKendaraan_041.Models.Pengembalian", b =>
                {
                    b.HasOne("RentalKendaraan_041.Models.KondisiKendaraan", "IdKondisiNavigation")
                        .WithMany("Pengembalian")
                        .HasForeignKey("IdKondisi")
                        .HasConstraintName("FK_Pengembalian_Kondisi_Kendaraan");

                    b.HasOne("RentalKendaraan_041.Models.Peminjaman", "IdPeminjamanNavigation")
                        .WithMany("Pengembalian")
                        .HasForeignKey("IdPeminjaman")
                        .HasConstraintName("FK_Pengembalian_Peminjaman");
                });
#pragma warning restore 612, 618
        }
    }
}
