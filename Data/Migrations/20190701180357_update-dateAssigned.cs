using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class updatedateAssigned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30abb4c5-4f58-4a8e-9df0-22a0539b8ee4", "AQAAAAEAACcQAAAAENRONdOiPHsPjKL5CdQ9lId5aac/UrXFrfPeQm0sB0Lnu72V3zZclYKYjNUY+02QEA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b08902ee-226c-41a9-9c6c-e1cdbf78849e", "AQAAAAEAACcQAAAAEBKn4jsN9auIIjbfhrDDWr2NW+QGX6H2C5a0EFJCGt1xe//FnxTFpbJcLkp8aD22tg==" });
        }
    }
}
