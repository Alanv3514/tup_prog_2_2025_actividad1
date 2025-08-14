using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConstruir_Click(object sender, EventArgs e)
        {
            //construyendo los objetos
            //Cilindro objeto = new Cilindro(3, 3);
            Cubo objeto= new Cubo(3);
            //Ortoedro objeto = new Ortoedro(7, 7, 21);

            //Cilindro objeto = new Cilindro(9, 13);
            //Cubo objeto = new Cubo(7);
            //Cilindro objeto = new Cilindro(13, 23);

            //llamando al mensaje común de todos los objetos figura
            tbDescripcion.Text = "";
            tbDescripcion.Text += $@"
[ 
  {objeto.describir()}
]";

        }
    }
}
