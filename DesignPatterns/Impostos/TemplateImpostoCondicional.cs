namespace DesignPatterns
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        protected TemplateImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {
        }

        public abstract bool UsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);

        public override double Calcula(Orcamento orcamento)
        {
            if (UsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);

            }
            return MinimaTaxacao(orcamento);
        }
    }
}
