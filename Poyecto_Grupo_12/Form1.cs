using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Poyecto_Grupo_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Vamos a agregar los nombres de los operadores de la administración al comboBox1 en el constructor
            comboBox1.Items.Add("María Eugenia");
            comboBox1.Items.Add("Mariano");
            comboBox1.Items.Add("Martina");
            comboBox1.Items.Add("Luciana");
            comboBox1.Items.Add("Julian");

            this.Controls.Add(comboBox1);

            //Cada operador debe elegir el código de usuario de su PC.

            comboBox2.Items.Add("238097");
            comboBox2.Items.Add("408937");
            comboBox2.Items.Add("398765");
            comboBox2.Items.Add("134976");
            comboBox2.Items.Add("153050");

            this.Controls.Add(comboBox2);

        }

        private void administrador_Click(object sender, EventArgs e)
        {

        }

        private void operador_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            Form form1 = new Form2();
            form1.ShowDialog();
        }


    }
}
