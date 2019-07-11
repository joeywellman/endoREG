using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class removeimagefromedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8613aee-19a3-4136-a8fb-377afeb81faa", "AQAAAAEAACcQAAAAEBD/OJxYG86WIqFC3IyqVMPiz3qiGwro3xzpR8FiZE1onie0D/77J6/+7ptKAq3hcA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cab47157-9088-4dce-862e-fe65273ec733", "AQAAAAEAACcQAAAAEHP6oVsJxgrDlIQ4hIDmdev66OSnWb0DH6YFXFOHTzs2zvUxuVCEiiqkrXOWBLHtfA==" });
        }
    }
}
