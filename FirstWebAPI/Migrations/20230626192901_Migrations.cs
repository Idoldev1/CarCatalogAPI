using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebAPI.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Maker = table.Column<string>(type: "TEXT", nullable: false),
                    Seaters = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    CountryMade = table.Column<string>(type: "TEXT", nullable: false),
                    DateManufactured = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 1, "Honda", "Japan", new DateTime(2001, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honda Motor Co. Ltd", "Honda Civic", 17, 5 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 2, "Ford", "United States", new DateTime(1993, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ford Motor Co.", "Ford Mustang", 10, 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 3, "Toyota", "Japan", new DateTime(2004, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toyota Motor Co.", "Toyota Camry", 7, 5 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 4, "Bayerische Motoren Werke AG", "Germany", new DateTime(1990, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "BMW 3 Series", 7, 5 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 5, "Chevrolet", "United States", new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "General Motors Company", "Chevrolet Silverado", 18, -1 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 6, "Mercedes-Benz", "Germany", new DateTime(2010, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daimler AG", "Mercedes Benz E-Class", 12, 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 7, "Hyundai", "South Korea", new DateTime(2012, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hyundai Motor Co.", "Hyundai Sonata", 18, 5 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 8, "Volkswagen", "Germany", new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volkswagen AG", "Volkswagen Golf", 7, 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 9, "Nissan", "Japan", new DateTime(2016, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nissan Motor Co. Ltd.", "Nissan Rogue", 20, 5 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CountryMade", "DateManufactured", "Maker", "Name", "Quantity", "Seaters" },
                values: new object[] { 10, "Audi", "Germany", new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audi AG", "Audi A4", 4, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
