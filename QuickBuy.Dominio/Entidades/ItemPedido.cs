﻿
namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (ProdutoId == 0)
                AdicionarMensagem("Atenção,não foi identificado o produto.");

            if (Quantidade == 0)
                AdicionarMensagem("Atenção,não foi informado a quantidade.");
        }
    }
}
