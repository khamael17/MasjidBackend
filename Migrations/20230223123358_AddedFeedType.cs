using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Masjid.Migrations
{
    /// <inheritdoc />
    public partial class AddedFeedType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeedType",
                table: "Feeds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedType",
                table: "Feeds");
        }
    }
}
