using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalKendaraan_041.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    ID_Gender = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nama_Gender = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.ID_Gender);
                });

            migrationBuilder.CreateTable(
                name: "Jaminan",
                columns: table => new
                {
                    ID_Jaminan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nama_Jaminan = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jaminan", x => x.ID_Jaminan);
                });

            migrationBuilder.CreateTable(
                name: "Jenis_Kendaraan",
                columns: table => new
                {
                    ID_Jenis_Kendaraan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nama_Jenis_Kendaraan = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jenis_Kendaraan", x => x.ID_Jenis_Kendaraan);
                });

            migrationBuilder.CreateTable(
                name: "Kondisi_Kendaraan",
                columns: table => new
                {
                    ID_Kondisi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nama_Kondisi = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kondisi_Kendaraan", x => x.ID_Kondisi);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID_Customerr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nama_Customer = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    NIK = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    Alamat = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    No_HP = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    ID_Gender = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID_Customerr);
                    table.ForeignKey(
                        name: "FK_Customer_Gender",
                        column: x => x.ID_Gender,
                        principalTable: "Gender",
                        principalColumn: "ID_Gender",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kendaraan",
                columns: table => new
                {
                    ID_Kendaraan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nama_Kendaraan = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    No_Polisi = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    No_STNK = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    ID_Jenis_Kendaraan = table.Column<int>(nullable: true),
                    Ketersediaan = table.Column<string>(unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kendaraan", x => x.ID_Kendaraan);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Jenis_Kendaraan",
                        column: x => x.ID_Jenis_Kendaraan,
                        principalTable: "Jenis_Kendaraan",
                        principalColumn: "ID_Jenis_Kendaraan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Peminjaman",
                columns: table => new
                {
                    ID_Peminjaman = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tgl_Peminjaman = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_Kendaraan = table.Column<int>(nullable: true),
                    ID_Costumer = table.Column<int>(nullable: true),
                    ID_Jaminan = table.Column<int>(nullable: true),
                    Biaya = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peminjaman", x => x.ID_Peminjaman);
                    table.ForeignKey(
                        name: "FK_Peminjaman_Customer",
                        column: x => x.ID_Costumer,
                        principalTable: "Customer",
                        principalColumn: "ID_Customerr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Peminjaman_Jaminan",
                        column: x => x.ID_Jaminan,
                        principalTable: "Jaminan",
                        principalColumn: "ID_Jaminan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Peminjaman_Kendaraan",
                        column: x => x.ID_Kendaraan,
                        principalTable: "Kendaraan",
                        principalColumn: "ID_Kendaraan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pengembalian",
                columns: table => new
                {
                    ID_Pengembalian = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tgl_Pengembalian = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_Peminjaman = table.Column<int>(nullable: true),
                    ID_Kondisi = table.Column<int>(nullable: true),
                    Denda = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengembalian", x => x.ID_Pengembalian);
                    table.ForeignKey(
                        name: "FK_Pengembalian_Kondisi_Kendaraan",
                        column: x => x.ID_Kondisi,
                        principalTable: "Kondisi_Kendaraan",
                        principalColumn: "ID_Kondisi",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pengembalian_Peminjaman",
                        column: x => x.ID_Peminjaman,
                        principalTable: "Peminjaman",
                        principalColumn: "ID_Peminjaman",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ID_Gender",
                table: "Customer",
                column: "ID_Gender");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_ID_Jenis_Kendaraan",
                table: "Kendaraan",
                column: "ID_Jenis_Kendaraan");

            migrationBuilder.CreateIndex(
                name: "IX_Peminjaman_ID_Costumer",
                table: "Peminjaman",
                column: "ID_Costumer");

            migrationBuilder.CreateIndex(
                name: "IX_Peminjaman_ID_Jaminan",
                table: "Peminjaman",
                column: "ID_Jaminan");

            migrationBuilder.CreateIndex(
                name: "IX_Peminjaman_ID_Kendaraan",
                table: "Peminjaman",
                column: "ID_Kendaraan");

            migrationBuilder.CreateIndex(
                name: "IX_Pengembalian_ID_Kondisi",
                table: "Pengembalian",
                column: "ID_Kondisi");

            migrationBuilder.CreateIndex(
                name: "IX_Pengembalian_ID_Peminjaman",
                table: "Pengembalian",
                column: "ID_Peminjaman");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pengembalian");

            migrationBuilder.DropTable(
                name: "Kondisi_Kendaraan");

            migrationBuilder.DropTable(
                name: "Peminjaman");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Jaminan");

            migrationBuilder.DropTable(
                name: "Kendaraan");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Jenis_Kendaraan");
        }
    }
}
