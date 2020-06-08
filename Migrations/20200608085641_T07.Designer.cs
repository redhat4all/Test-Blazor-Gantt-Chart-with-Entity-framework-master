﻿// <auto-generated />
using System;
using GanttEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GanttEF.Migrations
{
    [DbContext(typeof(MasterContext))]
    [Migration("20200608085641_T07")]
    partial class T07
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GanttEF.Models.GanttData", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BaselineEndDate")
                        .HasColumnName("BaselineEndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("BaselineStartDate")
                        .HasColumnName("BaselineStartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("Edate")
                        .HasColumnName("Edate")
                        .HasColumnType("datetime");

                    b.Property<int?>("GanttDataId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Naresh")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Predecessor")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Sdate")
                        .HasColumnName("Sdate")
                        .HasColumnType("datetime");

                    b.Property<string>("TaskType")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("GanttDataId");

                    b.ToTable("GanttData");
                });

            modelBuilder.Entity("GanttEF.Models.GanttData", b =>
                {
                    b.HasOne("GanttEF.Models.GanttData", null)
                        .WithMany("SubTasks")
                        .HasForeignKey("GanttDataId");
                });
#pragma warning restore 612, 618
        }
    }
}
