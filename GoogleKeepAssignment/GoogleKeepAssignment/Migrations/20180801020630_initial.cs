using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleKeepAssignment.Migrations
{
    public partial class initial : Migration
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
                    CheckListData = table.Column<string>(nullable: false),
                    CheckListStatus = table.Column<bool>(nullable: false),
                    NoteTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList", x => x.CheckListData);
                    table.ForeignKey(
                        name: "FK_CheckList_Note_NoteTitle",
                        column: x => x.NoteTitle,
                        principalTable: "Note",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    LabelString = table.Column<string>(nullable: false),
                    NoteTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.LabelString);
                    table.ForeignKey(
                        name: "FK_Label_Note_NoteTitle",
                        column: x => x.NoteTitle,
                        principalTable: "Note",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckList_NoteTitle",
                table: "CheckList",
                column: "NoteTitle");

            migrationBuilder.CreateIndex(
                name: "IX_Label_NoteTitle",
                table: "Label",
                column: "NoteTitle");
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
