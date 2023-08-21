using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_models_brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelID = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cars_models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Toyota" },
                    { 2, false, "Ford" },
                    { 3, false, "Honda" },
                    { 4, false, "BMW" },
                    { 5, false, "Chevrolet" },
                    { 6, false, "Nissan" },
                    { 7, false, "Audi" },
                    { 8, false, "Volkswagen" },
                    { 9, false, "Mercedes" },
                    { 10, false, "Hyundai" }
                });

            migrationBuilder.InsertData(
                table: "models",
                columns: new[] { "Id", "BrandID", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 1, false, "Camry", "Sedan" },
                    { 2, 2, false, "Escape", "SUV" },
                    { 3, 3, false, "Accord", "Sedan" },
                    { 4, 4, false, "3 Series", "Coupe" },
                    { 5, 5, false, "Spark", "Hatch" },
                    { 6, 6, false, "Altima", "Sedan" },
                    { 7, 7, false, "A4", "Sedan" },
                    { 8, 8, false, "Jetta", "Sedan" },
                    { 9, 9, false, "C-Class", "Sedan" },
                    { 10, 10, false, "i20", "Hatch" },
                    { 11, 1, false, "RAV4", "SUV" },
                    { 12, 2, false, "Explorer", "SUV" },
                    { 13, 3, false, "CR-V", "SUV" },
                    { 14, 4, false, "4 Series", "Coupe" },
                    { 15, 5, false, "Malibu", "Sedan" },
                    { 16, 6, false, "Rogue", "SUV" },
                    { 17, 7, false, "A6", "Sedan" },
                    { 18, 8, false, "Passat", "Sedan" },
                    { 19, 9, false, "GLE-Class", "SUV" },
                    { 20, 10, false, "Elantra", "Sedan" }
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "IsDeleted", "ModelID", "Power", "Year" },
                values: new object[,]
                {
                    { 1, false, 1, 180m, 2022 },
                    { 2, false, 2, 200m, 2021 },
                    { 3, false, 3, 190m, 2022 },
                    { 4, false, 4, 250m, 2023 },
                    { 5, false, 5, 100m, 2022 },
                    { 6, false, 6, 180m, 2022 },
                    { 7, false, 7, 200m, 2021 },
                    { 8, false, 8, 190m, 2022 },
                    { 9, false, 9, 250m, 2023 },
                    { 10, false, 10, 100m, 2022 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cars_ModelID",
                table: "cars",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_models_BrandID",
                table: "models",
                column: "BrandID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "models");

            migrationBuilder.DropTable(
                name: "brands");
        }
    }
}
