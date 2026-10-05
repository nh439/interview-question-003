using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace example.com.database.Migrations.Sqlite
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Approvals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsPending = table.Column<bool>(type: "INTEGER", nullable: false),
                    ApproveStatus = table.Column<string>(type: "TEXT", nullable: false),
                    ApproveDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ApproveBy = table.Column<string>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: false),
                    ApproveReason = table.Column<string>(type: "TEXT", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RequestBy = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvals", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_ApproveDate_IsPending_ApproveStatus",
                table: "Approvals",
                columns: new[] { "ApproveDate", "IsPending", "ApproveStatus" });

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_Name",
                table: "Approvals",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Approvals");
        }
    }
}
