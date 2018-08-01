using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleKeepAssignment.Migrations.Notes
{
    public partial class compositekey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckList_Note_NotesTitle",
                table: "CheckList");

            migrationBuilder.DropForeignKey(
                name: "FK_Label_Note_NotesTitle",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label",
                table: "Label");

            migrationBuilder.DropIndex(
                name: "IX_Label_NotesTitle",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckList",
                table: "CheckList");

            migrationBuilder.DropIndex(
                name: "IX_CheckList_NotesTitle",
                table: "CheckList");

            migrationBuilder.DropColumn(
                name: "NotesTitle",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "NotesTitle",
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
                columns: new[] { "Title", "CheckListData" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "NotesTitle",
                table: "Label",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CheckListData",
                table: "CheckList",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "NotesTitle",
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
                name: "IX_Label_NotesTitle",
                table: "Label",
                column: "NotesTitle");

            migrationBuilder.CreateIndex(
                name: "IX_CheckList_NotesTitle",
                table: "CheckList",
                column: "NotesTitle");

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
    }
}
