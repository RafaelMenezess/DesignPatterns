namespace DesignPatterns
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}
