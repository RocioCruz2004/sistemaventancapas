using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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

namespace SistemasVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdEditarVista : Form
    {
        TipoProd tp = new TipoProd();
        TipoProdBss bss = new TipoProdBss();
        int idx = 0;
        public TipoProdEditarVista(int id)
        {
            InitializeComponent();
            idx = id;
        }

        private void TipoProdEditarVista_Load(object sender, EventArgs e)
        {
            tp = bss.ObtenerTipoProdIdBss(idx);
            textBox1.Text = tp.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tp.Nombre = textBox1.Text;

            bss.EditarTipoProdBss(tp);
            MessageBox.Show("Se editó correctamente!");
        }
    }
}
