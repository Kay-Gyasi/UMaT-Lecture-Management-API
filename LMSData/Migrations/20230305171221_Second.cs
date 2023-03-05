using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSData.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 935, DateTimeKind.Utc).AddTicks(1483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 710, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 934, DateTimeKind.Utc).AddTicks(9884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 710, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 914, DateTimeKind.Utc).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 702, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 913, DateTimeKind.Utc).AddTicks(7201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 702, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 985, DateTimeKind.Utc).AddTicks(3363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 734, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 985, DateTimeKind.Utc).AddTicks(628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 734, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 966, DateTimeKind.Utc).AddTicks(4429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 727, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 966, DateTimeKind.Utc).AddTicks(2151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 727, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 944, DateTimeKind.Utc).AddTicks(1502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 718, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 944, DateTimeKind.Utc).AddTicks(583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 717, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 905, DateTimeKind.Utc).AddTicks(1819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 695, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 905, DateTimeKind.Utc).AddTicks(416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 695, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 895, DateTimeKind.Utc).AddTicks(2373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 687, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 895, DateTimeKind.Utc).AddTicks(830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 687, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 877, DateTimeKind.Utc).AddTicks(1722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 669, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 877, DateTimeKind.Utc).AddTicks(660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 669, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.CreateTable(
                name: "ClassCourse",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    CoursesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCourse", x => new { x.ClassesId, x.CoursesId });
                    table.ForeignKey(
                        name: "FK_ClassCourse_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassCourse_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourse_CoursesId",
                table: "ClassCourse",
                column: "CoursesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassCourse");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Courses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 710, DateTimeKind.Utc).AddTicks(6902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 935, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 710, DateTimeKind.Utc).AddTicks(5740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 934, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 702, DateTimeKind.Utc).AddTicks(8208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 914, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 702, DateTimeKind.Utc).AddTicks(7305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 913, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 734, DateTimeKind.Utc).AddTicks(5184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 985, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 734, DateTimeKind.Utc).AddTicks(4348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 985, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 727, DateTimeKind.Utc).AddTicks(5579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 966, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 727, DateTimeKind.Utc).AddTicks(4135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 966, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 718, DateTimeKind.Utc).AddTicks(659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 944, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 717, DateTimeKind.Utc).AddTicks(9842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 944, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 695, DateTimeKind.Utc).AddTicks(7760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 905, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 695, DateTimeKind.Utc).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 905, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 687, DateTimeKind.Utc).AddTicks(4172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 895, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 687, DateTimeKind.Utc).AddTicks(3144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 895, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 669, DateTimeKind.Utc).AddTicks(8446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 877, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 669, DateTimeKind.Utc).AddTicks(7130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 877, DateTimeKind.Utc).AddTicks(660));
        }
    }
}
