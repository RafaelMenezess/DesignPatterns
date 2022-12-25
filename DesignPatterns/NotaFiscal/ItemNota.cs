namespace DesignPatterns
{
    public class ItemNota
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public ItemNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
