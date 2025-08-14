using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Cilindro
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


        public double calcularArea()
        {
            double areaTotal = 0;

            for (int i = 0; i < 2; i++)
            {
                areaTotal += tapas[i].calcularArea();
            }
            areaTotal += rectanguloDesarrollado.calcularArea();
            return areaTotal;
        }
        public double calcularVolumen()
        {
            return tapas[0].calcularArea() * rectanguloDesarrollado.Largo;
        }
        public string describir()
        {

            return $@"{{
  ""Tipo"": ""{this.GetType().Name}"",
  ""Tapas"": [{tapas[0].describir()},{tapas[1].describir()}],
  ""Largo"": {rectanguloDesarrollado.describir()},
  ""Area"": {calcularArea().ToString("F2", culture)},
  ""Volumen"": {calcularVolumen().ToString("F2", culture)}
}}"; 
        }
    }
}
