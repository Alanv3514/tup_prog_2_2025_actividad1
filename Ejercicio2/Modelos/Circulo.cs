using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio2.Modelos;

namespace WindowsFormsApp1.Modelos
{
    public class Circulo :FiguraPlana
    {
        private System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.InvariantCulture;
        public double Radio { get; set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            double area = 2*Math.PI *this.Radio * this.Radio;
            return area;
        }
        public override string Describir()
        {
            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Radio"": {Radio},
    ""Area"": {CalcularArea().ToString("F2",culture)}
}}";
        }
    }
}
