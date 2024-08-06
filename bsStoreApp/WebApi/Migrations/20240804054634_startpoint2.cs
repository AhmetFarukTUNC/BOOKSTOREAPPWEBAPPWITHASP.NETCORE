using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class startpoint2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bff39a6-74bd-4b19-9302-0a55d1a1dafd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ade1ec-e72a-4525-8a9a-7dff68c22164");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0272947-dec4-4698-aa25-0b83b69238a0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54162f29-6d75-4357-950f-53fd2739b147", "23b976bc-17bd-4b87-b896-3d03338d3563", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4a3f7b7-6464-43ea-b0ab-213c9184bd27", "78a9bd95-43bf-470a-84db-93c0a5ff7e5d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca6dde87-7944-45d6-b0ee-ab64ba0c5664", "7b585b35-f779-47c1-a7e0-ad49eba9eed9", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54162f29-6d75-4357-950f-53fd2739b147");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4a3f7b7-6464-43ea-b0ab-213c9184bd27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca6dde87-7944-45d6-b0ee-ab64ba0c5664");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1bff39a6-74bd-4b19-9302-0a55d1a1dafd", "206c065b-a1da-487f-ad55-3c5126f05c8f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7ade1ec-e72a-4525-8a9a-7dff68c22164", "6f6eda3f-0e85-483f-ad26-48a560bca18f", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0272947-dec4-4698-aa25-0b83b69238a0", "135283df-7285-4c9c-9f4e-686d61847b8d", "Admin", "ADMIN" });
        }
    }
}
