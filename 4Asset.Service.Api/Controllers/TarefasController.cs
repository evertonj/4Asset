using FourAsset.Application.Interfaces;
using FourAsset.Domain.Models;
using FourAsset.Service.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FourAsset.Service.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaAppService _tarefaAppService;
        public TarefasController(ITarefaAppService tarefaAppService)
        {
            _tarefaAppService = tarefaAppService;
        }

        // GET api/tarefas
        [HttpGet]
        public ActionResult<string> Get()
        {
            var tarefas = _tarefaAppService.GetAll();

            if (tarefas == null)
                return NotFound();

            return Ok(tarefas);
        }

        // GET api/tarefas/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var tarefa = _tarefaAppService.GetById(id);

            if (tarefa == null)
                return NotFound();

            return Ok(tarefa);
        }

        // POST api/tarefas
        [HttpPost]
        public ActionResult<Tarefa> Post([FromBody] TarefaDto value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var tarefa = new Tarefa(value.Titulo, value.Descricao, value.Status);
            _tarefaAppService.Add(tarefa);

            return Ok(tarefa);
        }

        // PUT api/tarefas/5
        [HttpPut("{id}")]
        public ActionResult<Tarefa> Put(int id, [FromBody] Tarefa value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var getById = _tarefaAppService.GetById(id);
            if (getById == null)
                return BadRequest();

            getById.Titulo = value.Titulo;
            getById.Descricao = value.Descricao;
            getById.Status = value.Status;
            _tarefaAppService.Update(getById);

            return Ok(getById);
        }

        // DELETE api/tarefas/5
        [HttpDelete("{id}")]
        public ActionResult<Tarefa> Delete(int id)
        {
            var getById = _tarefaAppService.GetById(id);

            if (getById == null)
                return BadRequest();

            _tarefaAppService.Remove(getById);

            return Ok(getById);
        }
    }
}
