using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Masjid.Migrations
{
    /// <inheritdoc />
    public partial class removeFeedTp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedType",
                table: "Feeds");

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmPassword",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeedColor",
                table: "Feeds",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedColor",
                table: "Feeds");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConfirmPassword",
                table: "Profiles",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FeedType",
                table: "Feeds",
                type: "int",
                nullable: true);
        }
    }
}
