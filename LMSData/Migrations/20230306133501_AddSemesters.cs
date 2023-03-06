using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSData.Migrations
{
    /// <inheritdoc />
    public partial class AddSemesters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Term",
                table: "Courses",
                newName: "SemesterId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 70, DateTimeKind.Utc).AddTicks(7732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 935, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 70, DateTimeKind.Utc).AddTicks(5181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 934, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 54, DateTimeKind.Utc).AddTicks(4943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 914, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 54, DateTimeKind.Utc).AddTicks(2816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 913, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 116, DateTimeKind.Utc).AddTicks(820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 985, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 115, DateTimeKind.Utc).AddTicks(9684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 985, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 102, DateTimeKind.Utc).AddTicks(1090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 966, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 101, DateTimeKind.Utc).AddTicks(8764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 966, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 85, DateTimeKind.Utc).AddTicks(6359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 944, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 85, DateTimeKind.Utc).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 944, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 38, DateTimeKind.Utc).AddTicks(7856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 905, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 38, DateTimeKind.Utc).AddTicks(5219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 905, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 3, DateTimeKind.Utc).AddTicks(4329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 895, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 3, DateTimeKind.Utc).AddTicks(1023),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 895, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 0, 973, DateTimeKind.Utc).AddTicks(9306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 877, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 0, 973, DateTimeKind.Utc).AddTicks(7049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 877, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 128, DateTimeKind.Utc).AddTicks(6928)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 128, DateTimeKind.Utc).AddTicks(8862)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SemesterId",
                table: "Courses",
                column: "SemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropIndex(
                name: "IX_Courses_SemesterId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "SemesterId",
                table: "Courses",
                newName: "Term");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 935, DateTimeKind.Utc).AddTicks(1483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 70, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 934, DateTimeKind.Utc).AddTicks(9884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 70, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 914, DateTimeKind.Utc).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 54, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 913, DateTimeKind.Utc).AddTicks(7201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 54, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 985, DateTimeKind.Utc).AddTicks(3363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 116, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 985, DateTimeKind.Utc).AddTicks(628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 115, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 966, DateTimeKind.Utc).AddTicks(4429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 102, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 966, DateTimeKind.Utc).AddTicks(2151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 101, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 944, DateTimeKind.Utc).AddTicks(1502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 85, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 944, DateTimeKind.Utc).AddTicks(583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 85, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 905, DateTimeKind.Utc).AddTicks(1819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 38, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 905, DateTimeKind.Utc).AddTicks(416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 38, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 895, DateTimeKind.Utc).AddTicks(2373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 3, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 895, DateTimeKind.Utc).AddTicks(830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 3, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 877, DateTimeKind.Utc).AddTicks(1722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 0, 973, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 5, 17, 12, 20, 877, DateTimeKind.Utc).AddTicks(660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 0, 973, DateTimeKind.Utc).AddTicks(7049));
        }
    }
}
