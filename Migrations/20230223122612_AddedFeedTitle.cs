using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Masjid.Migrations
{
    /// <inheritdoc />
    public partial class AddedFeedTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeedTitle",
                table: "Feeds",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedTitle",
                table: "Feeds");
        }
    }
}
