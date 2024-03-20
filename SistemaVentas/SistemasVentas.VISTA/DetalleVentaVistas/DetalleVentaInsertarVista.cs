using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.VentaVistas;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public static int IdVentaSeleccionada = 0;
        public static int IdProductoSeleccionado = 0;
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }

        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta dv = new DetalleVenta();
            dv.IdVenta = IdVentaSeleccionada;
            dv.IdProducto = IdProductoSeleccionado;
            dv.Cantidad = Convert.ToInt32(textBox3.Text);
            dv.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            dv.Subtotal = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleVentaBss(dv);
            MessageBox.Show("Se guardó correctamente!");
        }

        private void DetalleVentaInsertarVista_Load(object sender, EventArgs e)
        {

        }

        VentaBss BssVenta = new VentaBss();
        private void button5_Click(object sender, EventArgs e) //idventa seleccionar btn
        {
            VentaListarVista vlv = new VentaListarVista();
            if (vlv.ShowDialog() == DialogResult.OK)
            {
                Venta venta = BssVenta.ObtenerVentaId(IdVentaSeleccionada);
                textBox1.Text = venta.IdVenta.ToString();
            }
        }

        ProductoBss BssProducto = new ProductoBss();
        private void button3_Click(object sender, EventArgs e) //idproducto seleccionar btn
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
