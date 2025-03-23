using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    UF = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regioes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegioesCidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    RegiaoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CidadeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegioesCidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegioesCidades_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegioesCidades_Regioes_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regioes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("154898ed-502d-45dc-a4f8-9df8ef4c1617"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a275c55d-943c-4076-a4ea-d47b8f78cbcc"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("710091f0-4034-4466-82ef-4520c5de4ea5"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("70e8fd28-b348-4813-a75d-a40c39669c1b"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("79cd87c5-2afa-415e-a887-ebd1028e8044"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5032416f-cd59-4b7a-9990-b58fc98974aa"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("cc30bb37-1fa0-4e87-9ab3-e1d355e0890a"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("00c4c444-566e-46d7-9657-503ca9e644ba"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b26d2d0f-ca92-4268-9a60-1debb5c27c8e"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("79ce46eb-f672-45d9-a74c-fd7e8809dc4f"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a1e21a60-a9d8-4c0c-81c6-07d1fc5e3aed"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("16c989d3-c2f7-40e6-a53f-f2e05f846be6"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("494920ee-8556-49ed-add1-1216293eff3e"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("59681732-bb62-4f00-b708-c2999df215cb"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bf174dcc-e4d9-4620-8083-d82092db46b0"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("eebbb147-0799-4b90-8e9a-dab1e3fc46ee"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("eb193065-2b39-49b8-a3b7-36e6d1636bfb"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2191cf5c-e0c5-48cd-be34-269e21dce108"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a934ead5-d391-44ef-93ca-43a21576aa8a"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7769a238-fa32-4f1f-be3e-6e8caef15bf7"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("88636533-5f5c-4de5-aabe-c304ed04a234"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("93a70bdd-f7d0-412f-9936-b7fc0d7e16b4"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7b28c6ce-4836-4cd2-a995-4865768ca085"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d1fde670-4128-4236-81c8-a76cc832cc6b"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5d7b1b98-2270-49ae-8e42-8856930d8f36"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ccedd25c-bb16-49ec-a375-ba3ea305ecba"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("86971625-0c5c-42a6-8c00-cb5d9b52b1d6"), "Palmas", "TO" });

            migrationBuilder.CreateIndex(
                name: "IX_RegioesCidades_CidadeId",
                table: "RegioesCidades",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegioesCidades_RegiaoId_CidadeId",
                table: "RegioesCidades",
                columns: new[] { "RegiaoId", "CidadeId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegioesCidades");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Regioes");
        }
    }
}
