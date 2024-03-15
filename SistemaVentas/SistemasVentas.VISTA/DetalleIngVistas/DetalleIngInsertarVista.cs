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

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }

        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng di = new DetalleIng();
            di.IdIngreso = Convert.ToInt32(textBox1.Text);
            di.IdProducto = Convert.ToInt32(textBox2.Text);
            di.FechaVenc = dateTimePicker1.Value;
            di.Cantidad = Convert.ToInt32(textBox3.Text);
            di.PrecioCosto = Convert.ToDecimal(textBox4.Text);
            di.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            di.Subtotal = Convert.ToDecimal(textBox6.Text);

            bss.InsertarDetalleIngbss(di);
            MessageBox.Show("Se guardó correctamente!");
        }
    }
}
