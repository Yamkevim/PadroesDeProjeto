using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.ComPadrao
{
    public class MensagemPush : IEnviarMensagem
    {
        public IEnviarMensagem ProximoEnvio { get ; set ; }

        public IEnviarMensagem CriarEnvio(string tipo)
        {
            if (tipo != "push")
            {
                return ProximoEnvio.CriarEnvio(tipo);
            }
            return this;
        }
        public void Enviar(List<Mensagem> mensagens)
        {
            Console.WriteLine("Push enviado");
        }
    }
}
