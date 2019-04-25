using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace skillet.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Households",
                columns: table => new
                {
                    HouseholdId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HouseName = table.Column<string>(nullable: true),
                    HouseStreet = table.Column<string>(nullable: true),
                    HouseCity = table.Column<string>(nullable: true),
                    HouseState = table.Column<string>(nullable: true),
                    HouseZip = table.Column<int>(nullable: false),
                    HeadUserId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Households", x => x.HouseholdId);
                    table.ForeignKey(
                        name: "FK_Households_Users_HeadUserId",
                        column: x => x.HeadUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_HouseholdId",
                table: "Users",
                column: "HouseholdId");

            migrationBuilder.CreateIndex(
                name: "IX_Households_HeadUserId",
                table: "Households",
                column: "HeadUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Households_HouseholdId",
                table: "Users",
                column: "HouseholdId",
                principalTable: "Households",
                principalColumn: "HouseholdId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Households_HouseholdId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Households");

            migrationBuilder.DropIndex(
                name: "IX_Users_HouseholdId",
                table: "Users");
        }
    }
}
