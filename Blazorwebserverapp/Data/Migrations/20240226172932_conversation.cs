using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazorwebserverapp.Migrations
{
    /// <inheritdoc />
    public partial class conversation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conversation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendToId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecievedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    BlockedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversation", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversation");
        }
    }
}
