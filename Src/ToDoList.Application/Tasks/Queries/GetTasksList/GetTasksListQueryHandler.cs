using MediatR;

using Microsoft.EntityFrameworkCore;

using ToDoList.Infrastructure.Persistence;

namespace ToDoList.Application.Tasks.Queries.GetTasksList
{
    public class GetTasksListQueryHandler : IRequestHandler<GetTasksListQuery, List<TaskDto>>
    {
        private readonly TodoDbContext _context;

        public GetTasksListQueryHandler(TodoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<TaskDto>> Handle(GetTasksListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Tasks
                .AsNoTracking()
                .Select(t => TaskDto.Create(t))
                .ToListAsync();
        }
    }
}
