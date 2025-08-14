using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Rectangulo
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public Rectangulo(double ancho, double largo)
        {
            Ancho = ancho;
            Largo = largo;
        }


        public double calcularArea()
        {
            double area = Convert.ToDouble(Ancho)* Convert.ToDouble(Largo);
            return area;
        }
        public string describir() {
            string soy = (Ancho == Largo) ? "Cuadrado" : "Rectangulo";


            return $@"{{
    ""Tipo"": ""{soy}"",
    ""Ancho"": {Ancho},
    ""Largo"": {Largo},
    ""Area"": {calcularArea()}
}}";

        }

    }
}
