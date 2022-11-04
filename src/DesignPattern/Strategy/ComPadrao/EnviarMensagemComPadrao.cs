using DesignPattern.Strategy.SemPadrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.ComPadrao
{
    public class EnviarMensagemComPadrao
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            IEnviarMensagem enviaMensagem;
            if (tipo.ToLower() == "email")
            {
                enviaMensagem = new MensagemEmail();
                enviaMensagem.Enviar(mensagens);
            }
            if (tipo.ToLower() == "sms")
            {
                enviaMensagem = new MensagemSms();
                enviaMensagem.Enviar(mensagens);
            }
            if (tipo.ToLower() == "push")
            {
                enviaMensagem = new MensagemPush();
                enviaMensagem.Enviar(mensagens);
            }
        }
    }
}
