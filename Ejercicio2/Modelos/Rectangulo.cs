using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Modelos;

namespace WindowsFormsApp1.Modelos
{
    public class Rectangulo :FiguraPlana
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public Rectangulo(double ancho, double largo)
        {
            Ancho = ancho;
            Largo = largo;
        }


        public override double CalcularArea()
        {
            double area = Convert.ToDouble(Ancho)* Convert.ToDouble(Largo);
            return area;
        }
        public override string Describir() {
            string soy = (Ancho == Largo) ? "Cuadrado" : "Rectangulo";


            return $@"{{
    ""Tipo"": ""{soy}"",
    ""Ancho"": {Ancho},
    ""Largo"": {Largo},
    ""Area"": {CalcularArea()}
}}";

        }

    }
}
