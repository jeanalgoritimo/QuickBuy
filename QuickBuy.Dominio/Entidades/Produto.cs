﻿

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public string Preco { get; set; }

        public string Nome { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
