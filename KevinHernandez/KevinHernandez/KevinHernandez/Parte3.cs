using System;
using System.Windows.Forms;

namespace KevinHernandez
{
    public partial class Parte3 : Form
    {
        public Parte3()
        {
            InitializeComponent();
        }

        private void GenerarNumerobutton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(1, 101);

            for (int i = 1; i <= 100; i++)
            {
                if (i == numeroAleatorio)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        MessageBox.Show("Kevin" + " " + "Hernandez" + " - " + i);
                    }
                    else if (i % 3 == 0)
                    {
                        MessageBox.Show("Kevin" + " - " + i);
                    }
                    else if (i % 5 == 0)
                    {
                        MessageBox.Show("Hernandez" + " - " + i);
                    }
                    else
                    {
                        MessageBox.Show(i + " - " + " No es un multiplo de 3 o 5  ");
                    }
                    break;
                }
            }
        }

        private void RegresoMenubutton_Click(object sender, EventArgs e)
        {
            Menu MenuPrincipal = new Menu();
            MenuPrincipal.Show();
            this.Close();
        }
    }

}
