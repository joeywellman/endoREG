using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace endoREG_MVC.Data.Migrations
{
    public partial class endoREGstart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CompliancePlan",
                columns: table => new
                {
                    CompliancePlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompliancePlan", x => x.CompliancePlanId);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibleParty",
                columns: table => new
                {
                    ResponsiblePartyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAssigned = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Inactive = table.Column<bool>(nullable: false),
                    NameOrGroup = table.Column<string>(maxLength: 55, nullable: false),
                    NameOrGroupNumber = table.Column<string>(maxLength: 20, nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibleParty", x => x.ResponsiblePartyId);
                    table.ForeignKey(
                        name: "FK_ResponsibleParty_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionItem",
                columns: table => new
                {
                    ActionItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAssigned = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Title = table.Column<string>(maxLength: 55, nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    DaysToComplete = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    ActionItemImage = table.Column<byte[]>(nullable: true),
                    Complete = table.Column<bool>(nullable: false),
                    CompliancePlanId = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionItem", x => x.ActionItemId);
                    table.ForeignKey(
                        name: "FK_ActionItem_CompliancePlan_CompliancePlanId",
                        column: x => x.CompliancePlanId,
                        principalTable: "CompliancePlan",
                        principalColumn: "CompliancePlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionItem_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Completion",
                columns: table => new
                {
                    CompletionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DateCompleted = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    ResponsiblePartyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Completion", x => x.CompletionId);
                    table.ForeignKey(
                        name: "FK_Completion_ResponsibleParty_ResponsiblePartyId",
                        column: x => x.ResponsiblePartyId,
                        principalTable: "ResponsibleParty",
                        principalColumn: "ResponsiblePartyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Completion_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompletionActionItem",
                columns: table => new
                {
                    CompletionActionItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompletionId = table.Column<int>(nullable: false),
                    ActionItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletionActionItem", x => x.CompletionActionItemId);
                    table.ForeignKey(
                        name: "FK_CompletionActionItem_ActionItem_ActionItemId",
                        column: x => x.ActionItemId,
                        principalTable: "ActionItem",
                        principalColumn: "ActionItemId");
                    table.ForeignKey(
                        name: "FK_CompletionActionItem_Completion_CompletionId",
                        column: x => x.CompletionId,
                        principalTable: "Completion",
                        principalColumn: "CompletionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "5a7897f2-c3e7-440e-8a47-3d5929a75319", "admin@admin.com", true, "Joe", "Wellman", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFceXWUvDT8O/QhuGBqkgE2EziMKebE/NQFUgpjgAI/0IZGkOeRz+ZYaKqH36JIb+Q==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", "123 NewForce Drive", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "CompliancePlan",
                columns: new[] { "CompliancePlanId", "Label" },
                values: new object[,]
                {
                    { 1, "29 CFR 1910 General Industry Compliance" },
                    { 2, "29 CFR Part 1926 Construction Compliance" },
                    { 3, "Responsible Care® Compliance Plan" },
                    { 4, "Human Resource (HR) Services Compliance Plan" },
                    { 5, "Health, Environmental, Safety, and Security (HES&S) Compliance Plan" },
                    { 6, "Industrial Hygiene Compliance Plan" },
                    { 7, "Risk Management Compliance Plan" },
                    { 8, "Workers Compensation Compliance Plan" },
                    { 9, "Quality Assurance / Control Compliance" },
                    { 10, "Employee Training Compliance Plan" }
                });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "Location", "Title", "UserId", "Weight", "isActive" },
                values: new object[] { 1, null, false, 1, 30, "Platforms higher than 4ft require protection from falls.", null, "General Industry Protection from Falls", "00000000-ffff-ffff-ffff-ffffffffffff", 5, false });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "Location", "Title", "UserId", "Weight", "isActive" },
                values: new object[] { 2, null, false, 2, 1, "Ladder extensions over levels (exceeding 6ft) require tie-off, 3ft above surface level.", null, "Construction Fall Protection", "00000000-ffff-ffff-ffff-ffffffffffff", 5, false });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "Location", "Title", "UserId", "Weight", "isActive" },
                values: new object[] { 3, null, false, 3, 90, "Fulfillment of ACC’s Responsible Care Third-Party Audit Requirement is a mandatory element of the ACC’s Responsible Care initiative.", null, "General", "00000000-ffff-ffff-ffff-ffffffffffff", 2, false });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "Location", "Title", "UserId", "Weight", "isActive" },
                values: new object[] { 4, null, false, 3, 45, "Employees have not been enrolled in sexual harassment training.", null, "Sexual Harassment Education Needed", "00000000-ffff-ffff-ffff-ffffffffffff", 1, false });

            migrationBuilder.InsertData(
                table: "ActionItem",
                columns: new[] { "ActionItemId", "ActionItemImage", "Complete", "CompliancePlanId", "DaysToComplete", "Description", "Location", "Title", "UserId", "Weight", "isActive" },
                values: new object[] { 5, null, false, 3, 32, "Forklift Drivers have not had operational or safety training in 5 years.  Operators are required to have training every 3 years.", null, "Forklift Operation", "00000000-ffff-ffff-ffff-ffffffffffff", 3, false });

            migrationBuilder.InsertData(
                table: "Completion",
                columns: new[] { "CompletionId", "DateCompleted", "ResponsiblePartyId", "UserId" },
                values: new object[] { 1, null, null, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "ResponsibleParty",
                columns: new[] { "ResponsiblePartyId", "Inactive", "NameOrGroup", "NameOrGroupNumber", "UserId" },
                values: new object[] { 1, false, "Safety Team", "001", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "ResponsibleParty",
                columns: new[] { "ResponsiblePartyId", "Inactive", "NameOrGroup", "NameOrGroupNumber", "UserId" },
                values: new object[] { 2, false, "HR Team", "002", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "CompletionActionItem",
                columns: new[] { "CompletionActionItemId", "ActionItemId", "CompletionId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "CompletionActionItem",
                columns: new[] { "CompletionActionItemId", "ActionItemId", "CompletionId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ActionItem_CompliancePlanId",
                table: "ActionItem",
                column: "CompliancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionItem_UserId",
                table: "ActionItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Completion_ResponsiblePartyId",
                table: "Completion",
                column: "ResponsiblePartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Completion_UserId",
                table: "Completion",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletionActionItem_ActionItemId",
                table: "CompletionActionItem",
                column: "ActionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletionActionItem_CompletionId",
                table: "CompletionActionItem",
                column: "CompletionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleParty_UserId",
                table: "ResponsibleParty",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletionActionItem");

            migrationBuilder.DropTable(
                name: "ActionItem");

            migrationBuilder.DropTable(
                name: "Completion");

            migrationBuilder.DropTable(
                name: "CompliancePlan");

            migrationBuilder.DropTable(
                name: "ResponsibleParty");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");
        }
    }
}
