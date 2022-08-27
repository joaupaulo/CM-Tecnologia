using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Tecnologia.FigurasGeometricas
{
   public class TrianguloEquilatero : CalcularArea
    {
        private double Base;
        private double Altura;

        public TrianguloEquilatero(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public override double calculaArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
