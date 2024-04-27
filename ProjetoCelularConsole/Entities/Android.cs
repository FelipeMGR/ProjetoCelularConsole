using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCelularConsole.Entities
{
    internal class Android : Smartphone
    {
        public Android()
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
            else
            {
                Console.WriteLine("Desculpe, não encontramos esse app...");
            } 
        }
    }
}
