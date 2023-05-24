using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intern_Explorer.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_roles_RolesRoleId",
                table: "EmployeeData");

            migrationBuilder.AlterColumn<string>(
                name: "RolesRoleId",
                table: "EmployeeData",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_roles_RolesRoleId",
                table: "EmployeeData",
                column: "RolesRoleId",
                principalTable: "roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_roles_RolesRoleId",
                table: "EmployeeData");

            migrationBuilder.AlterColumn<string>(
                name: "RolesRoleId",
                table: "EmployeeData",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_roles_RolesRoleId",
                table: "EmployeeData",
                column: "RolesRoleId",
                principalTable: "roles",
                principalColumn: "RoleId");
        }
    }
}
