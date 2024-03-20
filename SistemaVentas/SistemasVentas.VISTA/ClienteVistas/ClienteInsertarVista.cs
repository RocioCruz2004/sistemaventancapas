﻿using System;
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
using SistemasVentas.VISTA.PersonaVistas;

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdPersonaSeleccionado = 0;
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.IdPersona = IdPersonaSeleccionado;
            c.TipoCliente = textBox2.Text;
            c.CodigoCliente = textBox3.Text;

            bss.InsertarClientesBss(c);
            MessageBox.Show("Se guardó correctamente!");
        }

        PersonaBss BssPer = new PersonaBss();
        private void button3_Click(object sender, EventArgs e) //Seleccionar a lista personas
        {
            PersonaListarVista plv = new PersonaListarVista();
            if (plv.ShowDialog() == DialogResult.OK)
            {
                Persona persona = BssPer.ObtenerIdBss(IdPersonaSeleccionado);
                textBox1.Text = persona.Nombre+ " " +persona.Apellido;
            }
        }
    }
}
