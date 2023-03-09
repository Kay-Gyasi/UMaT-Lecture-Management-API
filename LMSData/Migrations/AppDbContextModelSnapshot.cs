﻿// <auto-generated />
using System;
using LMSData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMSData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassCourse", b =>
                {
                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.HasKey("ClassesId", "CoursesId");

                    b.HasIndex("CoursesId");

                    b.ToTable("ClassCourse");
                });

            modelBuilder.Entity("LMSData.Classes.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Classes", (string)null);
                });

            modelBuilder.Entity("LMSData.Courses.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreditHours")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("LecturerId");

                    b.HasIndex("SemesterId");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("LMSData.Departments.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("LMSData.Lecturers.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("Lecturers", (string)null);
                });

            modelBuilder.Entity("LMSData.Rooms.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsLab")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWorkshop")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms", (string)null);
                });

            modelBuilder.Entity("LMSData.Semesters.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("LMSData.Students.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LMSData.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ClassCourse", b =>
                {
                    b.HasOne("LMSData.Classes.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMSData.Courses.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LMSData.Classes.Class", b =>
                {
                    b.HasOne("LMSData.Departments.Department", "Department")
                        .WithMany("Classes")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("LMSData.Base.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("ClassId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 4, DateTimeKind.Utc).AddTicks(6863));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 4, DateTimeKind.Utc).AddTicks(9787));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("ClassId");

                            b1.ToTable("Classes");

                            b1.WithOwner()
                                .HasForeignKey("ClassId");
                        });

                    b.Navigation("Audit");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("LMSData.Courses.Course", b =>
                {
                    b.HasOne("LMSData.Departments.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMSData.Lecturers.Lecturer", "Lecturer")
                        .WithMany("Courses")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMSData.Semesters.Semester", "Semester")
                        .WithMany("Courses")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("LMSData.Base.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("CourseId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 66, DateTimeKind.Utc).AddTicks(5863));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 67, DateTimeKind.Utc).AddTicks(1752));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("CourseId");

                            b1.ToTable("Courses");

                            b1.WithOwner()
                                .HasForeignKey("CourseId");
                        });

                    b.Navigation("Audit");

                    b.Navigation("Department");

                    b.Navigation("Lecturer");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("LMSData.Departments.Department", b =>
                {
                    b.OwnsOne("LMSData.Base.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("DepartmentId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 88, DateTimeKind.Utc).AddTicks(6333));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 89, DateTimeKind.Utc).AddTicks(3958));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("DepartmentId");

                            b1.ToTable("Departments");

                            b1.WithOwner()
                                .HasForeignKey("DepartmentId");
                        });

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("LMSData.Lecturers.Lecturer", b =>
                {
                    b.HasOne("LMSData.Departments.Department", null)
                        .WithMany("Lectures")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("LMSData.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("LMSData.Base.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("LecturerId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 114, DateTimeKind.Utc).AddTicks(7630));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 115, DateTimeKind.Utc).AddTicks(1827));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("LecturerId");

                            b1.ToTable("Lecturers");

                            b1.WithOwner()
                                .HasForeignKey("LecturerId");
                        });

                    b.Navigation("Audit");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LMSData.Rooms.Room", b =>
                {
                    b.OwnsOne("LMSData.Base.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("RoomId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 134, DateTimeKind.Utc).AddTicks(9025));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 135, DateTimeKind.Utc).AddTicks(859));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("RoomId");

                            b1.ToTable("Rooms");

                            b1.WithOwner()
                                .HasForeignKey("RoomId");
                        });

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("LMSData.Semesters.Semester", b =>
                {
                    b.OwnsOne("LMSData.Base.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("SemesterId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 163, DateTimeKind.Utc).AddTicks(2656));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 163, DateTimeKind.Utc).AddTicks(5032));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("SemesterId");

                            b1.ToTable("Semesters");

                            b1.WithOwner()
                                .HasForeignKey("SemesterId");
                        });

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("LMSData.Students.Student", b =>
                {
                    b.HasOne("LMSData.Classes.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("LMSData.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("LMSData.Base.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("StudentId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 181, DateTimeKind.Utc).AddTicks(5885));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 3, 9, 14, 20, 15, 181, DateTimeKind.Utc).AddTicks(8125));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("StudentId");

                            b1.ToTable("Students");

                            b1.WithOwner()
                                .HasForeignKey("StudentId");
                        });

                    b.Navigation("Audit");

                    b.Navigation("Class");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("LMSData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("LMSData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMSData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("LMSData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LMSData.Departments.Department", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Courses");

                    b.Navigation("Lectures");
                });

            modelBuilder.Entity("LMSData.Lecturers.Lecturer", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("LMSData.Semesters.Semester", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
