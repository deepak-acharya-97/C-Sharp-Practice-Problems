using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleKeepAssignment.Migrations.Notes
{
    public partial class singlepk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    PlainText = table.Column<string>(nullable: true),
                    PinStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "CheckList",
                columns: table => new
                {
                    CheckListData = table.Column<string>(nullable: true),
                    CheckListStatus = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    NotesTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList", x => x.Title);
                    table.ForeignKey(
                        name: "FK_CheckList_Note_NotesTitle",
                        column: x => x.NotesTitle,
                        principalTable: "Note",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    LabelString = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    NotesTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Title);
                    table.ForeignKey(
                        name: "FK_Label_Note_NotesTitle",
                        column: x => x.NotesTitle,
                        principalTable: "Note",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckList_NotesTitle",
                table: "CheckList",
                column: "NotesTitle");

            migrationBuilder.CreateIndex(
                name: "IX_Label_NotesTitle",
                table: "Label",
                column: "NotesTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckList");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Note");
        }
    }
}
