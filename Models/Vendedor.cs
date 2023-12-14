using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class Vendedor
    {
        [Display(Name = "Código"), Key()]
        public int Id {get; set;}
        
        [Display(Name = "Nome")]
        public string? Name {get; set;}
    }
}