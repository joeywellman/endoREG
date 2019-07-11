using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class removecontraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3cab59d-c68d-42c8-a0ff-a87bd3856bbb", "AQAAAAEAACcQAAAAEIsVQ0yVOJ+ZL/opjJPQfq0UMhxCSU+Lp9Abxu1a2R6qbVh2ISTMAsSLvon7MLf0Rg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80025022-8245-4e47-b1ef-bd5f428bd0d0", "AQAAAAEAACcQAAAAEF4O2se4cD2Bd2Af16DFstjECJNy27u7Hr4KiQcXGomBvQzGTvawms90fMPw8zCjtA==" });
        }
    }
}
