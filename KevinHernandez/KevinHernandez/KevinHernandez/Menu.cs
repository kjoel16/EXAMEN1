using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinHernandez
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirParte1button_Click(object sender, EventArgs e)
        {
            Parte1 Ejercicio1 = new Parte1();
            Ejercicio1.Show();
        }

        private void Supermercadobutton_Click(object sender, EventArgs e)
        {
            Parte2 Ejercicio2 = new Parte2();
            Ejercicio2.Show();
        }

        private void Multiplosbutton_Click(object sender, EventArgs e)
        {
            Parte3 Ejercicio3 = new Parte3();
            Ejercicio3.Show();
        }

        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
