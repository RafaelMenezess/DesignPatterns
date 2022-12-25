using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();

            //Orcamento orcamento = new Orcamento(500.0);

            //double valor = iss.Calcula(orcamento);
            //Console.WriteLine(valor);
            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCaculo(orcamento, icms);
            //calculador.RealizaCaculo(orcamento, iss);

            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(500);
            //orcamento.AdicionaItem(new Item("Caneta", 250));
            //orcamento.AdicionaItem(new Item("Lapis", 250));
            //orcamento.AdicionaItem(new Item("Geladeira", 250));
            ////orcamento.AdicionaItem(new Item("Fogao", 250));
            ////orcamento.AdicionaItem(new Item("TV", 250));
            ////orcamento.AdicionaItem(new Item ("PC", 250));

            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto);

            //Orcamento reforma = new Orcamento(500);
            //Console.WriteLine(reforma.Valor);
            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Aprova();

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Finaliza();
            //reforma.AplicaDescontoExtra();

            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Caelum")
                .ComCnpj("23.456.789/0001-12")
                .comItem(new ItemNota("item 1", 100))
                .comItem(new ItemNota("item 2", 200))
                .DataAtual()
                .ComObservacoes("obs obs");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);


            Console.ReadKey();
        }
    }
}
