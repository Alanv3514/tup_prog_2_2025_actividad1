using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio2.Modelos;

namespace WindowsFormsApp1.Modelos
{
     public class RectanguloDesarrollado : Rectangulo

    {

        private System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.InvariantCulture;

        public RectanguloDesarrollado(double radio, double largo):base(radio * radio * Math.PI * 2, largo)
        {
            Ancho = radio*radio* Math.PI * 2;
            Largo = largo;
        }


        public override double CalcularArea()
        {
            double area = Convert.ToDouble(Ancho) * Convert.ToDouble(Largo);
            return area;
        }
        public override string Describir()
        {
            string soy = (Ancho == Largo) ? "Cuadrado Desarrollado" : "Rectangulo Desarrollado";

            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Lago"": {Largo.ToString( culture)},
    ""Ancho"": {Ancho.ToString( culture)},
    ""Area"": {CalcularArea().ToString("F2", culture)}
}}";
        }

    }
}
