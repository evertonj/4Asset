using System;

namespace FourAsset.Domain.Models
{
    public class Tarefa
    {
        public Tarefa()
        {
            DataDeCriacao = DateTime.Now;
        }
        public Tarefa(string titulo, string descricao, bool status)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Status = status;
            DataDeCriacao = DateTime.Now;
        }

        public int TarefaId { get; set; }
        public string Titulo { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeEdicao { get; set; }
        public DateTime DataDeRemocao { get; set; }
        public DateTime DataDeConclusao { get; set; }
    }
}
