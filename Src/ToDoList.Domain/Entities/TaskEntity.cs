using ToDoList.Domain.ValueObjects;

namespace ToDoList.Domain.Entities
{
    public class TaskEntity
    {
        /// <summary>
        /// Id задачи
        /// </summary>
        public Guid Id { get;  set; }

        /// <summary>
        /// Название задачи
        /// </summary>
        public string Title { get;  set; }

        /// <summary>
        /// Выполнение задачи
        /// </summary>
        public bool IsCompleted { get;  set; }

        /// <summary>
        /// Планируемая дата выполнения
        /// </summary>
        public DateTime PlannedDate { get;  set; }

        /// <summary>
        /// Конечная дата выполнения
        /// </summary>
        public DateTime FinalDate { get;  set; }

        /// <summary>
        /// Приоритет задачи
        /// </summary>
        public Priority Priority { get;  set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get;  set; } 
    }
}
