

using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

         public ICollection<Pedido> Pedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Email))
                AdicionarMensagem("Atenção,não foi identificado o Email.");

            if (string.IsNullOrEmpty(Senha))
                AdicionarMensagem("Atenção,não foi informado a Senha.");

            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Atenção,não foi informado o Nome.");
        }
    }
}
