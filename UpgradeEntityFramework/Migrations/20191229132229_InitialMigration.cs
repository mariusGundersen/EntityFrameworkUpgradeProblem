using Microsoft.EntityFrameworkCore.Migrations;

namespace UpgradeEntityFramework.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventSignups",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSignups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventSignups_MemberUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "MemberUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventSignups_UserId",
                table: "EventSignups",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventSignups");

            migrationBuilder.DropTable(
                name: "MemberUsers");
        }
    }
}
