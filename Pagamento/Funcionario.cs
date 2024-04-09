namespace Pagamento
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public Funcionario ( string nome )
        {
            Nome = nome;
        }

        public double CalcularPagamento(double valorPorHora, int horaTrabalhada )
        {
            return valorPorHora * horaTrabalhada;
        }
    }
}
