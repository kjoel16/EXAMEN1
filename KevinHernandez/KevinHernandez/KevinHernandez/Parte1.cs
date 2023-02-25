using System;
using System.Windows.Forms;

namespace KevinHernandez
{
    public partial class Parte1 : Form
    {
        public Parte1()
        {
            InitializeComponent();
        }
        private void Calcularbutton_Click(object sender, System.EventArgs e)
        {
            double capital = 200000;
            double interesAcumulado = 0;
            DateTime fecha = new DateTime(2023, 1, 1);

            for (int i = 1; i <= 12; i++)
            {
                double interes = CalculoInteres(capital);
                interesAcumulado += interes;
                string mes = fecha.ToString("MMMM");
                string resultado = $"{mes}   L.{interesAcumulado:F2}";
                Intereseslist.Items.Add(resultado);

                capital += interes;
                fecha = fecha.AddMonths(1);
            }
        }
        public static double CalculoInteres(double capital)
        {
            double InteresMensual = 0.015;
            return capital * InteresMensual;
        }

        private void RegresoMenubutton_Click(object sender, EventArgs e)
        {
            Menu MenuPrincipal = new Menu();
            MenuPrincipal.Show();
            this.Close();
        }
    }
}
