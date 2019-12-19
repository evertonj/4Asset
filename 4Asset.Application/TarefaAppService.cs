using FourAsset.Application.Interfaces;
using FourAsset.Domain.Interfaces.Services;
using FourAsset.Domain.Models;

namespace FourAsset.Application
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
