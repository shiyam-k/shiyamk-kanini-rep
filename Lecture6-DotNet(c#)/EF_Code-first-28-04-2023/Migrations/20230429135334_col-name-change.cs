using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Code_first_28_04_2023.Migrations
{
    /// <inheritdoc />
    public partial class colnamechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PNName",
                table: "Patients",
                newName: "PName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PName",
                table: "Patients",
                newName: "PNName");
        }
    }
}
