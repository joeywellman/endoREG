using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class aiupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "ActionItem",
                newName: "IsActive");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1a50c31-1f95-4cfa-ba18-012d16bba47d", "AQAAAAEAACcQAAAAEEDWezWhAhcsQUw9g8XDg1KGmwPSvgqiH5cvdjkoocnw2o6AwAeFT04bYjWuTIfbaQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ActionItem",
                newName: "isActive");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3cab59d-c68d-42c8-a0ff-a87bd3856bbb", "AQAAAAEAACcQAAAAEIsVQ0yVOJ+ZL/opjJPQfq0UMhxCSU+Lp9Abxu1a2R6qbVh2ISTMAsSLvon7MLf0Rg==" });
        }
    }
}
