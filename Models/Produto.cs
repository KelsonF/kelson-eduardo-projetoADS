using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class Produto
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Display(Name = "Descriçao")]
        public string? Description { get; set; }

        [Display(Name = "Quantidade")]
        public int Amount { get; set; }

        [Display(Name = "Preço")]
        public double Price { get; set; }

        [Display(Name = "Marca")]
        public Marca? Brand { get; set; }

        [Display(Name = "Itens")]
        public ICollection<Item>? Items {get; set;}
    }
}