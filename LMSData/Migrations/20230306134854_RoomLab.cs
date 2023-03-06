using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSData.Migrations
{
    /// <inheritdoc />
    public partial class RoomLab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 60, DateTimeKind.Utc).AddTicks(3987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 70, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 60, DateTimeKind.Utc).AddTicks(2837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 70, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 105, DateTimeKind.Utc).AddTicks(9000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 128, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 105, DateTimeKind.Utc).AddTicks(7710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 128, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 49, DateTimeKind.Utc).AddTicks(6071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 54, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 49, DateTimeKind.Utc).AddTicks(4904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 54, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 95, DateTimeKind.Utc).AddTicks(7698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 116, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 95, DateTimeKind.Utc).AddTicks(6128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 115, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.AddColumn<bool>(
                name: "IsLab",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 80, DateTimeKind.Utc).AddTicks(5421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 102, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 80, DateTimeKind.Utc).AddTicks(4587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 101, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 69, DateTimeKind.Utc).AddTicks(4807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 85, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 69, DateTimeKind.Utc).AddTicks(3850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 85, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 36, DateTimeKind.Utc).AddTicks(9904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 38, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 36, DateTimeKind.Utc).AddTicks(6182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 38, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 15, DateTimeKind.Utc).AddTicks(8801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 3, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 15, DateTimeKind.Utc).AddTicks(5002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 3, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 53, 958, DateTimeKind.Utc).AddTicks(4785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 0, 973, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 53, 958, DateTimeKind.Utc).AddTicks(2166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 35, 0, 973, DateTimeKind.Utc).AddTicks(7049));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLab",
                table: "Rooms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 70, DateTimeKind.Utc).AddTicks(7732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 60, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 70, DateTimeKind.Utc).AddTicks(5181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 60, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 128, DateTimeKind.Utc).AddTicks(8862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 105, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 128, DateTimeKind.Utc).AddTicks(6928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 105, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 54, DateTimeKind.Utc).AddTicks(4943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 49, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 54, DateTimeKind.Utc).AddTicks(2816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 49, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 116, DateTimeKind.Utc).AddTicks(820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 95, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 115, DateTimeKind.Utc).AddTicks(9684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 95, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 102, DateTimeKind.Utc).AddTicks(1090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 80, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 101, DateTimeKind.Utc).AddTicks(8764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 80, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 85, DateTimeKind.Utc).AddTicks(6359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 69, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 85, DateTimeKind.Utc).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 69, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 38, DateTimeKind.Utc).AddTicks(7856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 36, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 38, DateTimeKind.Utc).AddTicks(5219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 36, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 3, DateTimeKind.Utc).AddTicks(4329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 15, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 1, 3, DateTimeKind.Utc).AddTicks(1023),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 15, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 0, 973, DateTimeKind.Utc).AddTicks(9306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 53, 958, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 35, 0, 973, DateTimeKind.Utc).AddTicks(7049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 53, 958, DateTimeKind.Utc).AddTicks(2166));
        }
    }
}
