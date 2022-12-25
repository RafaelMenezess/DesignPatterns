using System;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCaculo(Orcamento orcamento, Imposto imposto)
        {
            double calculoImposto = imposto.Calcula(orcamento);
            Console.WriteLine(calculoImposto);
        }
    }
}
