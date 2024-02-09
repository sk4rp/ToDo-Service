using MediatR;
using ToDoList.Application.Tasks.Queries;
using ToDoList.Domain.ValueObjects;

namespace ToDoList.Application.Tasks.Commands.CreateTask
{
    public class CreateTaskCommand : IRequest<Guid>
    {
        public CreateTaskCommand(string title, DateTime plannedDate, DateTime finalDate, Priority priority, string description)
        {
            Title = title;
            PlannedDate = plannedDate;
            FinalDate = finalDate;
            Priority = priority;
            Description = description;
        }

        public string Title { get; }

        public DateTime PlannedDate { get; }

        public DateTime FinalDate { get; }

        public Priority Priority { get; }

        public string Description { get; }
    }

}
