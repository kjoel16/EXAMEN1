using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinHernandez
{
    public partial class Parte2 : Form
    {
        private Producto[] productos;
        private int cantidadProductos;

        public Parte2()
        {
            InitializeComponent();

            ProductosdataGridView.Columns.Add("Nombre", "Nombre");
            ProductosdataGridView.Columns.Add("Precio", "Precio");
            ProductosdataGridView.Columns.Add("Cantidad", "Cantidad");
            ProductosdataGridView.Columns["Precio"].DefaultCellStyle.Format = "C2";

            productos = new Producto[10];
            cantidadProductos = 0;

        }

        private void AgregarProductobutton_Click(object sender, EventArgs e)
        {
            if (cantidadProductos < productos.Length)
            {
                Producto producto = new Producto();
                producto.Nombre = ProductotextBox.Text;
                if (decimal.TryParse(PrecioProductotextBox.Text, out decimal precio))
                {
                    producto.Precio = precio;
                }
                else
                {
                    MessageBox.Show("El precio " + PrecioProductotextBox.Text + " no es válido.");
                    return;
                }
                if (int.TryParse(CantidadtextBox.Text, out int cantidad))
                {
                    producto.Cantidad = cantidad;
                }
                else
                {
                    MessageBox.Show("La cantidad " + CantidadtextBox.Text + " no es válida.");
                    return;
                }

                productos[cantidadProductos] = producto;
                cantidadProductos++;
                ProductosdataGridView.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad);
                ProductotextBox.Text = "";
                PrecioProductotextBox.Text = "";
                CantidadtextBox.Text = "";
            }
            else
            {
                MessageBox.Show("No se pueden agregar más productos.");
            }
        }

        private async void Descuentobutton_Click(object sender, EventArgs e)
        {

            List<Producto> productos = new List<Producto>();
            foreach (DataGridViewRow row in ProductosdataGridView.Rows)
            {
                string nombre = row.Cells["Nombre"].Value?.ToString();
                decimal precio = 0;
                if (decimal.TryParse(row.Cells["Precio"].Value?.ToString(), out precio))
                {
                    int cantidad = 0;
                    if (int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad))
                    {
                        Producto producto = new Producto();
                        producto.Nombre = nombre;
                        producto.Precio = precio;
                        producto.Cantidad = cantidad;
                        productos.Add(producto);
                    }
                }
            }

            decimal descuento = await CalcularDescuentoAsync(productos.ToArray());
            decimal total = productos.Sum(p => p.Precio * p.Cantidad) - descuento;
            MessageBox.Show("Descuento del 15%: " + descuento.ToString("0.00") + " Lempiras" + "\nTotal a pagar: " + total.ToString("0.00") + " Lempiras");

        }

        private async Task<decimal> CalcularDescuentoAsync(Producto[] productos)
        {

            await Task.Delay(100);

            decimal total = productos.Sum(p => p.Precio);
            decimal descuento = total * 0.15m;
            return descuento;
        }

        private void PrecioProductotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar != '.' && (sender as TextBox).Text.IndexOf('.') > -1 && (sender as TextBox).Text.Split('.')[1].Length == 2)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void ProductotextBox_TextChanged(object sender, EventArgs e)
        {
            ProductotextBox.Text = ProductotextBox.Text.ToUpper();
            ProductotextBox.SelectionStart = ProductotextBox.Text.Length;
        }

        private void RegresoMenubutton_Click(object sender, EventArgs e)
        {
            Menu MenuPrincipal = new Menu();
            MenuPrincipal.Show();
            this.Close();

        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}

