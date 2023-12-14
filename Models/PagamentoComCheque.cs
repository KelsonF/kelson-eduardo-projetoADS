using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class PagamentoComCheque : FormaDePagamento
    {
        [Display(Name = "Número do Cheque")]
        public int Bank { get; set; }
        [Display(Name = "Nome do Banco")]
        public string? BankName { get; set; }  
    }
}