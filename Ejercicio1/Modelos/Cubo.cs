using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Cubo
    {
        private Cuadrado[] caras = new Cuadrado[6];

        public Cubo(int lado)
        {
            for (int i = 0; i < 6; i++)
            {
                this.caras[i] = new Cuadrado(lado);
            }

        }


        public double calcularArea()
        {
            double areaTotal = 0;

            areaTotal = this.caras[0].calcularArea()*6;

            return areaTotal;
        }
        public double calcularVolumen()
        {
            double volumen = this.caras[0].Lado * this.caras[0].Lado * this.caras[0].Lado;
            return volumen;

        }
        public string describir()
        {

            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Caras"": 
        [
        {this.caras[0].describir()},
        {this.caras[1].describir()},
        {this.caras[2].describir()},
        {this.caras[3].describir()},
        {this.caras[4].describir()},
        {this.caras[5].describir()}
        ],
    ""Area"": {this.calcularArea()},
    ""Volumen"": {this.calcularVolumen()}
}}";
        }
    }
}
