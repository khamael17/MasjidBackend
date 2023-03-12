using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Masjid.Migrations
{
    /// <inheritdoc />
    public partial class Intitutiontablereconstructed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "NewPassword",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "OldPassword",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Imam_Email",
                table: "Imams");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageUrl",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Intitutions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Institution_Email",
                table: "Intitutions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NewPassword",
                table: "Intitutions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OldPassword",
                table: "Intitutions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Intitutions");

            migrationBuilder.DropColumn(
                name: "Institution_Email",
                table: "Intitutions");

            migrationBuilder.DropColumn(
                name: "NewPassword",
                table: "Intitutions");

            migrationBuilder.DropColumn(
                name: "OldPassword",
                table: "Intitutions");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageUrl",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NewPassword",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OldPassword",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Imam_Email",
                table: "Imams",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
