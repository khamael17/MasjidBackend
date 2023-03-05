using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Masjid.Migrations
{
    /// <inheritdoc />
    public partial class newdevice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AftSchoolProgramTimePlace",
                table: "AftSchoolPrograms");

            migrationBuilder.RenameColumn(
                name: "YouthProgramTimePlace",
                table: "YouthPrograms",
                newName: "YouthProgramTime");

            migrationBuilder.RenameColumn(
                name: "AftSchoolProgramPrice",
                table: "Events",
                newName: "EventPrice");

            migrationBuilder.AddColumn<string>(
                name: "YouthProgramPlace",
                table: "YouthPrograms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Imam_Email",
                table: "Imams",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EventTime_Place",
                table: "Events",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AftSchoolProgramPlace",
                table: "AftSchoolPrograms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AftSchoolProgramTime",
                table: "AftSchoolPrograms",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YouthProgramPlace",
                table: "YouthPrograms");

            migrationBuilder.DropColumn(
                name: "Imam_Email",
                table: "Imams");

            migrationBuilder.DropColumn(
                name: "EventTime_Place",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AftSchoolProgramPlace",
                table: "AftSchoolPrograms");

            migrationBuilder.DropColumn(
                name: "AftSchoolProgramTime",
                table: "AftSchoolPrograms");

            migrationBuilder.RenameColumn(
                name: "YouthProgramTime",
                table: "YouthPrograms",
                newName: "YouthProgramTimePlace");

            migrationBuilder.RenameColumn(
                name: "EventPrice",
                table: "Events",
                newName: "AftSchoolProgramPrice");

            migrationBuilder.AddColumn<string>(
                name: "AftSchoolProgramTimePlace",
                table: "AftSchoolPrograms",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
