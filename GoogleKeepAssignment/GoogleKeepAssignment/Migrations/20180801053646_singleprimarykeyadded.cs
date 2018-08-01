using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleKeepAssignment.Migrations
{
    public partial class singleprimarykeyadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckList_Note_Title",
                table: "CheckList");

            migrationBuilder.DropForeignKey(
                name: "FK_Label_Note_Title",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckList",
                table: "CheckList");

            migrationBuilder.AlterColumn<string>(
                name: "LabelString",
                table: "Label",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "NoteTitle",
                table: "Label",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CheckListData",
                table: "CheckList",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "NoteTitle",
                table: "CheckList",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Label",
                table: "Label",
                column: "Title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckList",
                table: "CheckList",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Label_NoteTitle",
                table: "Label",
                column: "NoteTitle");

            migrationBuilder.CreateIndex(
                name: "IX_CheckList_NoteTitle",
                table: "CheckList",
                column: "NoteTitle");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckList_Note_NoteTitle",
                table: "CheckList");

            migrationBuilder.DropForeignKey(
                name: "FK_Label_Note_NoteTitle",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label",
                table: "Label");

            migrationBuilder.DropIndex(
                name: "IX_Label_NoteTitle",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckList",
                table: "CheckList");

            migrationBuilder.DropIndex(
                name: "IX_CheckList_NoteTitle",
                table: "CheckList");

            migrationBuilder.DropColumn(
                name: "NoteTitle",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "NoteTitle",
                table: "CheckList");

            migrationBuilder.AlterColumn<string>(
                name: "LabelString",
                table: "Label",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CheckListData",
                table: "CheckList",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Label",
                table: "Label",
                columns: new[] { "Title", "LabelString" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckList",
                table: "CheckList",
                columns: new[] { "Title", "CheckListData", "CheckListStatus" });

            migrationBuilder.AddForeignKey(
                name: "FK_CheckList_Note_Title",
                table: "CheckList",
                column: "Title",
                principalTable: "Note",
                principalColumn: "Title",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Label_Note_Title",
                table: "Label",
                column: "Title",
                principalTable: "Note",
                principalColumn: "Title",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
