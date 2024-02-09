using MediatR;

using ToDoList.Application.Common.Exceptions;
using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Persistence;

namespace ToDoList.Application.Tasks.Commands.DeleteTask
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
    {
        private readonly TodoDbContext _context;

        public DeleteTaskCommandHandler(TodoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Tasks.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(TaskEntity), request.Id);
            }

            _context.Tasks.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
