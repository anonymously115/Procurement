using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Procurement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeBelonging",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EmployeeCode = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EmployeeFullName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EmployeeAffiliationOrganizationCode = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EmployeeAffiliationOrganizationName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EmployeeAffiliationUpperOrganizationCode = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EmployeeAffiliationUpperOrganizationName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EmployeeJobTitleCode = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EmployeeHandJobTitle = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ReportTargetEmployeeCode = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ReportTargetEmployeeFullName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBelonging", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeBelonging");
        }
    }
}
