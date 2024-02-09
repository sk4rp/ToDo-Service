using MediatR;

using ToDoList.Application.Common.Exceptions;
using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Persistence;

namespace ToDoList.Application.Tasks.Commands.UpdateTask
{
    public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand>
    {
        private readonly TodoDbContext _context;

        public UpdateTaskCommandHandler(TodoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Tasks.FindAsync(request.TaskId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(TaskEntity), request.TaskId);
            }

            entity.Description = request.Description;
            entity.FinalDate = request.FinalDate.ToUniversalTime();
            entity.IsCompleted = request.IsCompleted;
            entity.PlannedDate = request.PlannedDate.ToUniversalTime();
            entity.Priority = request.Priority;
            entity.Title = request.Title;

            await _context.SaveChangesAsync();
        }
    }
}
