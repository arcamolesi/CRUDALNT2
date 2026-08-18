using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDALNT2.Migrations
{
    /// <inheritdoc />
    public partial class curso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "curso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    area = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    sigla = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "curso");
        }
    }
}
