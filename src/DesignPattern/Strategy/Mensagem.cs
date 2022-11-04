using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class Mensagem
    {
        public Mensagem(string destino, string texto)
        {
            Destino = destino;
            Texto = texto;
        }

        public string Destino{ get; set; }
        public string Texto { get; set; }
    }
}
