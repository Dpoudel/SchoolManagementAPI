using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementAPI.Migrations
{
    public partial class addteacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grade_Gradeid",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "Gradeid",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_Students_Grade_Gradeid",
                table: "Students",
                column: "Gradeid",
                principalTable: "Grade",
                principalColumn: "Gradeid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_teacher_teacherid1",
                table: "Students",
                column: "teacherid1",
                principalTable: "teacher",
                principalColumn: "teacherid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grade_Gradeid",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_teacher_teacherid1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_teacherid1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "teacherid1",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "Gradeid",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grade_Gradeid",
                table: "Students",
                column: "Gradeid",
                principalTable: "Grade",
                principalColumn: "Gradeid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
