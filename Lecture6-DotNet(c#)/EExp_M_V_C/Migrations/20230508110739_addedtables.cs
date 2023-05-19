using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EExp_M_V_C.Migrations
{
    /// <inheritdoc />
    public partial class addedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeCredentials",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCredentials", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    SessionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCredentialsEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_Logins_EmployeeCredentials_EmployeeCredentialsEmployeeId",
                        column: x => x.EmployeeCredentialsEmployeeId,
                        principalTable: "EmployeeCredentials",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logins_EmployeeCredentialsEmployeeId",
                table: "Logins",
                column: "EmployeeCredentialsEmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "EmployeeCredentials");
        }
    }
}
