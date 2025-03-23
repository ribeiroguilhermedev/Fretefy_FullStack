using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.Migrations
{
    public partial class NovaColunaAtivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Regioes",
                type: "INTEGER",
                nullable: false,
                defaultValue: true);

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c0acd71c-5d27-40f5-b3a9-704e7c9e3565"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2d8ef411-5ed5-4aae-ae83-c4fbb0928e6c"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f5338025-56c4-4c4f-9dd8-f7243cb78696"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b9ceecb5-7ec3-4ed0-994e-0dbb95ff6ba8"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a7173f44-a4d8-4dfa-8666-5dbea4213966"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6c0771cc-beb6-498e-b630-8c02c6dc55c1"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("969c7ae1-60f3-4fea-bad8-c02961aacdf9"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d875b6a3-32a8-42d9-bccd-8abed93f2c1a"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a53e1c83-9ab1-45e1-a5da-265942ba1ca1"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("03dda14c-72a9-4941-8d7d-14d96b552da6"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("61554955-f7a7-4e3b-b137-02d9d2e7f30f"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ee3e92cc-7525-439a-9870-1b1c13b18284"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0f3b32c0-fc8d-4fff-bb58-fb20749cafd0"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c18fd590-b313-42db-a5f8-8a2ccc3ca13e"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d89937f9-7238-47a3-b5d4-6abac292c98c"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("373b3db2-04e4-41ca-91be-df7bebf46a9b"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f0d527dd-133a-4ba7-a012-6e1b4a456b42"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bbc0871c-e19b-4d34-8bcf-8aaa79ff9422"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("029a46f5-b593-43cf-b034-5480e62e7354"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4c560de9-e875-4eec-9318-728c47e75575"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f198ee73-d9f2-44c0-88ae-3234c811ac74"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4d8176db-f26f-41e1-ad49-0c6ad3acd28a"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e0e6ccdc-04be-4c9d-9c56-b92fdddf00e3"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("584aabb9-f7c9-429c-b172-2f95fab04127"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("472e13aa-c574-4725-8c4e-5afae9da4c50"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("094d43de-0577-4628-b936-92f8bfd507b3"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("9439e854-f189-4448-a5e4-1fd14af13ddb"), "Palmas", "TO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("029a46f5-b593-43cf-b034-5480e62e7354"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03dda14c-72a9-4941-8d7d-14d96b552da6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("094d43de-0577-4628-b936-92f8bfd507b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0f3b32c0-fc8d-4fff-bb58-fb20749cafd0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2d8ef411-5ed5-4aae-ae83-c4fbb0928e6c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("373b3db2-04e4-41ca-91be-df7bebf46a9b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("472e13aa-c574-4725-8c4e-5afae9da4c50"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4c560de9-e875-4eec-9318-728c47e75575"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4d8176db-f26f-41e1-ad49-0c6ad3acd28a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("584aabb9-f7c9-429c-b172-2f95fab04127"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("61554955-f7a7-4e3b-b137-02d9d2e7f30f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6c0771cc-beb6-498e-b630-8c02c6dc55c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9439e854-f189-4448-a5e4-1fd14af13ddb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("969c7ae1-60f3-4fea-bad8-c02961aacdf9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a53e1c83-9ab1-45e1-a5da-265942ba1ca1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a7173f44-a4d8-4dfa-8666-5dbea4213966"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b9ceecb5-7ec3-4ed0-994e-0dbb95ff6ba8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bbc0871c-e19b-4d34-8bcf-8aaa79ff9422"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c0acd71c-5d27-40f5-b3a9-704e7c9e3565"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c18fd590-b313-42db-a5f8-8a2ccc3ca13e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d875b6a3-32a8-42d9-bccd-8abed93f2c1a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d89937f9-7238-47a3-b5d4-6abac292c98c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e0e6ccdc-04be-4c9d-9c56-b92fdddf00e3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ee3e92cc-7525-439a-9870-1b1c13b18284"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f0d527dd-133a-4ba7-a012-6e1b4a456b42"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f198ee73-d9f2-44c0-88ae-3234c811ac74"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f5338025-56c4-4c4f-9dd8-f7243cb78696"));

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Regioes");

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
    }
}
