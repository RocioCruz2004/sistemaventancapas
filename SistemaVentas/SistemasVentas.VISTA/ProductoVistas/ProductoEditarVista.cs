using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoEditarVista : Form
    {

        Producto p = new Producto();
        ProductoBss bss = new ProductoBss();
        int idx = 0;
        public ProductoEditarVista(int id)
        {
            InitializeComponent();
            idx = id;
        }

        private void ProductoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerProductoIdBss(idx);
            textBox1.Text = p.IdTipoProd.ToString();
            textBox2.Text = p.IdMarca.ToString();
            textBox3.Text = p.Nombre;
            textBox4.Text = p.CodigoBarra;
            textBox5.Text = p.Unidad.ToString();
            textBox6.Text = p.Descripcion;
        }

        public static int IdTipoProdSeleccionado = 0;
        public static int IdMarcaSeleccionada = 0;
        private void button1_Click(object sender, EventArgs e) //guardar
        {
            p.IdTipoProd = IdTipoProdSeleccionado;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.EditarProductoBss(p);
            MessageBox.Show("Se editó correctamente!");
        }

        TipoProdBss BssTP = new TipoProdBss();
        private void button5_Click(object sender, EventArgs e) //selec tipo prod id
        {
            TipoProdListarVista tplv = new TipoProdListarVista();
            if (tplv.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoprod = BssTP.ObtenerTipoProdIdBss(IdTipoProdSeleccionado);
                textBox1.Text = tipoprod.Nombre;
            }
        }

        MarcaBss BssMarca = new MarcaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            MarcaListarVista mlv = new MarcaListarVista();
            if (mlv.ShowDialog() == DialogResult.OK)
            {
                Marca marca = BssMarca.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox2.Text = marca.Nombre;
            }
        }
    }
}
