using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSData.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 717, DateTimeKind.Utc).AddTicks(9842)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 718, DateTimeKind.Utc).AddTicks(659)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 734, DateTimeKind.Utc).AddTicks(4348)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 734, DateTimeKind.Utc).AddTicks(5184)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 687, DateTimeKind.Utc).AddTicks(3144)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 687, DateTimeKind.Utc).AddTicks(4172)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    CreditHours = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 695, DateTimeKind.Utc).AddTicks(6753)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 695, DateTimeKind.Utc).AddTicks(7760)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 727, DateTimeKind.Utc).AddTicks(4135)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 727, DateTimeKind.Utc).AddTicks(5579)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lecturers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lecturers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ActivityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 669, DateTimeKind.Utc).AddTicks(7130)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 669, DateTimeKind.Utc).AddTicks(8446)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 702, DateTimeKind.Utc).AddTicks(7305)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 702, DateTimeKind.Utc).AddTicks(8208)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LecturerSection",
                columns: table => new
                {
                    LecturersId = table.Column<int>(type: "int", nullable: false),
                    SectionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturerSection", x => new { x.LecturersId, x.SectionsId });
                    table.ForeignKey(
                        name: "FK_LecturerSection_Lecturers_LecturersId",
                        column: x => x.LecturersId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturerSection_Sections_SectionsId",
                        column: x => x.SectionsId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    StartTimeWithWeekday = table.Column<double>(type: "float", nullable: false),
                    EndTimeWithWeekday = table.Column<double>(type: "float", nullable: false),
                    AuditCreatedAt = table.Column<DateTime>(name: "Audit_CreatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 710, DateTimeKind.Utc).AddTicks(5740)),
                    AuditUpdatedAt = table.Column<DateTime>(name: "Audit_UpdatedAt", type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 3, 4, 23, 22, 55, 710, DateTimeKind.Utc).AddTicks(6902)),
                    AuditCreatedBy = table.Column<string>(name: "Audit_CreatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditUpdatedBy = table.Column<string>(name: "Audit_UpdatedBy", type: "nvarchar(max)", nullable: true, defaultValue: "admin"),
                    AuditStatus = table.Column<string>(name: "Audit_Status", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sessions_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CourseId",
                table: "Activities",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_DepartmentId",
                table: "Classes",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_DepartmentId",
                table: "Lecturers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_UserId",
                table: "Lecturers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerSection_SectionsId",
                table: "LecturerSection",
                column: "SectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_ActivityId",
                table: "Sections",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_RoomId",
                table: "Sessions",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_SectionId",
                table: "Sessions",
                column: "SectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "LecturerSection");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
