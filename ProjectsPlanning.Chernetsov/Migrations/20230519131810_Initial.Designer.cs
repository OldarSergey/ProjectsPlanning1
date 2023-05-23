﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectsPlanning.Chernetsov.Data;

#nullable disable

namespace ProjectsPlanning.Chernetsov.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230519131810_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_Categories_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_Companies_Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Experience")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Employees_Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TeamId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Plans_Id");

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.PlanTask", b =>
                {
                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.HasKey("PlanId", "TaskId")
                        .HasName("PK_PlanTasks_PlanId_ProjectTaskId");

                    b.HasIndex("TaskId");

                    b.ToTable("PlanTasks");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nvarchar");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id")
                        .HasName("PK_Posts_Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Projects_Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("StatusId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_Statuses_Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TaskTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Tasks_Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("TaskTypeId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_TaskTypes");

                    b.ToTable("TaskTypes");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Teams_Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Company", b =>
                {
                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Employee", "Employee")
                        .WithOne("Company")
                        .HasForeignKey("ProjectsPlanning.Chernetsov.Entities.Company", "EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Employees_CompanyId_Companies_Id");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Employee", b =>
                {
                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Post", "Post")
                        .WithMany("Employees")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Employees_PostId_Posts_Id");

                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Employees_TeamId_Teams_Id");

                    b.Navigation("Post");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Plan", b =>
                {
                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Project", "Project")
                        .WithOne("Plan")
                        .HasForeignKey("ProjectsPlanning.Chernetsov.Entities.Plan", "ProjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Projects_PlanId_Plans_Id");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.PlanTask", b =>
                {
                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Plan", "Plan")
                        .WithMany("PlanTasks")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_PlanTasks_PlanId_Plans_Id");

                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Task", "Task")
                        .WithMany("PlanTasks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_PlanTasks_TaskId_Tasks_Id");

                    b.Navigation("Plan");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Project", b =>
                {
                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Category", "Category")
                        .WithMany("Projects")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Projects_CategoryId_Categories_Id");

                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Company", "Company")
                        .WithMany("Projects")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Projects_CompanyId_Companies_Id");

                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Status", "Status")
                        .WithMany("Projects")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Projects_StatusId_Statuses_Id");

                    b.Navigation("Category");

                    b.Navigation("Company");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Task", b =>
                {
                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Status", "Status")
                        .WithMany("Tasks")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Tasks_StatusId_Statuses_Id");

                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.TaskType", "TaskType")
                        .WithMany("Tasks")
                        .HasForeignKey("TaskTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Tasks_TaskTypeId_TaskTypes_Id");

                    b.Navigation("Status");

                    b.Navigation("TaskType");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Team", b =>
                {
                    b.HasOne("ProjectsPlanning.Chernetsov.Entities.Project", "Project")
                        .WithMany("Teams")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Teams_ProjectId_Projects_Id");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Category", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Company", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Employee", b =>
                {
                    b.Navigation("Company")
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Plan", b =>
                {
                    b.Navigation("PlanTasks");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Post", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Project", b =>
                {
                    b.Navigation("Plan")
                        .IsRequired();

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Status", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Task", b =>
                {
                    b.Navigation("PlanTasks");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.TaskType", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("ProjectsPlanning.Chernetsov.Entities.Team", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}