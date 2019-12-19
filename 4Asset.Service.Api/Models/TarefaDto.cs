using System.ComponentModel.DataAnnotations;

namespace FourAsset.Service.Api.Models
{
    public class TarefaDto
    {
        public int TarefaId { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
    }
}
