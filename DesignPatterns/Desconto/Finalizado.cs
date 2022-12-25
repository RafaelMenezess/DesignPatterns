using System;

namespace DesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados nao recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }
    }
}
