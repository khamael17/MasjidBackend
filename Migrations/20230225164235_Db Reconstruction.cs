using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Masjid.Migrations
{
    /// <inheritdoc />
    public partial class DbReconstruction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimePlace",
                table: "YouthPrograms",
                newName: "YouthProgramTitle");

            migrationBuilder.RenameColumn(
                name: "ProgramDesc",
                table: "YouthPrograms",
                newName: "YouthProgramTimePlace");

            migrationBuilder.RenameColumn(
                name: "ProgTitle",
                table: "YouthPrograms",
                newName: "YouthProgramPrice");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "YouthPrograms",
                newName: "YouthProgramGuest");

            migrationBuilder.RenameColumn(
                name: "Guest",
                table: "YouthPrograms",
                newName: "YouthProgramDesc");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Profiles",
                newName: "ProfileImageUrl");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Profiles",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PrayerTimes",
                newName: "PrayerTimeId");

            migrationBuilder.RenameColumn(
                name: "Time_Place",
                table: "IslamicClasses",
                newName: "IslamicClassTime_Place");

            migrationBuilder.RenameColumn(
                name: "Guest",
                table: "IslamicClasses",
                newName: "IslamicClassGuest");

            migrationBuilder.RenameColumn(
                name: "ClassesTitle",
                table: "IslamicClasses",
                newName: "ClassTitle");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "IslamicClasses",
                newName: "IslamicClasseId");

            migrationBuilder.RenameColumn(
                name: "Narrator",
                table: "Hadiths",
                newName: "HadithNarrator");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hadiths",
                newName: "HadithId");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Events",
                newName: "EventImageUrl");

            migrationBuilder.RenameColumn(
                name: "TimePlace",
                table: "AftSchoolPrograms",
                newName: "AftSchoolProgramTitle");

            migrationBuilder.RenameColumn(
                name: "ProgramDesc",
                table: "AftSchoolPrograms",
                newName: "AftSchoolProgramTimePlace");

            migrationBuilder.RenameColumn(
                name: "ProgTitle",
                table: "AftSchoolPrograms",
                newName: "AftSchoolProgramPrice");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "AftSchoolPrograms",
                newName: "AftSchoolProgramDesc");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AftSchoolPrograms",
                newName: "AftSchoolProgramId");

            migrationBuilder.AlterColumn<string>(
                name: "Jummah",
                table: "PrayerTimes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeedType",
                table: "Feeds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YouthProgramTitle",
                table: "YouthPrograms",
                newName: "TimePlace");

            migrationBuilder.RenameColumn(
                name: "YouthProgramTimePlace",
                table: "YouthPrograms",
                newName: "ProgramDesc");

            migrationBuilder.RenameColumn(
                name: "YouthProgramPrice",
                table: "YouthPrograms",
                newName: "ProgTitle");

            migrationBuilder.RenameColumn(
                name: "YouthProgramGuest",
                table: "YouthPrograms",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "YouthProgramDesc",
                table: "YouthPrograms",
                newName: "Guest");

            migrationBuilder.RenameColumn(
                name: "ProfileImageUrl",
                table: "Profiles",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Profiles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PrayerTimeId",
                table: "PrayerTimes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IslamicClassTime_Place",
                table: "IslamicClasses",
                newName: "Time_Place");

            migrationBuilder.RenameColumn(
                name: "IslamicClassGuest",
                table: "IslamicClasses",
                newName: "Guest");

            migrationBuilder.RenameColumn(
                name: "ClassTitle",
                table: "IslamicClasses",
                newName: "ClassesTitle");

            migrationBuilder.RenameColumn(
                name: "IslamicClasseId",
                table: "IslamicClasses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HadithNarrator",
                table: "Hadiths",
                newName: "Narrator");

            migrationBuilder.RenameColumn(
                name: "HadithId",
                table: "Hadiths",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventImageUrl",
                table: "Events",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "AftSchoolProgramTitle",
                table: "AftSchoolPrograms",
                newName: "TimePlace");

            migrationBuilder.RenameColumn(
                name: "AftSchoolProgramTimePlace",
                table: "AftSchoolPrograms",
                newName: "ProgramDesc");

            migrationBuilder.RenameColumn(
                name: "AftSchoolProgramPrice",
                table: "AftSchoolPrograms",
                newName: "ProgTitle");

            migrationBuilder.RenameColumn(
                name: "AftSchoolProgramDesc",
                table: "AftSchoolPrograms",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "AftSchoolProgramId",
                table: "AftSchoolPrograms",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Jummah",
                table: "PrayerTimes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeedType",
                table: "Feeds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
