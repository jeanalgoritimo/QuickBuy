

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
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Preco))
                AdicionarMensagem("Atenção,não foi identificado o preço.");

            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Atenção,não foi informado o Nome.");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarMensagem("Atenção,não foi informado a Descrição.");
        }
    }
}
