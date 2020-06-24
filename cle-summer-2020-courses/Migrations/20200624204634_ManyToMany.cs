using Microsoft.EntityFrameworkCore.Migrations;

namespace cle_summer_2020_courses.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "StudentCourses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourses",
                newName: "IX_StudentCourses_CourseId");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "StudentCourses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Machine");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "It's all");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "OMG");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ferris Bueller" },
                    { 2, "Cameron Frye" },
                    { 3, "Sloane Peterson" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "Id", "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 5, 3, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 2 },
                    { 4, 2, 3 },
                    { 6, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentCourses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Student_StudentId",
                table: "StudentCourses",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Student_StudentId",
                table: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentCourses");

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "StudentCourse");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_CourseId");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "StudentCourse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Machine learning for humans");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "It's all you need to learn it all");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "OMG, the front end will become your BFF");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
