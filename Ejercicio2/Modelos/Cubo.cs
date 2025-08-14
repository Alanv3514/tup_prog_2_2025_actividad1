using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Cubo : Ortoedro
    {
        private Cuadrado[] caras = new Cuadrado[6];

        public Cubo(int lado) : base(lado,lado,lado)
        {
            for (int i = 0; i < 6; i++)
            {
                this.caras[i] = new Cuadrado(lado);
            }

        }


        public override double CalcularArea()
        {
            double areaTotal = 0;

            areaTotal = this.caras[0].CalcularArea()*6;

            return areaTotal;
        }
        public override double CalcularVolumen()
        {
            double volumen = this.caras[0].Lado * this.caras[0].Lado * this.caras[0].Lado;
            return volumen;

        }
        public override string Describir()
        {

            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Caras"": 
        [
        {this.caras[0].Describir()},
        {this.caras[1].Describir()},
        {this.caras[2].Describir()},
        {this.caras[3].Describir()},
        {this.caras[4].Describir()},
        {this.caras[5].Describir()}
        ],
    ""Area"": {this.CalcularArea()},
    ""Volumen"": {this.CalcularVolumen()}
}}";
        }
    }
}
