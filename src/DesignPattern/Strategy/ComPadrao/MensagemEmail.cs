﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.ComPadrao
{
    public class MensagemEmail : IEnviarMensagem
    {
        public void Enviar(List<Mensagem> mensagens)
        {
            Console.WriteLine("Email enviado");
        }
    }
}
