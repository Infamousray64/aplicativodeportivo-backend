using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AplicativoDeportivoWeb.Migrations
{
    /// <inheritdoc />
    public partial class CalendarExerciseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalendarExercise",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Lunes = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Martes = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Miercoles = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Jueves = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Viernes = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Sabado = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Domingo = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarExercise", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarExercise");
        }
    }
}
