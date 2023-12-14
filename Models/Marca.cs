using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class Marca
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
       
        [Display(Name = "Nome")]
        public string? Name { get; set; }
        
        [Display(Name = "Descrição")]
        public string? Description { get; set; }
        
        [Display(Name = "Produtos")]
        public ICollection<Produto>? Products { get; set; }
    }
}