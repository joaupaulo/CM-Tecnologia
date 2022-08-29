namespace CM_Tecnologia.FigurasGeometricas
{
    public class Quadrado : CalcularArea
    {
        public double lado { get; set; }

        public override double calculaArea => this.lado * this.lado;
    }
}