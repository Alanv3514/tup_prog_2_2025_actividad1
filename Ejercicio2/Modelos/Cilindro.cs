using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Modelos;

namespace WindowsFormsApp1.Modelos
{
    public class Cilindro : FiguraVolumetrica
    {
        private System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.InvariantCulture;
        private Circulo[] tapas = new Circulo[2];
        private RectanguloDesarrollado rectanguloDesarrollado;

        public Cilindro(double radio, double altura)
        {
            

            for (int i = 0; i < 2; i++)
            {
                tapas[i] = new Circulo(radio);
            }
            rectanguloDesarrollado = new RectanguloDesarrollado(radio,altura);


        }


        public override double CalcularArea()
        {
            double areaTotal = 0;

            for (int i = 0; i < 2; i++)
            {
                areaTotal += tapas[i].CalcularArea();
            }
            areaTotal += rectanguloDesarrollado.CalcularArea();
            return areaTotal;
        }
        public override double CalcularVolumen()
        {
            return tapas[0].CalcularArea() * rectanguloDesarrollado.Largo;
        }
        public override string Describir()
        {

            return $@"{{
  ""Tipo"": ""{this.GetType().Name}"",
  ""Tapas"": [{tapas[0].Describir()},{tapas[1].Describir()}],
  ""Largo"": {rectanguloDesarrollado.Describir()},
  ""Area"": {CalcularArea().ToString("F2", culture)},
  ""Volumen"": {CalcularVolumen().ToString("F2", culture)}
}}"; 
        }
    }
}
