using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Poyecto_Grupo_12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            {
                Form form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            {
                Form cliente = new Cliente();
                cliente.ShowDialog();
            }
        }
        private void deudores_Click(object sender, EventArgs e)
        {

        }

        private void actividades_Click(object sender, EventArgs e)
        {

        }

        private void listado_Click(object sender, EventArgs e)
        {
            {
                Form listado = new Listado_Clientes();
                listado.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}


