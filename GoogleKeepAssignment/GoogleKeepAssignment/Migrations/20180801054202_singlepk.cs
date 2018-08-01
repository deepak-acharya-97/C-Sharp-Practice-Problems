using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleKeepAssignment.Migrations
{
    public partial class singlepk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckList_Note_NoteTitle",
                table: "CheckList");

            migrationBuilder.DropForeignKey(
                name: "FK_Label_Note_NoteTitle",
                table: "Label");

            migrationBuilder.RenameColumn(
                name: "NoteTitle",
                table: "Label",
                newName: "NotesTitle");

            migrationBuilder.RenameIndex(
                name: "IX_Label_NoteTitle",
                table: "Label",
                newName: "IX_Label_NotesTitle");

            migrationBuilder.RenameColumn(
                name: "NoteTitle",
                table: "CheckList",
                newName: "NotesTitle");

            migrationBuilder.RenameIndex(
                name: "IX_CheckList_NoteTitle",
                table: "CheckList",
                newName: "IX_CheckList_NotesTitle");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckList_Note_NotesTitle",
                table: "CheckList",
                column: "NotesTitle",
                principalTable: "Note",
                principalColumn: "Title",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Label_Note_NotesTitle",
                table: "Label",
                column: "NotesTitle",
                principalTable: "Note",
                principalColumn: "Title",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckList_Note_NotesTitle",
                table: "CheckList");

            migrationBuilder.DropForeignKey(
                name: "FK_Label_Note_NotesTitle",
                table: "Label");

            migrationBuilder.RenameColumn(
                name: "NotesTitle",
                table: "Label",
                newName: "NoteTitle");

            migrationBuilder.RenameIndex(
                name: "IX_Label_NotesTitle",
                table: "Label",
                newName: "IX_Label_NoteTitle");

            migrationBuilder.RenameColumn(
                name: "NotesTitle",
                table: "CheckList",
                newName: "NoteTitle");

            migrationBuilder.RenameIndex(
                name: "IX_CheckList_NotesTitle",
                table: "CheckList",
                newName: "IX_CheckList_NoteTitle");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckList_Note_NoteTitle",
                table: "CheckList",
                column: "NoteTitle",
                principalTable: "Note",
                principalColumn: "Title",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Label_Note_NoteTitle",
                table: "Label",
                column: "NoteTitle",
                principalTable: "Note",
                principalColumn: "Title",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
