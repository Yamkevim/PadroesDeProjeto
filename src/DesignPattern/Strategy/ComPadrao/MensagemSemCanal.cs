using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.ComPadrao
{
    public class MensagemSemCanal : IEnviarMensagem
    {
        public IEnviarMensagem ProximoEnvio { get ; set; }

        public IEnviarMensagem CriarEnvio(string tipo)
        {
            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            Console.WriteLine("Mensagem sem canal Ativo!");
        }
    }
}
