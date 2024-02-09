using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoList.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    PlannedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FinalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskEntity",
                columns: new[] { "Id", "Description", "FinalDate", "IsCompleted", "PlannedDate", "Priority", "Title" },
                values: new object[,]
                {
                    { new Guid("34f15f31-38b0-4559-8f52-7a37b39042e3"), "Task 9 description", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 9" },
                    { new Guid("50df2970-0fd7-46a6-92c5-bc97e9127c74"), "Task 7 description", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Task 7" },
                    { new Guid("5f54bfbf-1dc8-476b-91ed-80aed95ae0cf"), "Task 3 description", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Task 3" },
                    { new Guid("744c5540-2666-4c68-9120-9cc07e09d854"), "Task 4 description", new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Task 4" },
                    { new Guid("79ab5bac-4cd8-4cc4-9926-5ea6918a60d6"), "Task 1 description", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Task 1" },
                    { new Guid("7b5e1aa1-7086-4e2a-879d-136ed81624eb"), "Task 10 description", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Task 10" },
                    { new Guid("97a8e2db-3946-4ed3-a4d5-c33550260ff1"), "Task 2 description", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 2" },
                    { new Guid("c13c9427-1f49-474e-9b7a-fa32476f1f53"), "Task 5 description", new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 5" },
                    { new Guid("de39931e-2052-4c59-a622-047f1452040c"), "Task 8 description", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Task 8" },
                    { new Guid("e3499fda-9136-4c8a-a691-8e17a20180fd"), "Task 6 description", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskEntity");
        }
    }
}
