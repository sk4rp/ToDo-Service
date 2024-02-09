using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.Common.Models;
using ToDoList.Application.Tasks.Commands.CreateTask;
using ToDoList.Application.Tasks.Commands.DeleteTask;
using ToDoList.Application.Tasks.Commands.UpdateTask;
using ToDoList.Application.Tasks.Queries;
using ToDoList.Application.Tasks.Queries.GetTask;
using ToDoList.Application.Tasks.Queries.GetTasksList;

namespace ToDoList.Controllers
{
    public class TasksController : BaseApiController
    {
        /// <summary>
        /// Получение всех задач
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<TaskDto>>> GetAll()
        {
            var result = await Mediator.Send(new GetTasksListQuery());
            return new JsonResult(result);
        }

        /// <summary>
        /// Получение конкретной задачи
        /// </summary>
        /// <param name="TaskId">ID задачи</param>
        [HttpGet("{TaskId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetTask([FromRoute] GetTaskModel model)
        {
            var result = await Mediator.Send(new GetTaskQuery(
                           taskId: model.TaskId
                           ));
            return new JsonResult(result);
        }

        /// <summary>
        /// Создание задачи
        /// </summary>
        /// <param name="model">Модель команды на создание задачи</param>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Create([FromBody] CreateTaskModel model)
        {
            var id = await Mediator.Send(new CreateTaskCommand(
                          title: model.Title,
                          plannedDate: model.PlannedDate,
                          finalDate: model.FinalDate,
                          priority: model.Priority,
                          description: model.Description
                          ));
            return new JsonResult(id);
        }

        /// <summary>
        /// Удалить задачу
        /// </summary>
        /// <param name="id">ID задачи</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteTaskCommand { Id = id });
            return NoContent();

        }

        /// <summary>
        /// Обновить задачу
        /// </summary>
        /// <param name="model">Модель команды на обновление задачи</param>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody]UpdateTaskModel model)
        {
            await Mediator.Send(new UpdateTaskCommand(
                        taskId: model.TaskId,
                        isCompleted: model.IsCompleted,
                        title: model.Title,
                        priority: model.Priority,
                        plannedDate: model.PlannedDate,
                        finalDate: model.FinalDate,
                        description: model.Description
                        ));
            return Ok();
        }
    }
}