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
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.TipoProdVistas;

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoIngresarVista : Form
    {
        public ProductoIngresarVista()
        {
            InitializeComponent();
        }

        ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdTipoProd = IdTipoProdSeleccionado;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.InsertarProductoBss(p);
            MessageBox.Show("Se guardó correctamente!");
        }

        public static int IdTipoProdSeleccionado = 0;
        TipoProdBss BssTP = new TipoProdBss();
        private void button5_Click(object sender, EventArgs e)
        {
            TipoProdListarVista tpv = new TipoProdListarVista();
            if (tpv.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoprod = BssTP.ObtenerTipoProdIdBss(IdTipoProdSeleccionado);
                textBox1.Text = tipoprod.Nombre;
            }
        }

        public static int IdMarcaSeleccionada = 0;
        MarcaBss BssMarca = new MarcaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            MarcaListarVista mv = new MarcaListarVista();
            if (mv.ShowDialog() == DialogResult.OK)
            {
                Marca marca = BssMarca.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox2.Text = marca.Nombre;
            }
        }
    }
}
