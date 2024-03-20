using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaEditarVista : Form
    {
        DetalleVenta dv = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        int idx = 0;
        public static int IdVentaSeleccionada = 0;
        public static int IdProductoSeleccionado = 0;
        public DetalleVentaEditarVista(int id)
        {
            InitializeComponent();
            idx = id;
        }

        private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
        {
            dv = bss.ObtenerDetalleVentaId(idx);
            textBox1.Text = dv.IdVenta.ToString();
            textBox2.Text = dv.IdProducto.ToString();
            textBox3.Text = dv.Cantidad.ToString();
            textBox4.Text = dv.PrecioVenta.ToString();
            textBox5.Text = dv.Subtotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e) //btn guardar
        {
            dv.IdVenta = IdVentaSeleccionada;
            dv.IdProducto = IdProductoSeleccionado;
            dv.Cantidad = Convert.ToInt32(textBox3.Text);
            dv.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            dv.Subtotal = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleVentaBss(dv);
            MessageBox.Show("Se editó correctamente!");
        }
        VentaBss BssVenta = new VentaBss();
        private void button5_Click(object sender, EventArgs e) //selec idventa
        {
            VentaListarVista vlv = new VentaListarVista();
            if (vlv.ShowDialog() == DialogResult.OK)
            {
                Venta venta = BssVenta.ObtenerVentaId(IdVentaSeleccionada);
                textBox1.Text = venta.IdVenta.ToString();
            }
        }
        ProductoBss BssProducto = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista plv = new ProductoListarVista();
            if (plv.ShowDialog() == DialogResult.OK)
            {
                Producto producto = BssProducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
