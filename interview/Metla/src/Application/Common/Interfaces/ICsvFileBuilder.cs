using Metla.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Metla.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
