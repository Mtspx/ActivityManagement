using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivityManagement.Migrations
{
    public partial class SecondVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResponsavelGeral",
                table: "Obra",
                newName: "IdentificacaoDoProjeto");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Obra",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Progresso",
                table: "Obra",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Progresso",
                table: "Obra");

            migrationBuilder.RenameColumn(
                name: "IdentificacaoDoProjeto",
                table: "Obra",
                newName: "ResponsavelGeral");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Obra",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
