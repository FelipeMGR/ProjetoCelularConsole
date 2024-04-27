using System;
using ProjetoCelularConsole.Entities;
using System.Globalization;

namespace CelularConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Android android = new Android();
            Iphone ios = new Iphone();

            Console.Write("Informe o sistema de seu dispositivo (Android ou IOS): ");
            string sistema = Console.ReadLine();

            if (sistema == "Android")
            {
                android.Cadastro();
                Console.Write("Qual aplicativo deseja instalr? ");
                string app = Console.ReadLine();
                android.InstalarApp(app);
            } 
            else if (sistema == "IOS") {
                ios.Cadastro();
                Console.Write("Qual app deseja instalar? ");
                string app = Console.ReadLine();
                ios.InstalarApp(app);
            }
        }
    }
}