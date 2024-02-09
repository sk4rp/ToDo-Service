using FluentValidation;

using ToDoList.Domain.Common;

namespace ToDoList.Application.Tasks.Commands.CreateTask
{
    public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        public CreateTaskCommandValidator()
        {
            RuleFor(x => x.Title).MaximumLength(Constants.TaskTitleMaxLength).NotEmpty();
            RuleFor(x => x.Description).MaximumLength(Constants.TaskDescriptionMaxLength);
        }
    }
}
