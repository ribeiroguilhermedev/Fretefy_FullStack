using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.Migrations
{
    public partial class NovaColunaAtualizadoEm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("00c4c444-566e-46d7-9657-503ca9e644ba"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("154898ed-502d-45dc-a4f8-9df8ef4c1617"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("16c989d3-c2f7-40e6-a53f-f2e05f846be6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2191cf5c-e0c5-48cd-be34-269e21dce108"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("494920ee-8556-49ed-add1-1216293eff3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5032416f-cd59-4b7a-9990-b58fc98974aa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("59681732-bb62-4f00-b708-c2999df215cb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d7b1b98-2270-49ae-8e42-8856930d8f36"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("70e8fd28-b348-4813-a75d-a40c39669c1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("710091f0-4034-4466-82ef-4520c5de4ea5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7769a238-fa32-4f1f-be3e-6e8caef15bf7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("79cd87c5-2afa-415e-a887-ebd1028e8044"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("79ce46eb-f672-45d9-a74c-fd7e8809dc4f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7b28c6ce-4836-4cd2-a995-4865768ca085"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("86971625-0c5c-42a6-8c00-cb5d9b52b1d6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("88636533-5f5c-4de5-aabe-c304ed04a234"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("93a70bdd-f7d0-412f-9936-b7fc0d7e16b4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a1e21a60-a9d8-4c0c-81c6-07d1fc5e3aed"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a275c55d-943c-4076-a4ea-d47b8f78cbcc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a934ead5-d391-44ef-93ca-43a21576aa8a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b26d2d0f-ca92-4268-9a60-1debb5c27c8e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bf174dcc-e4d9-4620-8083-d82092db46b0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cc30bb37-1fa0-4e87-9ab3-e1d355e0890a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ccedd25c-bb16-49ec-a375-ba3ea305ecba"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d1fde670-4128-4236-81c8-a76cc832cc6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eb193065-2b39-49b8-a3b7-36e6d1636bfb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eebbb147-0799-4b90-8e9a-dab1e3fc46ee"));

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "Regioes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("42fee3bf-7d01-4062-8c57-6585454396d0"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f0e4b635-2424-4fd6-9b43-e593ba61f440"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c9123d80-e639-4009-b51a-e5d0cbb365b8"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("92c41d23-2fa4-42cf-af80-f757934fce75"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a1ee9204-b06e-491e-972e-5da7450e5ebc"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("03d493a3-9b9e-48a0-a6e2-94e0b9f5d145"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b958cf6a-a9b0-450e-beda-5aa396f96408"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1c40f250-1f4c-48b1-96ab-15061f90a677"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e2a84540-e1cb-4db1-b1b8-dfd605ee9a55"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3162a98f-8827-4ef6-800e-aa9367c00077"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fa352c7d-1494-4f09-89a5-76ee889340f1"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("321beaf0-edac-4bfa-9d0a-6719c3061b3d"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6adebc8c-6d91-44b9-b40d-2078161bcff6"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f8cce967-cc7f-4781-b4ae-98ee26092369"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("47c1c112-9ae9-4efb-8f76-64a67f3037e4"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("cbd0f651-1cd2-4d60-a1b3-60a58efa99b2"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6a4961ff-f2c9-41b4-b379-2c245fd2ffd4"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0b60ba8c-668a-45a2-9733-19b40debdb99"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ce61669e-b861-4cd0-9f88-c7e26b41f860"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7b9c5289-f656-4676-a330-4061d979f31d"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4b763f4f-5ace-47fa-9960-083e444e01f5"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bb9bd1a2-d963-4fc0-a3de-9a7b57071b55"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ddd9f8d8-d9d8-4bb7-a74c-312371cfa412"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6ae1f85d-f688-4aab-81d1-27480e295c00"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7549e812-5f3f-4ea2-ad66-6ce59ce00697"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b571ead9-aab1-4c03-b1b8-7ac4cb0882ba"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4044f053-a502-45bc-a318-650f40c3d9d2"), "Palmas", "TO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03d493a3-9b9e-48a0-a6e2-94e0b9f5d145"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0b60ba8c-668a-45a2-9733-19b40debdb99"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1c40f250-1f4c-48b1-96ab-15061f90a677"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3162a98f-8827-4ef6-800e-aa9367c00077"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("321beaf0-edac-4bfa-9d0a-6719c3061b3d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4044f053-a502-45bc-a318-650f40c3d9d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("42fee3bf-7d01-4062-8c57-6585454396d0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("47c1c112-9ae9-4efb-8f76-64a67f3037e4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4b763f4f-5ace-47fa-9960-083e444e01f5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6a4961ff-f2c9-41b4-b379-2c245fd2ffd4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6adebc8c-6d91-44b9-b40d-2078161bcff6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ae1f85d-f688-4aab-81d1-27480e295c00"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7549e812-5f3f-4ea2-ad66-6ce59ce00697"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7b9c5289-f656-4676-a330-4061d979f31d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92c41d23-2fa4-42cf-af80-f757934fce75"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a1ee9204-b06e-491e-972e-5da7450e5ebc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b571ead9-aab1-4c03-b1b8-7ac4cb0882ba"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b958cf6a-a9b0-450e-beda-5aa396f96408"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb9bd1a2-d963-4fc0-a3de-9a7b57071b55"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c9123d80-e639-4009-b51a-e5d0cbb365b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cbd0f651-1cd2-4d60-a1b3-60a58efa99b2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce61669e-b861-4cd0-9f88-c7e26b41f860"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ddd9f8d8-d9d8-4bb7-a74c-312371cfa412"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e2a84540-e1cb-4db1-b1b8-dfd605ee9a55"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f0e4b635-2424-4fd6-9b43-e593ba61f440"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f8cce967-cc7f-4781-b4ae-98ee26092369"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fa352c7d-1494-4f09-89a5-76ee889340f1"));

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "Regioes");

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
        }
    }
}
