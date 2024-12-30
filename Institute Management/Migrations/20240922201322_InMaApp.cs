using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Management.Migrations
{
    /// <inheritdoc />
    public partial class InMaApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClassroom = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCoures = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CostCoures = table.Column<double>(type: "float", nullable: false),
                    DateOfCoures = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFull = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Date_B = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Geneder = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    specialy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Meterials",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_M = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meterials", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCourse = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NameClassroom = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Start_D = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_D = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Is_Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFull = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Date_B = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Geneder = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "attendances",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartAttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    ClassroomID = table.Column<int>(type: "int", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_attendances_Classrooms_ClassroomID",
                        column: x => x.ClassroomID,
                        principalTable: "Classrooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_attendances_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_attendances_Instructors_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_attendances_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "registretions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Geneder = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registretions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_registretions_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_registretions_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "exams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    period = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TextDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    ClassroomID = table.Column<int>(type: "int", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: false),
                    AttendanceID = table.Column<int>(type: "int", nullable: false),
                    RegistretionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_exams_Classrooms_ClassroomID",
                        column: x => x.ClassroomID,
                        principalTable: "Classrooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_exams_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_exams_Instructors_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_exams_attendances_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "attendances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_exams_registretions_RegistretionID",
                        column: x => x.RegistretionID,
                        principalTable: "registretions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Geade",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    GeadeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    level = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ExamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geade", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Geade_exams_ExamID",
                        column: x => x.ExamID,
                        principalTable: "exams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "certificates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeadeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_certificates_Geade_GeadeID",
                        column: x => x.GeadeID,
                        principalTable: "Geade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendances_ClassroomID",
                table: "attendances",
                column: "ClassroomID");

            migrationBuilder.CreateIndex(
                name: "IX_attendances_CourseID",
                table: "attendances",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_attendances_InstructorID",
                table: "attendances",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_attendances_StudentID",
                table: "attendances",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_certificates_GeadeID",
                table: "certificates",
                column: "GeadeID");

            migrationBuilder.CreateIndex(
                name: "IX_exams_AttendanceID",
                table: "exams",
                column: "AttendanceID");

            migrationBuilder.CreateIndex(
                name: "IX_exams_ClassroomID",
                table: "exams",
                column: "ClassroomID");

            migrationBuilder.CreateIndex(
                name: "IX_exams_CourseID",
                table: "exams",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_exams_InstructorID",
                table: "exams",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_exams_RegistretionID",
                table: "exams",
                column: "RegistretionID");

            migrationBuilder.CreateIndex(
                name: "IX_Geade_ExamID",
                table: "Geade",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_registretions_CourseID",
                table: "registretions",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_registretions_StudentID",
                table: "registretions",
                column: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "certificates");

            migrationBuilder.DropTable(
                name: "Meterials");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Geade");

            migrationBuilder.DropTable(
                name: "exams");

            migrationBuilder.DropTable(
                name: "attendances");

            migrationBuilder.DropTable(
                name: "registretions");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
