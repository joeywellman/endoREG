using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class newaicontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActionItem",
                keyColumn: "ActionItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActionItem",
                keyColumn: "ActionItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ActionItem",
                keyColumn: "ActionItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CompletionActionItem",
                keyColumn: "CompletionActionItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompletionActionItem",
                keyColumn: "CompletionActionItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActionItem",
                keyColumn: "ActionItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActionItem",
                keyColumn: "ActionItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Completion",
                keyColumn: "CompletionId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cab47157-9088-4dce-862e-fe65273ec733", "AQAAAAEAACcQAAAAEHP6oVsJxgrDlIQ4hIDmdev66OSnWb0DH6YFXFOHTzs2zvUxuVCEiiqkrXOWBLHtfA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "IsActive", "Location", "Title", "UserId", "Weight" },
                values: new object[] { 1, null, false, 1, 30, "Platforms higher than 4ft require protection from falls.", false, null, "General Industry Protection from Falls", "00000000-ffff-ffff-ffff-ffffffffffff", 5 });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "IsActive", "Location", "Title", "UserId", "Weight" },
                values: new object[] { 2, null, false, 2, 1, "Ladder extensions over levels (exceeding 6ft) require tie-off, 3ft above surface level.", false, null, "Construction Fall Protection", "00000000-ffff-ffff-ffff-ffffffffffff", 5 });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "IsActive", "Location", "Title", "UserId", "Weight" },
                values: new object[] { 3, null, false, 3, 90, "Fulfillment of ACC’s Responsible Care Third-Party Audit Requirement is a mandatory element of the ACC’s Responsible Care initiative.", false, null, "General", "00000000-ffff-ffff-ffff-ffffffffffff", 2 });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "IsActive", "Location", "Title", "UserId", "Weight" },
                values: new object[] { 4, null, false, 3, 45, "Employees have not been enrolled in sexual harassment training.", false, null, "Sexual Harassment Education Needed", "00000000-ffff-ffff-ffff-ffffffffffff", 1 });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "IsActive", "Location", "Title", "UserId", "Weight" },
                values: new object[] { 5, null, false, 3, 32, "Forklift Drivers have not had operational or safety training in 5 years.  Operators are required to have training every 3 years.", false, null, "Forklift Operation", "00000000-ffff-ffff-ffff-ffffffffffff", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1a50c31-1f95-4cfa-ba18-012d16bba47d", "AQAAAAEAACcQAAAAEEDWezWhAhcsQUw9g8XDg1KGmwPSvgqiH5cvdjkoocnw2o6AwAeFT04bYjWuTIfbaQ==" });

            migrationBuilder.InsertData(
                table: "Completion",
                columns: new[] { "CompletionId", "DateCompleted", "ResponsiblePartyId", "UserId" },
                values: new object[] { 1, null, null, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "CompletionActionItem",
                columns: new[] { "CompletionActionItemId", "ActionItemId", "CompletionId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "CompletionActionItem",
                columns: new[] { "CompletionActionItemId", "ActionItemId", "CompletionId" },
                values: new object[] { 2, 2, 1 });
        }
    }
}
