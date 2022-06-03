using System;
using System.Diagnostics;
using System.Threading;
using System.Linq;

namespace searchBar
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\n ###################### \n");
            Console.WriteLine("        SearchBar   ");
            Console.WriteLine("\n ###################### \n");


            Console.WriteLine("\n ------------------ \n");
            string[] palavras = { "week", "database", "army", "story", "assumption", "innocent", "messy", "dusty", "icy", "keen" };
            List<string> lista = palavras.ToList();

            Console.WriteLine(String.Join("\n", lista));
            Console.WriteLine("\n ------------------ \n");

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Ordenar Lista");
            Console.WriteLine("0 - Sair");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\n ------------------ \n");
                    lista.Sort();
                    Console.WriteLine(String.Join("\n", lista));
                    Console.WriteLine("\n ------------------ \n");
                    break;

                case "0":
                    Environment.Exit(0);
                    break;
            }

        }

    }
}