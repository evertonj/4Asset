using FourAsset.Domain.Interfaces.Repositories;
using FourAsset.Domain.Interfaces.Services;
using FourAsset.Domain.Models;

namespace FourAsset.Domain.Services
{
    public class TarefaService : ServiceBase<Tarefa>, ITarefaService
    {
        public TarefaService(IRepositoryBase<Tarefa> repositoryBase) : base(repositoryBase)
        {
        }
    }
}
