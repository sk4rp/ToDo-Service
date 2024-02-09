using MediatR;

using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Persistence;

namespace ToDoList.Application.Tasks.Commands.CreateTask
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
    {
        private readonly TodoDbContext _context;
        public CreateTaskCommandHandler(TodoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {

            var entity = new TaskEntity
            {
                Id = Guid.NewGuid(),
                Description = string.IsNullOrEmpty(request.Description)
                    ? string.Empty
                    : request.Description,
                FinalDate = request.FinalDate.ToUniversalTime(),
                IsCompleted = false,
                PlannedDate = request.PlannedDate.ToUniversalTime(),
                Priority = request.Priority,
                Title = request.Title,
            };

            _context.Tasks.Add(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }
    }
}
