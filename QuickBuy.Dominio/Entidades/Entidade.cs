using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }

        protected List<string> MensagemValidacao { 
            get { 
                   return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
                }

        public abstract void Validate();

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
