namespace CM_Tecnologia.FigurasGeometricas
{
    public class Quadrado : CalcularArea
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public override double calculaArea()
        {
            return lado * lado;
        }
    }
}