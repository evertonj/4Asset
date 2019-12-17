using System;

namespace _4Asset.Domain.Models
{
    public class Tarefa
    {
        public string Titulo { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeEdicao { get; set; }
        public DateTime DataDeRemocao { get; set; }
        public DateTime DataDeConclusao { get; set; }
    }
}
