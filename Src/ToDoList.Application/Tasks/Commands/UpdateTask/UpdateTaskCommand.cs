using MediatR;

using ToDoList.Domain.ValueObjects;

namespace ToDoList.Application.Tasks.Commands.UpdateTask
{
    public class UpdateTaskCommand : IRequest
    {
        public UpdateTaskCommand(Guid taskId, bool isCompleted, string title, Priority priority, DateTime plannedDate, DateTime finalDate, string description)
        {
            TaskId = taskId;
            IsCompleted = isCompleted;
            Title = title;
            Priority = priority;
            PlannedDate = plannedDate;
            FinalDate = finalDate;
            Description = description;
        }

        public Guid TaskId { get; }
        public bool IsCompleted { get; }
        public string Title { get; }
        public Priority Priority { get; }
        public DateTime PlannedDate { get; }
        public DateTime FinalDate { get; }
        public string Description { get; }
    }
}
