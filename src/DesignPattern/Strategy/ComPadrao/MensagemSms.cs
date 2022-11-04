using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.ComPadrao
{
    public class MensagemSms : IEnviarMensagem
    {
        public void Enviar(List<Mensagem> mensagens)
        {
            Console.WriteLine("Sms enviado");
        }
    }
}
