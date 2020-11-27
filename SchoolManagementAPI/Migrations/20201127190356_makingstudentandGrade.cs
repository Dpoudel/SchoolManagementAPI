using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementAPI.Migrations
{
    public partial class makingstudentandGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "teacher",
                newName: "teacherid");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Grade",
                newName: "Gradeid");

            migrationBuilder.AddColumn<int>(
                name: "Gradeid",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Gradeid",
                table: "Students",
                column: "Gradeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grade_Gradeid",
                table: "Students",
                column: "Gradeid",
                principalTable: "Grade",
                principalColumn: "Gradeid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grade_Gradeid",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Gradeid",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Gradeid",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameColumn(
                name: "teacherid",
                table: "teacher",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Gradeid",
                table: "Grade",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");
        }
    }
}
