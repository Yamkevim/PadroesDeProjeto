using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.ComPadrao
{
    public interface IEnviarMensagem
    {
        void Enviar(List<Mensagem> mensagens);
        IEnviarMensagem CriarEnvio(string tipo);
        IEnviarMensagem ProximoEnvio { get; set; }
    }
}
