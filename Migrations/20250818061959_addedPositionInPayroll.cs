using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace employee_payroll.Migrations
{
    /// <inheritdoc />
    public partial class addedPositionInPayroll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "employee_position",
                table: "payrolls",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "employee_position",
                table: "payrolls");
        }
    }
}
