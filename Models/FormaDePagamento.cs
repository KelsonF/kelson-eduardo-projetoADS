using System.ComponentModel.DataAnnotations;

namespace Projeto_Otilio.Models
{
    public class FormaDePagamento
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        
        [Display(Name = "Nome do Cobrado")]
        public string? NomeDoCobrado { get; set; }
        
        [Display(Name = "Informações Adicionais")]
        public string? InformacoesAdicionais { get; set; }
    }
}