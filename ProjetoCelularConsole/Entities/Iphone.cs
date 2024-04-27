using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCelularConsole.Entities
{
    internal class Iphone : Smartphone
    {
        public Iphone()
        {
        }

        public override void InstalarApp(string nomeApp)
        {
            nomeApp = Console.ReadLine();

            if (ListaApp.Contains(nomeApp))
            {
                Console.WriteLine($"Instalando {nomeApp}...");
                Console.WriteLine($"{nomeApp} foi instalado com sucesso! Você já pode usá-lo.");
            }
            else if (nomeApp == "Chrome" || nomeApp == "Google")
            {
                Console.WriteLine("Desculpe, esse app não está disponível em sistemas Iphone");
            }
            else
            {
                Console.WriteLine("Desculpe, não encontramos esse app...");
            }
        }
    }
}
