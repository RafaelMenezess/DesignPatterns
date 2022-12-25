using System;

namespace DesignPatterns
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("bd");
        }
    }
}
