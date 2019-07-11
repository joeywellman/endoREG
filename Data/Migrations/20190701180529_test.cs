using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8f3e2f7-3861-4b10-acf7-a1d827b9eeaa", "AQAAAAEAACcQAAAAEICIVderPjGxx30vUcO0Jkudqm4gAHAQ2Z6ny/NZgsXz6MtTm1D46Sg6ozVO/SbjQQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30abb4c5-4f58-4a8e-9df0-22a0539b8ee4", "AQAAAAEAACcQAAAAENRONdOiPHsPjKL5CdQ9lId5aac/UrXFrfPeQm0sB0Lnu72V3zZclYKYjNUY+02QEA==" });
        }
    }
}
