using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCCRUD.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    product_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.product_id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "product_id", "product_name", "price" },
                values: new object[,]
                {
                    { 1, "Choy", 500m },
                    { 2, "Qurut", 600m },
                    { 3, "Shaftoli", 700m },
                    { 4, "Daftar", 900m },
                    { 5, "Qulupnay", 1000m },
                    { 6, "Kundalik", 1100m },
                    { 7, "Zaryadchik", 1200m },
                    { 8, "Kefir", 1300m },
                    { 9, "Moloko", 1400m },
                    { 10, "Olma", 1500m },
                    { 11, "Guruch", 1600m },
                    { 12, "Bolalar kiyimi", 1700m },
                    { 13, "Bosma", 1800m },
                    { 14, "Non", 1900m },
                    { 15, "Sabzi", 2000m },
                    { 16, "Gilos", 2100m },
                    { 17, "Sut", 2200m },
                    { 18, "Dorixona yopiq yog'i", 2300m },
                    { 19, "Planshet", 2400m },
                    { 20, "Telefon", 2500m },
                    { 21, "Oshxona mebellari", 2600m },
                    { 22, "Buxanka", 2700m },
                    { 23, "Kofe", 2800m },
                    { 24, "Pishiriqlar", 2900m },
                    { 25, "Ruchka", 3000m },
                    { 26, "Yengil telli choy", 3100m },
                    { 27, "Shokolad", 3200m },
                    { 28, "Plenka", 3300m },
                    { 29, "Komp'yuter", 3400m },
                    { 30, "Paltar", 3500m },
                    { 31, "Disk", 3600m },
                    { 32, "Uchqun", 3700m },
                    { 33, "Konditsioner", 3800m },
                    { 34, "Shampun", 3900m },
                    { 35, "Avtomobil", 4000m },
                    { 36, "Ovqat", 4100m },
                    { 37, "Qush", 4200m },
                    { 38, "Muzlatkich", 4300m },
                    { 39, "Tarvuz", 4400m },
                    { 40, "Mayka", 4500m },
                    { 41, "Mevalar", 4600m },
                    { 42, "Kapusta", 4700m },
                    { 43, "Oshpaz", 4800m },
                    { 44, "Pitsa", 4900m },
                    { 45, "Yog'och", 5000m },
                    { 46, "Futbolka", 5100m },
                    { 47, "Shlyapa", 5200m },
                    { 48, "Mushak", 5300m },
                    { 49, "Tovuq", 5400m },
                    { 50, "Moyinka", 5500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
