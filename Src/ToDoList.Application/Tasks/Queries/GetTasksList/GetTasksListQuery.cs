using MediatR;

namespace ToDoList.Application.Tasks.Queries.GetTasksList
{
    public class GetTasksListQuery : IRequest<List<TaskDto>>
    {
    }
}
