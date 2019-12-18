using _4Asset.Application.Interfaces;
using _4Asset.Domain.Interfaces.Services;
using _4Asset.Domain.Models;

namespace _4Asset.Application
{
    public class TarefaAppService : AppServiceBase<Tarefa>, ITarefaAppService
    {
        private readonly ITarefaService _tarefaAppService;

        public TarefaAppService(ITarefaService tarefaAppService) : base(tarefaAppService)
        {
            _tarefaAppService = tarefaAppService;
        }
    }
}
