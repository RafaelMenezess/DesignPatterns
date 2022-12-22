using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCaculo(orcamento, icms);
            calculador.RealizaCaculo(orcamento, iss);

            Console.ReadKey();
        }
    }
}
