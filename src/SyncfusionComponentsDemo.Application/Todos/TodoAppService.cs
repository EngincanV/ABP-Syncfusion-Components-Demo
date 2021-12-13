using System.Collections.Generic;
using Volo.Abp.Application.Services;

namespace SyncfusionComponentsDemo.Todos;

public class TodoAppService : ApplicationService, ITodoAppService
{
    private readonly List<Todo> _todos = new List<Todo>
    {
        new Todo(id: 1, title: "Todo 1", isCompleted: false),
        new Todo(id: 2, title: "Todo 2", isCompleted: false),
        new Todo(id: 3, title: "Todo 3 - completed", isCompleted: true),
        new Todo(id: 4, title: "Todo 4 - completed", isCompleted: true),
    };
    
    public List<Todo> GetTodos()
    {
        return _todos;
    }
}