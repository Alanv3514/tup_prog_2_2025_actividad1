using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Modelos;

namespace WindowsFormsApp1.Modelos
{
    public class Ortoedro :FiguraVolumetrica
    {
        private Rectangulo[] laterales = new Rectangulo[4];
        private Rectangulo[] bases = new Rectangulo[2];

        public Ortoedro(int anchoBase, int ladoComun,int largoLateral)
        {
            for (int i = 0; i < 4; i++) {
                laterales[i]= new Rectangulo(ladoComun, largoLateral);
            }

            for (int i = 0; i < 2; i++)
            {
                bases[i] = new Rectangulo(anchoBase, ladoComun);
            }
        }


        public override double CalcularArea()
        {
            double areaTotal = 0;

            for (int i = 0; i < 4; i++)
            {
                areaTotal += laterales[i].CalcularArea();
            }

            for (int i = 0; i < 2; i++)
            {
                areaTotal += bases[i].CalcularArea();
            }

            return areaTotal;
        }
        public override double CalcularVolumen()
        {
         double volumen = 0;
            double base1 = bases[0].CalcularArea();
            double altura = laterales[0].Largo;

            volumen = bases[0].CalcularArea()* laterales[0].Largo;
            return volumen;

        }
        public override string Describir()
        { 

            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Laterales"": 
        [
        {laterales[0].Describir()},
        {laterales[1].Describir()},
        {laterales[2].Describir()},
        {laterales[3].Describir()}
        ],
    ""Bases"": 
        [
        {bases[0].Describir()},
        {bases[1].Describir()}
        ],
    ""Area"": {CalcularArea()},
    ""Volumen"": {CalcularVolumen()}
}}";
        }
    }
}
