using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Circulo
    {
        public double Radio { get; set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double calcularArea()
        {
            double area = 2*Math.PI *this.Radio * this.Radio;
            return area;
        }
        public string describir()
        {
            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Radio"": {Radio},
    ""Area"": {calcularArea()}
}}";
        }
    }
}
