using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SyncfusionComponentsDemo.Todos;

namespace SyncfusionComponentsDemo.Web.Pages;

public class Todos : PageModel
{
    public List<Todo> TodoItems { get; set; }
    
    private readonly ITodoAppService _todoAppService;

    public Todos(ITodoAppService todoAppService)
    {
        _todoAppService = todoAppService;
    }
    
    public void OnGet()
    {
        TodoItems = _todoAppService.GetTodos();
    }
}