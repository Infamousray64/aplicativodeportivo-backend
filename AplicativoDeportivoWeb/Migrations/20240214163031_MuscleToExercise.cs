using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicativoDeportivoWeb.Migrations
{
    /// <inheritdoc />
    public partial class MuscleToExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Muscle",
                table: "Exercises",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Muscle",
                table: "Exercises");
        }
    }
}
