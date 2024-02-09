using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ToDoList.Domain.Common;
using ToDoList.Domain.Entities;
using ToDoList.Domain.ValueObjects;

namespace ToDoList.Infrastructure.Persistence.Configurations
{
    public class TaskEntityConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.ToTable(nameof(TaskEntity));

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.Title)
                .HasMaxLength(Constants.TaskTitleMaxLength)
                .IsRequired();

            builder.Property(t => t.Description)
                .HasMaxLength(Constants.TaskDescriptionMaxLength)
                .IsRequired();

            SeedSimpleTasks(builder);
        }

        private void SeedSimpleTasks(EntityTypeBuilder<TaskEntity> builder)
        {
            var tasks = new List<TaskEntity>
            {
                new()
                {
                    Id = new Guid("79ab5bac-4cd8-4cc4-9926-5ea6918a60d6"),
                    Title = "Task 1",
                    Description = "Task 1 description",
                    FinalDate = new DateTime(2024,3,10),
                    PlannedDate = new DateTime(2024,3,1),
                    Priority= Priority.Low
                },
                new()
                {
                    Id = new Guid("97a8e2db-3946-4ed3-a4d5-c33550260ff1"),
                    Title = "Task 2",
                    Description = "Task 2 description",
                    FinalDate = new DateTime(2024,4,10),
                    PlannedDate = new DateTime(2024,4,1),
                    Priority= Priority.High,
                    IsCompleted = true
                },
                new()
                {
                    Id = new Guid("5f54bfbf-1dc8-476b-91ed-80aed95ae0cf"),
                    Title = "Task 3",
                    Description = "Task 3 description",
                    FinalDate = new DateTime(2024,5,10),
                    PlannedDate = new DateTime(2024,5,1),
                    Priority= Priority.Medium
                },
                new()
                {
                    Id = new Guid("744c5540-2666-4c68-9120-9cc07e09d854"),
                    Title = "Task 4",
                    Description = "Task 4 description",
                    FinalDate = new DateTime(2024,6,10),
                    PlannedDate = new DateTime(2024,6,1),
                    Priority= Priority.Low
                },
                new()
                {
                    Id = new Guid("c13c9427-1f49-474e-9b7a-fa32476f1f53"),
                    Title = "Task 5",
                    Description = "Task 5 description",
                    FinalDate = new DateTime(2024,7,10),
                    PlannedDate = new DateTime(2024,7,1),
                    Priority= Priority.High,
                    IsCompleted = true
                },

                new()
                {
                    Id = new Guid("e3499fda-9136-4c8a-a691-8e17a20180fd"),
                    Title = "Task 6",
                    Description = "Task 6 description",
                    FinalDate = new DateTime(2024,8,10),
                    PlannedDate = new DateTime(2024,8,1),
                    Priority= Priority.High,
                    IsCompleted = true
                },

                new()
                {
                    Id = new Guid("50df2970-0fd7-46a6-92c5-bc97e9127c74"),
                    Title = "Task 7",
                    Description = "Task 7 description",
                    FinalDate = new DateTime(2024,9,10),
                    PlannedDate = new DateTime(2024,9,1),
                    Priority= Priority.Medium,
                    IsCompleted = true
                },

                new()
                {
                    Id = new Guid("de39931e-2052-4c59-a622-047f1452040c"),
                    Title = "Task 8",
                    Description = "Task 8 description",
                    FinalDate = new DateTime(2024,10,10),
                    PlannedDate = new DateTime(2024,10,1),
                    Priority= Priority.Low,
                },

                new()
                {
                    Id = new Guid("34f15f31-38b0-4559-8f52-7a37b39042e3"),
                    Title = "Task 9",
                    Description = "Task 9 description",
                    FinalDate = new DateTime(2024,11,10),
                    PlannedDate = new DateTime(2024,11,1),
                    Priority= Priority.High,
                    IsCompleted = true
                },

                new()
                {
                    Id = new Guid("7b5e1aa1-7086-4e2a-879d-136ed81624eb"),
                    Title = "Task 10",
                    Description = "Task 10 description",
                    FinalDate = new DateTime(2024,12,10),
                    PlannedDate = new DateTime(2024,12,1),
                    Priority= Priority.Medium,
                    IsCompleted = true
                }
            };

            builder.HasData(tasks);
        }
    }
}
