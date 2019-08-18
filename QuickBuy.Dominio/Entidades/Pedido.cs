using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }

        public FormaPagamento formaPagamento { get; set; }
        public ICollection<ItemPedido> ItemPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!ItemPedido.Any())
                AdicionarMensagem("Item de pedido não pode estar vazio!");

            if (string.IsNullOrEmpty(Cep))
                AdicionarMensagem("Cep não pode ser vazio!");

            if (FormaPagamentoId==0)
                AdicionarMensagem("Não foi informado a forma de pagamento!");
        }
    }
}
