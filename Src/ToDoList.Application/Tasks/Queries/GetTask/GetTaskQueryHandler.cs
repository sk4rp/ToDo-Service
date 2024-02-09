using MediatR;

using ToDoList.Application.Common.Exceptions;
using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Persistence;

namespace ToDoList.Application.Tasks.Queries.GetTask
{
    public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, TaskDto>
    {
        private readonly TodoDbContext _context;

        public GetTaskQueryHandler(TodoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<TaskDto> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Tasks.FindAsync(request.TaskId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(TaskEntity), request.TaskId);
            }

            return TaskDto.Create(entity);
        }
    }
}
