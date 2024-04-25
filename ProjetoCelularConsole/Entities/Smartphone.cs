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




        public Smartphone (string user, int phoneNumber, string modelo, string imei, int memoria)
        {
            User = user;
            PhoneNumber = phoneNumber;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar(int number)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ligando para {number}");
        }
    }
}
