using MediatR;

namespace ToDoList.Application.Tasks.Queries.GetTask
{
    public class GetTaskQuery : IRequest<TaskDto>
    {
        public GetTaskQuery(Guid taskId)
        {
            TaskId = taskId;
        }

        public Guid TaskId { get; }
    }
}
