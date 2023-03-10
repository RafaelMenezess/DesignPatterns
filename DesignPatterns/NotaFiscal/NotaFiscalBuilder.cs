using System.Collections.Generic;
using System;

namespace DesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public IList<ItemNota> todosItens = new List<ItemNota>();
        public DateTime Data { get; private set; }
        public string Observacoes { get; private set; }

        private IList<AcaoAposGerarNota> todasAcoes = new List<AcaoAposGerarNota>();

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);

            foreach (var acao in todasAcoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }
        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            todasAcoes.Add(novaAcao);
        }
        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }
        public NotaFiscalBuilder DataAtual()
        {
            Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder comItem(ItemNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;

            return this;
        }
    }
}
