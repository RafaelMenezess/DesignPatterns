using System;

namespace DesignPatterns
{
    public class EnviadorEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("email");
        }
    }
}
