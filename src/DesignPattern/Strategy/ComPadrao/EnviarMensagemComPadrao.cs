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
            var enviaMensagemEmail = new MensagemEmail();
            var enviaMensagemSms = new MensagemSms();
            var enviaMensagemPush = new MensagemPush();
            var enviaMensagemSemCanal = new MensagemSemCanal();
            enviaMensagemEmail.ProximoEnvio = enviaMensagemSms;
            enviaMensagemSms.ProximoEnvio = enviaMensagemPush;
            enviaMensagemPush.ProximoEnvio = enviaMensagemSemCanal;


            var enviaMensagem = enviaMensagemEmail.CriarEnvio(tipo);
            enviaMensagem.Enviar(mensagens);
        }
    }
}
