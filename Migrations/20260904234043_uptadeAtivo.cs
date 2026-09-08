using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbApi.Migrations
{
    /// <inheritdoc />
    public partial class uptadeAtivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb-clienetes",
                table: "Tb-clienetes");

            migrationBuilder.RenameTable(
                name: "Tb-clienetes",
                newName: "Tb_clientes");

            migrationBuilder.RenameColumn(
                name: "Datanascimento",
                table: "Tb_clientes",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "CodiCLi",
                table: "Tb_clientes",
                newName: "codCli");

            migrationBuilder.AddColumn<bool>(
                name: "AtivoCli",
                table: "Tb_clientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_clientes",
                table: "Tb_clientes",
                column: "codCli");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_clientes",
                table: "Tb_clientes");

            migrationBuilder.DropColumn(
                name: "AtivoCli",
                table: "Tb_clientes");

            migrationBuilder.RenameTable(
                name: "Tb_clientes",
                newName: "Tb-clienetes");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Tb-clienetes",
                newName: "Datanascimento");

            migrationBuilder.RenameColumn(
                name: "codCli",
                table: "Tb-clienetes",
                newName: "CodiCLi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb-clienetes",
                table: "Tb-clienetes",
                column: "CodiCLi");
        }
    }
}
