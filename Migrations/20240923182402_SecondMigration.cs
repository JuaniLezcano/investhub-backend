using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace investhub_backend.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accion_Portafolio_PortafolioId",
                table: "Accion");

            migrationBuilder.DropForeignKey(
                name: "FK_Ahorro_Portafolio_PortafolioId",
                table: "Ahorro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Email_EmailId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Portafolio_PortafolioId",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portafolio",
                table: "Portafolio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_EmailId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_PortafolioId",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accion",
                table: "Accion");

            migrationBuilder.DropColumn(
                name: "PrecioActual",
                table: "Accion");

            migrationBuilder.RenameTable(
                name: "Accion",
                newName: "Accione");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Portafolio",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Email",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ahorro",
                newName: "AhorroId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Accione",
                newName: "AccionId");

            migrationBuilder.RenameIndex(
                name: "IX_Accion_PortafolioId",
                table: "Accione",
                newName: "IX_Accione_PortafolioId");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Portafolio",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "PortafolioId",
                table: "Portafolio",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Email",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Email",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portafolio",
                table: "Portafolio",
                column: "PortafolioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "EmailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accione",
                table: "Accione",
                column: "AccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Portafolio_ClienteId",
                table: "Portafolio",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Email_ClienteId",
                table: "Email",
                column: "ClienteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accione_Portafolio_PortafolioId",
                table: "Accione",
                column: "PortafolioId",
                principalTable: "Portafolio",
                principalColumn: "PortafolioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ahorro_Portafolio_PortafolioId",
                table: "Ahorro",
                column: "PortafolioId",
                principalTable: "Portafolio",
                principalColumn: "PortafolioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Cliente_ClienteId",
                table: "Email",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portafolio_Cliente_ClienteId",
                table: "Portafolio",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accione_Portafolio_PortafolioId",
                table: "Accione");

            migrationBuilder.DropForeignKey(
                name: "FK_Ahorro_Portafolio_PortafolioId",
                table: "Ahorro");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_Cliente_ClienteId",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_Portafolio_Cliente_ClienteId",
                table: "Portafolio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portafolio",
                table: "Portafolio");

            migrationBuilder.DropIndex(
                name: "IX_Portafolio_ClienteId",
                table: "Portafolio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.DropIndex(
                name: "IX_Email_ClienteId",
                table: "Email");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accione",
                table: "Accione");

            migrationBuilder.DropColumn(
                name: "PortafolioId",
                table: "Portafolio");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Email");

            migrationBuilder.RenameTable(
                name: "Accione",
                newName: "Accion");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Portafolio",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Email",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AhorroId",
                table: "Ahorro",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AccionId",
                table: "Accion",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Accione_PortafolioId",
                table: "Accion",
                newName: "IX_Accion_PortafolioId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Portafolio",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Email",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<float>(
                name: "PrecioActual",
                table: "Accion",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portafolio",
                table: "Portafolio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accion",
                table: "Accion",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EmailId",
                table: "Cliente",
                column: "EmailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PortafolioId",
                table: "Cliente",
                column: "PortafolioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accion_Portafolio_PortafolioId",
                table: "Accion",
                column: "PortafolioId",
                principalTable: "Portafolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ahorro_Portafolio_PortafolioId",
                table: "Ahorro",
                column: "PortafolioId",
                principalTable: "Portafolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Email_EmailId",
                table: "Cliente",
                column: "EmailId",
                principalTable: "Email",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Portafolio_PortafolioId",
                table: "Cliente",
                column: "PortafolioId",
                principalTable: "Portafolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
