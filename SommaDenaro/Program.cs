using System;

namespace SommaDenaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il valore del denaro");
            double valore = double.Parse(Console.ReadLine());
            double imposta;
            if (valore <= 5000)
            {
                imposta = (valore * 5) / 100;
            }
            else if (valore >= 5001 && valore <= 15000)
            {
                imposta = (valore * 8) / 100;
            }
            else if (valore >= 15001 && valore <= 35000)
            {
                imposta = (valore * 24) / 100;
            }
            else
            {
                imposta = (valore * 36) / 100;
            }
            Console.WriteLine($"la somma di denaro totale è {imposta}");
            Console.ReadLine();
        }
    }
}
