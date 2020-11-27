using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementAPI.Migrations
{
    public partial class addall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_teacher_teacherid1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_teacherid1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "teacherid1",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentsId",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentsTeachers",
                columns: table => new
                {
                    studentsId = table.Column<int>(type: "int", nullable: false),
                    teachersteacherid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsTeachers", x => new { x.studentsId, x.teachersteacherid });
                    table.ForeignKey(
                        name: "FK_StudentsTeachers_Students_studentsId",
                        column: x => x.studentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsTeachers_teacher_teachersteacherid",
                        column: x => x.teachersteacherid,
                        principalTable: "teacher",
                        principalColumn: "teacherid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StudentsId",
                table: "Subject",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsTeachers_teachersteacherid",
                table: "StudentsTeachers",
                column: "teachersteacherid");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Students_StudentsId",
                table: "Subject",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Students_StudentsId",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "StudentsTeachers");

            migrationBuilder.DropIndex(
                name: "IX_Subject_StudentsId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "StudentsId",
                table: "Subject");

            migrationBuilder.AddColumn<int>(
                name: "teacherid1",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_teacherid1",
                table: "Students",
                column: "teacherid1");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_teacher_teacherid1",
                table: "Students",
                column: "teacherid1",
                principalTable: "teacher",
                principalColumn: "teacherid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
