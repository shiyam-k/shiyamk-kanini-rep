using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeExplorer_M_V_C.Migrations
{
    /// <inheritdoc />
    public partial class alter2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerProjects_ManagerProjects_ManagerProjectId",
                table: "EngineerProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_ManagerProjects_Projects_ProjectsProjectId",
                table: "ManagerProjects");

            migrationBuilder.DropIndex(
                name: "IX_EngineerProjects_ManagerProjectId",
                table: "EngineerProjects");

            migrationBuilder.DropColumn(
                name: "ManagerProjectId",
                table: "EngineerProjects");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectsProjectId",
                table: "ManagerProjects",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerProjects_Projects_ProjectsProjectId",
                table: "ManagerProjects",
                column: "ProjectsProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManagerProjects_Projects_ProjectsProjectId",
                table: "ManagerProjects");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectsProjectId",
                table: "ManagerProjects",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ManagerProjectId",
                table: "EngineerProjects",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerProjects_ManagerProjectId",
                table: "EngineerProjects",
                column: "ManagerProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerProjects_ManagerProjects_ManagerProjectId",
                table: "EngineerProjects",
                column: "ManagerProjectId",
                principalTable: "ManagerProjects",
                principalColumn: "ManagerProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerProjects_Projects_ProjectsProjectId",
                table: "ManagerProjects",
                column: "ProjectsProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");
        }
    }
}
