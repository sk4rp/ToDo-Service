using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.ValueObjects;

namespace ToDoList.Application.Common.Models
{
    /// <summary>
    /// Тело запроса на создание задачи
    /// </summary>
    public class CreateTaskModel
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Начальная дата
        /// </summary>
        public DateTime PlannedDate { get; set; }

        /// <summary>
        /// Итоговая дата
        /// </summary>
        public DateTime FinalDate { get; set; }

        /// <summary>
        /// Приоритет
        /// </summary>
        public Priority Priority { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
