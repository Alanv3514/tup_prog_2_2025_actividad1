using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Ortoedro
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


        public double calcularArea()
        {
            double areaTotal = 0;

            for (int i = 0; i < 4; i++)
            {
                areaTotal += laterales[i].calcularArea();
            }

            for (int i = 0; i < 2; i++)
            {
                areaTotal += bases[i].calcularArea();
            }

            return areaTotal;
        }
        public double calcularVolumen()
        {
         double volumen = 0;
            double base1 = bases[0].calcularArea();
            double altura = laterales[0].Largo;

            volumen = bases[0].calcularArea()* laterales[0].Largo;
            return volumen;

        }
        public string describir()
        { 

            return $@"{{
    ""Tipo"": ""{this.GetType().Name}"",
    ""Laterales"": 
        [
        {laterales[0].describir()},
        {laterales[1].describir()},
        {laterales[2].describir()},
        {laterales[3].describir()}
        ],
    ""Bases"": 
        [
        {bases[0].describir()},
        {bases[1].describir()}
        ],
    ""Area"": {calcularArea()},
    ""Volumen"": {calcularVolumen()}
}}";
        }
    }
}
