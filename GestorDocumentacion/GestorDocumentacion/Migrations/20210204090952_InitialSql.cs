using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestorDocumentacion.Migrations
{
    public partial class InitialSql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    SavedRoute = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    PageID = table.Column<Guid>(nullable: false),
                    Route = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastRequested = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.PageID);
                });

            migrationBuilder.CreateTable(
                name: "Template",
                columns: table => new
                {
                    TemplateID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.TemplateID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_Name",
                table: "Document",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Page_Route",
                table: "Page",
                column: "Route",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Template_Name",
                table: "Template",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "Template");
        }
    }
}
