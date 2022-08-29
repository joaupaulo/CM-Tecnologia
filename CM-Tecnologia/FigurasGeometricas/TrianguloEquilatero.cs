namespace CM_Tecnologia.FigurasGeometricas
{
    public class TrianguloEquilatero : CalcularArea
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double calculaArea => (this.Base * this.Altura) / 2;
    }
}