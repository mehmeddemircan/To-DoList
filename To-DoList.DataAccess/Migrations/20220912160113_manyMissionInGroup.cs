using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_DoList.DataAccess.Migrations
{
    public partial class manyMissionInGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissionId",
                table: "Groups");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_GroupId",
                table: "Missions",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Groups_GroupId",
                table: "Missions",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Groups_GroupId",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_GroupId",
                table: "Missions");

            migrationBuilder.AddColumn<int>(
                name: "MissionId",
                table: "Groups",
                type: "integer",
                nullable: true);
        }
    }
}
