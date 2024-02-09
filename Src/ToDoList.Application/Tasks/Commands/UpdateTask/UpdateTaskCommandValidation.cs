using FluentValidation;

using ToDoList.Domain.Common;

namespace ToDoList.Application.Tasks.Commands.UpdateTask
{
    public class UpdateTaskCommandValidation : AbstractValidator<UpdateTaskCommand>
    {
        public UpdateTaskCommandValidation()
        {
            RuleFor(x => x.Title).MaximumLength(Constants.TaskTitleMaxLength).NotEmpty();
            RuleFor(x => x.Description).MaximumLength(Constants.TaskDescriptionMaxLength);
        }
    }
}
