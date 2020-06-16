using System.Collections.Generic;
using System.Linq;

namespace FastBuy.Dominio.Entidades
{
   public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);

        }

        public abstract void Validade();


        protected bool EhValido
        {
            get { return !mensagemValidacao.Any();}
        }
    }
}
