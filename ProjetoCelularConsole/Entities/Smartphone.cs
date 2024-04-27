using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCelularConsole.Entities
{
    public abstract class Smartphone
    {
        public string User { get;set ; }
        private string Modelo { get;set ; }
        public int PhoneNumber { get;set ; }
        private string Imei { get;set ; }
        private int Memoria { get;set ; }
        public List<string> ListaApp { get; set; } = new List<string>
        {
            "WhatsApp",
            "Facebook",
            "Instagram",
            "Twitter",
            "X",
            "Chrome",
            "Spotify",
            "YouTube"
        };

        public Smartphone ()
        {
        }

        public void Ligar(int number)
        {
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ligando para {number}");
        }

        public void RecebendoLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public void Cadastro()
        {
            Console.Write("Nome de usuario: ");
            string user = Console.ReadLine();
            Console.Write("Número de telefone: ");
            double phoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("IMEI: ");
            string imei = Console.ReadLine();
            Console.Write("Tamanho da memória primária: ");
            int memoria = int.Parse(Console.ReadLine());
        }

        public abstract void InstalarApp(string nomeApp);
    }
}
