using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class Item
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        
        [Display(Name = "Preço")]
        public double Price { get; set; }
        
        [Display(Name = "Percentual")]
        public int Percentual { get; set; }
        
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }
        
        [Display(Name = "Produto")]
        public Produto? Product { get; set; }
    }
}