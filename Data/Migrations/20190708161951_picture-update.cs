using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class pictureupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16eac706-a125-44f5-a515-409b7d481ed2", "AQAAAAEAACcQAAAAEOiJeUwOhV5czTwpy5uN9oam18d0VsaYxz6IvF3MUAH0RCRZ736hG/1JGGBpz8U7PA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8f3e2f7-3861-4b10-acf7-a1d827b9eeaa", "AQAAAAEAACcQAAAAEICIVderPjGxx30vUcO0Jkudqm4gAHAQ2Z6ny/NZgsXz6MtTm1D46Sg6ozVO/SbjQQ==" });
        }
    }
}
