using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ToDoList.Domain.Entities;
using ToDoList.Domain.ValueObjects;

namespace ToDoList.Application.Tasks.Queries
{
    public class TaskDto
    {
        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Title { get; set; }
        public Priority Priority { get; set; }
        public DateTime PlannedDate { get; set; }
        public DateTime FinalDate { get; set; }
        public string Description { get; set; }

        public static TaskDto Create(TaskEntity entity)
        {
            return new TaskDto
            {
                Description = entity.Description,
                FinalDate = entity.FinalDate.ToUniversalTime(),
                Id = entity.Id,
                IsCompleted = entity.IsCompleted,
                PlannedDate = entity.PlannedDate.ToUniversalTime(),
                Priority = entity.Priority,
                Title = entity.Title,
            };
        }
    }
}
