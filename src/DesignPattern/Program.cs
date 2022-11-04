using DesignPattern.Strategy;
using DesignPattern.Strategy.ComPadrao;
using DesignPattern.Strategy.SemPadrao;
using System;
using System.Collections.Generic;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagens = new List<Mensagem>();
            mensagens.Add(new Mensagem("teste@teste.com", "Teste Efetuado!"));
            mensagens.Add(new Mensagem("teste@teste2.com", "Teste2 Efetuado!"));
            mensagens.Add(new Mensagem("teste@teste3.com", "Teste2 Efetuado!"));
            var enviaMensagem = new EnviarMensagemComPadrao();
            enviaMensagem.Enviar(mensagens, "email");
            Console.ReadKey();
        }
    }
}

