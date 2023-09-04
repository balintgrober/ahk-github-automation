﻿// <auto-generated />
using System;
using Ahk.GradeManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ahk.GradeManagement.Data.Migrations
{
    [DbContext(typeof(AhkDbContext))]
    partial class AhkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClassroomAssignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DeadLine")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.BranchCreateEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Repository")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BranchCreateEvents");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("AvailablePoints")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("GithubPrNumber")
                        .HasColumnType("int");

                    b.Property<string>("GithubPrUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubRepoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId")
                        .IsUnique();

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int?>("GradeId")
                        .HasColumnType("int");

                    b.Property<double>("PointEarned")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId")
                        .IsUnique();

                    b.HasIndex("GradeId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.PullRequestEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HtmlUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neptun")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Repository")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PullRequestEvents");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.RepositoryCreateEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Repository")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RepositoryCreateEvents");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.StatusTracking.Assignee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GithubUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PullRequestEventId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PullRequestEventId");

                    b.ToTable("Assignee");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EduEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neptun")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.StudentAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAssignments");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.StudentGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentGroups");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.StudentSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AhkConfig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubOrg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EduEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neptun")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.TeacherGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherGroups");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.TeacherSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherSubjects");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.WebhookToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secret")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WebhookTokens");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.WorkflowRunEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Conclusion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Repository")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WorkflowRunEvents");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Assignment", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Subject", "Subject")
                        .WithMany("Assignments")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Exercise", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Assignment", "Assignment")
                        .WithMany("Exercises")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Grade", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Assignment", "Assignment")
                        .WithOne("Grade")
                        .HasForeignKey("Ahk.GradeManagement.Data.Entities.Grade", "AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahk.GradeManagement.Data.Entities.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Group", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Subject", "Subject")
                        .WithMany("Groups")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Point", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Exercise", "Exercise")
                        .WithOne("Point")
                        .HasForeignKey("Ahk.GradeManagement.Data.Entities.Point", "ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahk.GradeManagement.Data.Entities.Grade", "Grade")
                        .WithMany("Points")
                        .HasForeignKey("GradeId");

                    b.Navigation("Exercise");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.StatusTracking.Assignee", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.PullRequestEvent", "PullRequestEvent")
                        .WithMany("Assignees")
                        .HasForeignKey("PullRequestEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PullRequestEvent");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.StudentAssignment", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Assignment", "Assignment")
                        .WithMany("StudentAssignments")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahk.GradeManagement.Data.Entities.Student", "Student")
                        .WithMany("StudentAssignments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.StudentGroup", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Group", "Group")
                        .WithMany("StudentGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahk.GradeManagement.Data.Entities.Student", "Student")
                        .WithMany("StudentGroups")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.StudentSubject", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahk.GradeManagement.Data.Entities.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.TeacherGroup", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Group", "Group")
                        .WithMany("TeacherGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahk.GradeManagement.Data.Entities.Teacher", "Teacher")
                        .WithMany("TeacherGroups")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.TeacherSubject", b =>
                {
                    b.HasOne("Ahk.GradeManagement.Data.Entities.Subject", "Subject")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ahk.GradeManagement.Data.Entities.Teacher", "Teacher")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Assignment", b =>
                {
                    b.Navigation("Exercises");

                    b.Navigation("Grade");

                    b.Navigation("StudentAssignments");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Exercise", b =>
                {
                    b.Navigation("Point");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Grade", b =>
                {
                    b.Navigation("Points");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Group", b =>
                {
                    b.Navigation("StudentGroups");

                    b.Navigation("TeacherGroups");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.PullRequestEvent", b =>
                {
                    b.Navigation("Assignees");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Student", b =>
                {
                    b.Navigation("Grades");

                    b.Navigation("StudentAssignments");

                    b.Navigation("StudentGroups");

                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Subject", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Groups");

                    b.Navigation("StudentSubjects");

                    b.Navigation("TeacherSubjects");
                });

            modelBuilder.Entity("Ahk.GradeManagement.Data.Entities.Teacher", b =>
                {
                    b.Navigation("TeacherGroups");

                    b.Navigation("TeacherSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
