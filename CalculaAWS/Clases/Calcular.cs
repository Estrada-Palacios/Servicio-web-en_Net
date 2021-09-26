using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculaAWS.Clases
{
    public class Calcular
    {
        public decimal Lado1 { get; set; }
        public decimal Lado2 { get; set; }
        public double Radio1 { get; set; }

        public decimal Cuadrado() 
        {
            return Lado1 * Lado2;
        }

        public decimal Triangulo(decimal BaseA1, decimal AlturaB2)
        {
            Lado1 = BaseA1;
            Lado2 = AlturaB2;
            return BaseA1 * AlturaB2 / 2;
        }

        public double Circulo(double Radio)
        {
            double pi = 3.1416;
            Radio1 = Radio;
            return (Radio * Radio) * pi;

        }
    }
}