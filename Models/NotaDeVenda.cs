using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Otilio.Models
{
    public class NotaDeVenda
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }

        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Display(Name = "Tipo")]
        public bool Type { get; set; }

        public Cliente Client { get; set; } = null!;

        [Display(Name = "Cliente"), ForeignKey("Cliente")]
        public int? ClienteId { get; set; }

        public Vendedor Seller { get; set; } = null!;

        [Display(Name = "Vendedor"), ForeignKey("Vendedor")]
        public int? SellerId { get; set; }

        public Transportadora Transportadora { get; set; } = null!;

        [Display(Name = "Transportadora"), ForeignKey("Transportadora")]
        public int? TransportadoraId { get; set; }

        public FormaDePagamento? PaymentType { get; set; }

        [Display(Name = "Tipo de Pagamento"), ForeignKey("TipoDePagamento")]
        public int? TipoDePagamentoId { get; set; }

        public ICollection<Item>? Itens { get; set; }

        public ICollection<Pagamento>? Payments { get; set; }
        
        public void Cancelar()
        {
            if (this.Type == true)
            {
                throw new Exception("Nota de Venda já cancelada!");
            }
            else
            {
                this.Type = true;
            }
        }

        public void Devolver() 
        {
            if (this.Type == false)
            {
                throw new Exception("Nota de Venda já devolvida!");
            }
            else
            {
                this.Type = false;
            }
        }
    }
}