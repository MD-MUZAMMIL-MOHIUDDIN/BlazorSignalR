using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazorwebserverapp.Migrations
{
    /// <inheritdoc />
    public partial class groupmessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "GroupMember",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "GroupMessage",
                columns: table => new
                {
                    GroupMessageId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FromId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMessage", x => x.GroupMessageId);
                    table.ForeignKey(
                        name: "FK_GroupMessage_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupMessageTrack",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupMessageId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RecievedUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecievedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMessageDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMessageTrack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupMessageTrack_GroupMessage_GroupMessageId",
                        column: x => x.GroupMessageId,
                        principalTable: "GroupMessage",
                        principalColumn: "GroupMessageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_UserId",
                table: "GroupMember",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMessage_GroupId",
                table: "GroupMessage",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMessageTrack_GroupMessageId",
                table: "GroupMessageTrack",
                column: "GroupMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMember_AspNetUsers_UserId",
                table: "GroupMember",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupMember_AspNetUsers_UserId",
                table: "GroupMember");

            migrationBuilder.DropTable(
                name: "GroupMessageTrack");

            migrationBuilder.DropTable(
                name: "GroupMessage");

            migrationBuilder.DropIndex(
                name: "IX_GroupMember_UserId",
                table: "GroupMember");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "GroupMember",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
