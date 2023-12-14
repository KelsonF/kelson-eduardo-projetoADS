using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class PagamentoComCartao : FormaDePagamento
    {
        [Display(Name = "Numero do cartão")]
        public string? Number { get; set; }

        [Display(Name = "Bandeira do cartão")]
        public string? Brand { get; set; }
    }
}