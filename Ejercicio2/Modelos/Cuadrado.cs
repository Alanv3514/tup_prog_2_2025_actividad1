using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Cuadrado
    {
        public int Lado { get; set; }
        public Cuadrado(int lado)
        {
            this.Lado = lado;
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
