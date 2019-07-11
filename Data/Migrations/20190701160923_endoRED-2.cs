using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class endoRED2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b08902ee-226c-41a9-9c6c-e1cdbf78849e", "AQAAAAEAACcQAAAAEBKn4jsN9auIIjbfhrDDWr2NW+QGX6H2C5a0EFJCGt1xe//FnxTFpbJcLkp8aD22tg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a7897f2-c3e7-440e-8a47-3d5929a75319", "AQAAAAEAACcQAAAAEFceXWUvDT8O/QhuGBqkgE2EziMKebE/NQFUgpjgAI/0IZGkOeRz+ZYaKqH36JIb+Q==" });
        }
    }
}
