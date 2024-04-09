namespace Troco
{
    public class Produto
    {
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public Produto ( double precoUnitario, int quantidade )
        {
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        public double CalcularTroco(double dinheiroRecebido )
        {
            double totalCompra = PrecoUnitario * Quantidade ;
            return dinheiroRecebido - totalCompra;
        }
    }
}
