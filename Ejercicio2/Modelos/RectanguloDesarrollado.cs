using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
     public class RectanguloDesarrollado 

    {

        private System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.InvariantCulture;
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public RectanguloDesarrollado(double radio, double largo)
        {
            Ancho = radio*radio* Math.PI * 2;
            Largo = largo;
        }


        public double calcularArea()
        {
            double area = Convert.ToDouble(Ancho) * Convert.ToDouble(Largo);
            return area;
        }
        public string describir()
        {
            string soy = (Ancho == Largo) ? "Cuadrado Desarrollado" : "Rectangulo Desarrollado";

            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Lago"": {Largo.ToString( culture)},
    ""Ancho"": {Ancho.ToString( culture)},
    ""Area"": {calcularArea().ToString("F2", culture)}
}}";
        }

    }
}
