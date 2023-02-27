using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Masjid.Migrations
{
    /// <inheritdoc />
    public partial class InstitutionprimaKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imams",
                columns: table => new
                {
                    ImamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imam_First_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Imam_Last_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imams", x => x.ImamId);
                });

            migrationBuilder.CreateTable(
                name: "Intitutions",
                columns: table => new
                {
                    InstitutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstitutionName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intitutions", x => x.InstitutionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imams");

            migrationBuilder.DropTable(
                name: "Intitutions");
        }
    }
}
