using System;

namespace CM_Tecnologia.FigurasGeometricas
{
    public class Circulo : CalcularArea
    {
        public double raio { get; set; }

        public override double calculaArea => Math.Pow(this.raio, 2) * Math.PI;

    }
}