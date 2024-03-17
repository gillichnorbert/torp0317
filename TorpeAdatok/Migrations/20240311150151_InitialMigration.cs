using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorpeAdatok.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KiHolDolgozott",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TorpekId = table.Column<int>(type: "int", nullable: false),
                    TarnakId = table.Column<int>(type: "int", nullable: false),
                    KitermeltMennyiseg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KiHolDolgozott", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KiHolDolgozott");
        }
    }
}
