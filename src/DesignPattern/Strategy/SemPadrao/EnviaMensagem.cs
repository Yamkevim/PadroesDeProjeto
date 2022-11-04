using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.SemPadrao
{
    public class EnviaMensagem
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            if (tipo.ToLower() == "email")
            {
                Console.WriteLine("Email enviado");
            }
            if (tipo.ToLower() == "sms")
            {
                Console.WriteLine("Sms Enviado");
            }
            if (tipo.ToLower() =="push")
            {
                Console.WriteLine("Push Enviado");
            }
/* Implementação de condicional com swith
 * 
            switch (tipo.ToLower())
            {
                case "sms":
                    Console.WriteLine();
                break;

                case "email":
                    Console.WriteLine("Email enviado");
                break;
                case "push":
                    Console.WriteLine("Push Enviado!");
                break ;

                default:
                    break;
                }
*/
            
        }
    }
}
