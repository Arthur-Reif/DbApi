using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbApi.Migrations
{
    /// <inheritdoc />
    public partial class updateTypesFluentValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Tb-clienetes");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Tb-clienetes",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Tb-clienetes",
                newName: "endCli");

            migrationBuilder.RenameColumn(
                name: "codigoCli",
                table: "Tb-clienetes",
                newName: "CodiCLi");

            migrationBuilder.AlterColumn<string>(
                name: "endCli",
                table: "Tb-clienetes",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CodiCLi",
                table: "Tb-clienetes",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb-clienetes",
                table: "Tb-clienetes",
                column: "CodiCLi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb-clienetes",
                table: "Tb-clienetes");

            migrationBuilder.RenameTable(
                name: "Tb-clienetes",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Clientes",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "endCli",
                table: "Clientes",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "CodiCLi",
                table: "Clientes",
                newName: "codigoCli");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "codigoCli",
                table: "Clientes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "codigoCli");
        }
    }
}
