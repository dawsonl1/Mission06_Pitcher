using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6Assignmnet.Migrations
{
    /// <inheritdoc />
    public partial class LimitNotesLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Director",
                table: "MovieRecords",
                newName: "DirectorLastName");

            migrationBuilder.AddColumn<string>(
                name: "DirectorFirstName",
                table: "MovieRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectorFirstName",
                table: "MovieRecords");

            migrationBuilder.RenameColumn(
                name: "DirectorLastName",
                table: "MovieRecords",
                newName: "Director");
        }
    }
}
