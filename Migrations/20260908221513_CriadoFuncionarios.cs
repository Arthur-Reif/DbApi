using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbApi.Migrations
{
    /// <inheritdoc />
    public partial class CriadoFuncionarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "telefoneCli",
                table: "Tb_clientes",
                type: "varchar(11)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "endCli",
                table: "Tb_clientes",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.CreateTable(
                name: "Tb_funcionario",
                columns: table => new
                {
                    idFuncionario = table.Column<string>(type: "varchar(200)", nullable: false),
                    nomeFuncionario = table.Column<string>(type: "varchar(200)", maxLength: 150, nullable: false),
                    enderecoFuncionario = table.Column<string>(type: "varchar(200)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_funcionario", x => x.idFuncionario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_funcionario");

            migrationBuilder.AlterColumn<string>(
                name: "telefoneCli",
                table: "Tb_clientes",
                type: "varchar(11)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "endCli",
                table: "Tb_clientes",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);
        }
    }
}
