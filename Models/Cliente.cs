using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class Cliente
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
    }
}