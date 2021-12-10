using Microsoft.EntityFrameworkCore.Migrations;

namespace App_Turnos.Data.Migrations
{
    public partial class actionscript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Profesionales",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Profesionales");
        }
    }
}
