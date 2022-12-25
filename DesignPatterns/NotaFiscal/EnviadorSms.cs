using System;

namespace DesignPatterns
{
    public class EnviadorSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("sms");
        }
    }
}
