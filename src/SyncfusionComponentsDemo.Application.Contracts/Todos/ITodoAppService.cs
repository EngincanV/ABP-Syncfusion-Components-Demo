using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SyncfusionComponentsDemo.Todos;

public interface ITodoAppService : IApplicationService
{
    List<Todo> GetTodos();
}