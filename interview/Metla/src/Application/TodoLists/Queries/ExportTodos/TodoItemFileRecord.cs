using Metla.Application.Common.Mappings;
using Metla.Domain.Entities;

namespace Metla.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
