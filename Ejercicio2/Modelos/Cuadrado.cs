using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Cuadrado : Rectangulo
    {
        public int Lado { get; set; }
        public Cuadrado(int lado) : base(lado,lado)
        {
            this.Lado = lado;
        }


        public override double CalcularArea()
        {
            double area = Convert.ToDouble(Lado) * Convert.ToDouble(Lado);
            return area;
        }
        public override string Describir()
        {
            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Lado"": {this.Lado},
    ""Area"": {CalcularArea()}
}}";
        }
    }
}
