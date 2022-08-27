using System;

namespace CM_Tecnologia.FigurasGeometricas
{
    public class Circulo : CalcularArea
    {
        private double raio;

        public  Circulo(double raio)
        {
            this.raio = raio;
        }

        public override double calculaArea()
        {
            return Math.PI * (raio * raio);
        }
    }
}