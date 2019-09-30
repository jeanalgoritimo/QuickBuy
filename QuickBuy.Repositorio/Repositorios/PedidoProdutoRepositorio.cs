using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class PedidoProdutoRepositorio : BaseRepositorio<Pedido>, IPedidoProdutoRepositorio
    {
        public PedidoProdutoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
