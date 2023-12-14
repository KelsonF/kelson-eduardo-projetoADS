using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class Transportadora
    {
        [Display(Name = "Código")]
        public int Id {get; set;}        

        [Display(Name = "Nome")]
        public string? Name {get; set;}
    }
}