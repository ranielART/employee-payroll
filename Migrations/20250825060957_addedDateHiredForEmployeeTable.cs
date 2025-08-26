using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace employee_payroll.Migrations
{
    /// <inheritdoc />
    public partial class addedDateHiredForEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "date_hired",
                table: "employees",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "last_payment_date",
                table: "employees",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date_hired",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "last_payment_date",
                table: "employees");
        }
    }
}
