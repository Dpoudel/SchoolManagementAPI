﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagementAPI.DataAccess;

namespace SchoolManagementAPI.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20201127191830_addteacher")]
    partial class addteacher
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SchoolModel.Class", b =>
                {
                    b.Property<int>("Gradeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("Gradeid");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("SchoolModel.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gradeid")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roll_number")
                        .HasColumnType("int");

                    b.Property<int?>("teacherid1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Gradeid");

                    b.HasIndex("teacherid1");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolModel.Subjects", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("SchoolModel.Teachers", b =>
                {
                    b.Property<int>("teacherid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teacherid");

                    b.ToTable("teacher");
                });

            modelBuilder.Entity("SchoolModel.Students", b =>
                {
                    b.HasOne("SchoolModel.Class", "Grade")
                        .WithMany("students")
                        .HasForeignKey("Gradeid");

                    b.HasOne("SchoolModel.Teachers", "teacher")
                        .WithMany()
                        .HasForeignKey("teacherid1");

                    b.Navigation("Grade");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("SchoolModel.Class", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
