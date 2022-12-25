namespace DesignPatterns
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override bool UsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
