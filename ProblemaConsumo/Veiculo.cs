namespace ProblemaConsumo
{
    public class Veiculo
    {
        public double DistanciaKM { get; set; }
        public double ConsumoCombustivel { get; set; }

        public Veiculo ( double distanciaKM, double consumoCombustivel )
        {
            DistanciaKM = distanciaKM;
            ConsumoCombustivel = consumoCombustivel;
        }

        public double CalcularConsumoMedio ()
        {
            return DistanciaKM / ConsumoCombustivel;
        }
    }
}
