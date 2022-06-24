using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace usuario.Migrations
{
    public partial class AtualizacaoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "db_usuario");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "db_usuario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "db_usuario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "db_usuario",
                newName: "data_nascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_db_usuario",
                table: "db_usuario",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_db_usuario",
                table: "db_usuario");

            migrationBuilder.RenameTable(
                name: "db_usuario",
                newName: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Usuarios",
                newName: "DataNascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");
        }
    }
}
