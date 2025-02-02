using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccsessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Antique2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuRights",
                columns: table => new
                {
                    MenuRightID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuNameRight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuRightSmallPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuRightLargePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuRightImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRights", x => x.MenuRightID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRights");
        }
    }
}
