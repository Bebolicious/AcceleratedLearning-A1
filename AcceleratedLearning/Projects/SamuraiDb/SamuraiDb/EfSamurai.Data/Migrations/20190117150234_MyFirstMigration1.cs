using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class MyFirstMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes");

            migrationBuilder.AddColumn<int>(
                name: "SeccretIdentityId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SamuraiId",
                table: "Quotes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SeccretIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SecretIdentities = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeccretIdentities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_SeccretIdentityId",
                table: "Samurais",
                column: "SeccretIdentityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_SeccretIdentities_SeccretIdentityId",
                table: "Samurais",
                column: "SeccretIdentityId",
                principalTable: "SeccretIdentities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_SeccretIdentities_SeccretIdentityId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "SeccretIdentities");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_SeccretIdentityId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "SeccretIdentityId",
                table: "Samurais");

            migrationBuilder.AlterColumn<int>(
                name: "SamuraiId",
                table: "Quotes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
