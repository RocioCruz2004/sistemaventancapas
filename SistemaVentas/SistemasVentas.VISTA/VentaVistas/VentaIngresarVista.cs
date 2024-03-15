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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaIngresarVista : Form
    {
        public VentaIngresarVista()
        {
            InitializeComponent();
        }

        VentaBss bss= new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.IdCliente = Convert.ToInt32(textBox1.Text);
            v.IdVendedor = Convert.ToInt32(textBox2.Text);
            v.Fecha = dateTimePicker1.Value;
            v.Total = Convert.ToDecimal(textBox3.Text);

            bss.InsertarVentaBss(v);
            MessageBox.Show("Se guardó correctamente!");
        }
    }
}
