using Microsoft.EntityFrameworkCore.Migrations;

namespace Cricket.Migrations
{
    public partial class Cricket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CricketerDetail",
                columns: table => new
                {
                    CricketerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CricketerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalODI = table.Column<long>(type: "bigint", nullable: false),
                    TotalScore = table.Column<long>(type: "bigint", nullable: false),
                    Fifties = table.Column<long>(type: "bigint", nullable: false),
                    Hundreds = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CricketerDetail", x => x.CricketerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CricketerDetail");
        }
    }
}
