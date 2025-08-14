using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Cuadrado
    {
        private int Lado { get; set; }
        public Cuadrado(int lado)
        {
            Lado = lado;
        }


        public double calcularArea()
        {
            double area = Convert.ToDouble(Lado) * Convert.ToDouble(Lado);
            return area;
        }
        public string describir()
        {
            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Lado"": {this.Lado},
    ""Area"": {calcularArea()}
}}";
        }
    }
}
