﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToDoList.Infrastructure.Persistence;

#nullable disable

namespace ToDoList.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20240207093538_DataSeed")]
    partial class DataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ToDoList.Domain.Entities.TaskEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("PlannedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("TaskEntity", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("79ab5bac-4cd8-4cc4-9926-5ea6918a60d6"),
                            Description = "Task 1 description",
                            FinalDate = new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            PlannedDate = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 0,
                            Title = "Task 1"
                        },
                        new
                        {
                            Id = new Guid("97a8e2db-3946-4ed3-a4d5-c33550260ff1"),
                            Description = "Task 2 description",
                            FinalDate = new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = true,
                            PlannedDate = new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 2,
                            Title = "Task 2"
                        },
                        new
                        {
                            Id = new Guid("5f54bfbf-1dc8-476b-91ed-80aed95ae0cf"),
                            Description = "Task 3 description",
                            FinalDate = new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            PlannedDate = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 1,
                            Title = "Task 3"
                        },
                        new
                        {
                            Id = new Guid("744c5540-2666-4c68-9120-9cc07e09d854"),
                            Description = "Task 4 description",
                            FinalDate = new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            PlannedDate = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 0,
                            Title = "Task 4"
                        },
                        new
                        {
                            Id = new Guid("c13c9427-1f49-474e-9b7a-fa32476f1f53"),
                            Description = "Task 5 description",
                            FinalDate = new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = true,
                            PlannedDate = new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 2,
                            Title = "Task 5"
                        },
                        new
                        {
                            Id = new Guid("e3499fda-9136-4c8a-a691-8e17a20180fd"),
                            Description = "Task 6 description",
                            FinalDate = new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = true,
                            PlannedDate = new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 2,
                            Title = "Task 6"
                        },
                        new
                        {
                            Id = new Guid("50df2970-0fd7-46a6-92c5-bc97e9127c74"),
                            Description = "Task 7 description",
                            FinalDate = new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = true,
                            PlannedDate = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 1,
                            Title = "Task 7"
                        },
                        new
                        {
                            Id = new Guid("de39931e-2052-4c59-a622-047f1452040c"),
                            Description = "Task 8 description",
                            FinalDate = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            PlannedDate = new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 0,
                            Title = "Task 8"
                        },
                        new
                        {
                            Id = new Guid("34f15f31-38b0-4559-8f52-7a37b39042e3"),
                            Description = "Task 9 description",
                            FinalDate = new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = true,
                            PlannedDate = new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 2,
                            Title = "Task 9"
                        },
                        new
                        {
                            Id = new Guid("7b5e1aa1-7086-4e2a-879d-136ed81624eb"),
                            Description = "Task 10 description",
                            FinalDate = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = true,
                            PlannedDate = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 1,
                            Title = "Task 10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
