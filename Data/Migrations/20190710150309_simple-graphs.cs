using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class simplegraphs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ActionItem",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ActionItem",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4e7f8f9-1e65-4799-907d-1a057072848b", "AQAAAAEAACcQAAAAEPOTkl7XvUCdp+uhUtdJB82I7TpbUT5FnIYxk0FX3wQBOsS29gp0n4cCJQhJkrhWOQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ActionItem",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ActionItem",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8613aee-19a3-4136-a8fb-377afeb81faa", "AQAAAAEAACcQAAAAEBD/OJxYG86WIqFC3IyqVMPiz3qiGwro3xzpR8FiZE1onie0D/77J6/+7ptKAq3hcA==" });
        }
    }
}
