using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternzConnectAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeData",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeDOJ = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stream = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EmployeePasswordKey = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeData", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "LoginLogs",
                columns: table => new
                {
                    SessionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginLogs", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_LoginLogs_EmployeeData_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "EmployeeData",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRoles",
                columns: table => new
                {
                    ERId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RoleId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoles", x => x.ERId);
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_EmployeeData_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "EmployeeData",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Roles_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRoles_EmployeeId1",
                table: "EmployeeRoles",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRoles_RoleId1",
                table: "EmployeeRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_LoginLogs_EmployeeId1",
                table: "LoginLogs",
                column: "EmployeeId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeRoles");

            migrationBuilder.DropTable(
                name: "LoginLogs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "EmployeeData");
        }
    }
}
