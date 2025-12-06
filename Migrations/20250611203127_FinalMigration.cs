using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseApp.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    RequiredCertifications = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleTerminals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleTerminals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    MonthlySalaryUsd = table.Column<int>(type: "INTEGER", nullable: false),
                    BonusSalaryUsd = table.Column<int>(type: "INTEGER", nullable: false),
                    IsManager = table.Column<bool>(type: "INTEGER", nullable: false),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssignedSaleTerminalId = table.Column<int>(type: "INTEGER", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    WorksNightShift = table.Column<bool>(type: "INTEGER", nullable: true),
                    WeeklyHours = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_SaleTerminals_AssignedSaleTerminalId",
                        column: x => x.AssignedSaleTerminalId,
                        principalTable: "SaleTerminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTimeOfCreation = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateTimeOfPayment = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleTerminalId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_SaleTerminals_SaleTerminalId",
                        column: x => x.SaleTerminalId,
                        principalTable: "SaleTerminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barcode = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    WeightKg = table.Column<float>(type: "REAL", nullable: false),
                    PriceUsd = table.Column<float>(type: "REAL", nullable: false),
                    AdditionalNote = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentDetailsId = table.Column<int>(type: "INTEGER", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    CalorieCount = table.Column<int>(type: "INTEGER", nullable: true),
                    FatCount = table.Column<int>(type: "INTEGER", nullable: true),
                    HeightCm = table.Column<int>(type: "INTEGER", nullable: true),
                    WidthCm = table.Column<int>(type: "INTEGER", nullable: true),
                    DosageMg = table.Column<int>(type: "INTEGER", nullable: true),
                    NeedsPrescription = table.Column<bool>(type: "INTEGER", nullable: true),
                    EngagementRating = table.Column<int>(type: "INTEGER", nullable: true),
                    EdibleToy_CalorieCount = table.Column<int>(type: "INTEGER", nullable: true),
                    EdibleToy_FatCount = table.Column<int>(type: "INTEGER", nullable: true),
                    Softness = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_PaymentDetails_PaymentDetailsId",
                        column: x => x.PaymentDetailsId,
                        principalTable: "PaymentDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AssignedSaleTerminalId",
                table: "Employees",
                column: "AssignedSaleTerminalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_SaleTerminalId",
                table: "PaymentDetails",
                column: "SaleTerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PaymentDetailsId",
                table: "Products",
                column: "PaymentDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "SaleTerminals");
        }
    }
}
