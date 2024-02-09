using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.ValueObjects;

namespace ToDoList.Application.Common.Models
{
    /// <summary>
    /// Тело запроса на получение конкретной задачи
    /// </summary>
    public class GetTaskModel
    {
        /// <summary>
        /// ID задачи для получения
        /// </summary>
        public Guid TaskId { get; set; }
    }
}
