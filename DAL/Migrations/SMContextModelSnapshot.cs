﻿// <auto-generated />
using System;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(SMContext))]
    partial class SMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Disciplines", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisciplineTitle")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("DAL.Entities.Faculty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacultyName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("DAL.Entities.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyID")
                        .HasColumnType("int");

                    b.Property<string>("Group1")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Group");

                    b.HasKey("ID");

                    b.HasIndex("FacultyID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DAL.Entities.Mark", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisciplineID")
                        .HasColumnType("int");

                    b.Property<int?>("Result")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("TypeMarkID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DisciplineID");

                    b.HasIndex("StudentID");

                    b.HasIndex("TypeMarkID");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("DAL.Entities.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message1")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)")
                        .HasColumnName("Message");

                    b.HasKey("ID");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("DAL.Entities.MessageJoin", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MessageID1")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("MessageID");

                    b.HasIndex("MessageID1");

                    b.HasIndex("StudentID");

                    b.HasIndex("TeacherID");

                    b.ToTable("MessageJoin");
                });

            modelBuilder.Entity("DAL.Entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("UserStudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.HasIndex("UserStudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DAL.Entities.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("UserTeacherID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserTeacherID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("DAL.Entities.TypeMark", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeMark1")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("TypeMark");

                    b.HasKey("ID");

                    b.ToTable("TypeMark");
                });

            modelBuilder.Entity("DAL.Entities.UserStudent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentLogin")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StudentPass")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("UserStudent");
                });

            modelBuilder.Entity("DAL.Entities.UserTeacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherLogin")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TeacherPass")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("UserTeacher");
                });

            modelBuilder.Entity("DAL.Entities.Group", b =>
                {
                    b.HasOne("DAL.Entities.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("DAL.Entities.Mark", b =>
                {
                    b.HasOne("DAL.Entities.Disciplines", "Discipline")
                        .WithMany("Marks")
                        .HasForeignKey("DisciplineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.TypeMark", "TypeMark")
                        .WithMany("Marks")
                        .HasForeignKey("TypeMarkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Student");

                    b.Navigation("TypeMark");
                });

            modelBuilder.Entity("DAL.Entities.MessageJoin", b =>
                {
                    b.HasOne("DAL.Entities.Message", "Message")
                        .WithMany("MessageJoins")
                        .HasForeignKey("MessageID1");

                    b.HasOne("DAL.Entities.Student", "Student")
                        .WithMany("MessageJoins")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Teacher", "Teacher")
                        .WithMany("MessageJoins")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("DAL.Entities.Student", b =>
                {
                    b.HasOne("DAL.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupID");

                    b.HasOne("DAL.Entities.UserStudent", "UserStudent")
                        .WithMany("Students")
                        .HasForeignKey("UserStudentID");

                    b.Navigation("Group");

                    b.Navigation("UserStudent");
                });

            modelBuilder.Entity("DAL.Entities.Teacher", b =>
                {
                    b.HasOne("DAL.Entities.UserTeacher", "UserTeacher")
                        .WithMany("Teachers")
                        .HasForeignKey("UserTeacherID");

                    b.Navigation("UserTeacher");
                });

            modelBuilder.Entity("DAL.Entities.Disciplines", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("DAL.Entities.Faculty", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("DAL.Entities.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("DAL.Entities.Message", b =>
                {
                    b.Navigation("MessageJoins");
                });

            modelBuilder.Entity("DAL.Entities.Student", b =>
                {
                    b.Navigation("Marks");

                    b.Navigation("MessageJoins");
                });

            modelBuilder.Entity("DAL.Entities.Teacher", b =>
                {
                    b.Navigation("MessageJoins");
                });

            modelBuilder.Entity("DAL.Entities.TypeMark", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("DAL.Entities.UserStudent", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("DAL.Entities.UserTeacher", b =>
                {
                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
