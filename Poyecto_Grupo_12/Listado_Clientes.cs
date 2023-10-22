using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Poyecto_Grupo_12
{
    public partial class Listado_Clientes : Form
    {
        public Listado_Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void socios1_Click(object sender, EventArgs e)
        {

        }

        private void nosocios2_Click(object sender, EventArgs e)
        {

        }

        private void volver3_Click(object sender, EventArgs e)
        {
            {
                Form volver3 = new Form2();
                volver3.ShowDialog();
                this.Hide();
            }
        }


    }
}