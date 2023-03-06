using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSData.Migrations
{
    /// <inheritdoc />
    public partial class RoomWorkshop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 638, DateTimeKind.Utc).AddTicks(5097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 60, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 638, DateTimeKind.Utc).AddTicks(3619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 60, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 711, DateTimeKind.Utc).AddTicks(9844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 105, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 711, DateTimeKind.Utc).AddTicks(5445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 105, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 620, DateTimeKind.Utc).AddTicks(636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 49, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 619, DateTimeKind.Utc).AddTicks(8573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 49, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 695, DateTimeKind.Utc).AddTicks(6281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 95, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 695, DateTimeKind.Utc).AddTicks(3031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 95, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.AddColumn<bool>(
                name: "IsWorkshop",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 673, DateTimeKind.Utc).AddTicks(5843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 80, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 673, DateTimeKind.Utc).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 80, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 651, DateTimeKind.Utc).AddTicks(9581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 69, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 651, DateTimeKind.Utc).AddTicks(6571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 69, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 598, DateTimeKind.Utc).AddTicks(1508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 36, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 597, DateTimeKind.Utc).AddTicks(9165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 36, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 580, DateTimeKind.Utc).AddTicks(8381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 15, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 580, DateTimeKind.Utc).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 15, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 544, DateTimeKind.Utc).AddTicks(1624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 53, 958, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 543, DateTimeKind.Utc).AddTicks(8668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 48, 53, 958, DateTimeKind.Utc).AddTicks(2166));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWorkshop",
                table: "Rooms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 60, DateTimeKind.Utc).AddTicks(3987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 638, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 60, DateTimeKind.Utc).AddTicks(2837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 638, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 105, DateTimeKind.Utc).AddTicks(9000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 711, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 105, DateTimeKind.Utc).AddTicks(7710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 711, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 49, DateTimeKind.Utc).AddTicks(6071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 620, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 49, DateTimeKind.Utc).AddTicks(4904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 619, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 95, DateTimeKind.Utc).AddTicks(7698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 695, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 95, DateTimeKind.Utc).AddTicks(6128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 695, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 80, DateTimeKind.Utc).AddTicks(5421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 673, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Lecturers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 80, DateTimeKind.Utc).AddTicks(4587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 673, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 69, DateTimeKind.Utc).AddTicks(4807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 651, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 69, DateTimeKind.Utc).AddTicks(3850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 651, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 36, DateTimeKind.Utc).AddTicks(9904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 598, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 36, DateTimeKind.Utc).AddTicks(6182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 597, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 15, DateTimeKind.Utc).AddTicks(8801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 580, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 54, 15, DateTimeKind.Utc).AddTicks(5002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 580, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_UpdatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 53, 958, DateTimeKind.Utc).AddTicks(4785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 544, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Audit_CreatedAt",
                table: "Activities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 6, 13, 48, 53, 958, DateTimeKind.Utc).AddTicks(2166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 6, 13, 54, 28, 543, DateTimeKind.Utc).AddTicks(8668));
        }
    }
}
