using Microsoft.EntityFrameworkCore.Migrations;

namespace UpgradeEntityFramework.Migrations
{
    public partial class AddPartner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "MemberUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartnerEmail",
                table: "EventSignups",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_MemberUsers_NormalizedEmail",
                table: "MemberUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_EventSignups_PartnerEmail",
                table: "EventSignups",
                column: "PartnerEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSignups_MemberUsers_PartnerEmail",
                table: "EventSignups",
                column: "PartnerEmail",
                principalTable: "MemberUsers",
                principalColumn: "NormalizedEmail",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSignups_MemberUsers_PartnerEmail",
                table: "EventSignups");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_MemberUsers_NormalizedEmail",
                table: "MemberUsers");

            migrationBuilder.DropIndex(
                name: "IX_EventSignups_PartnerEmail",
                table: "EventSignups");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "MemberUsers");

            migrationBuilder.DropColumn(
                name: "PartnerEmail",
                table: "EventSignups");
        }
    }
}
