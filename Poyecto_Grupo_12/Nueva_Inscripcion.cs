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
    public partial class Nueva_Inscripcion : Form
    {
        public Nueva_Inscripcion()
        {
            InitializeComponent();

            // Vamos a agregar las opciones al comboBox1 del apto físico en el constructor
            comboBox1.Items.Add("Presenta");
            comboBox1.Items.Add("No Presenta");

            this.Controls.Add(comboBox1);

            // Vamos a agregar las opciones al comboBox2 de la ficha médica en el constructor
            comboBox2.Items.Add("Presenta");
            comboBox2.Items.Add("No Presenta");

            this.Controls.Add(comboBox2);

            // Vamos a agregar las opciones al comboBox3 de la categoría en el constructor
            comboBox3.Items.Add("Socio");
            comboBox3.Items.Add("No Socio");

            this.Controls.Add(comboBox3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dni_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefono_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccion_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void apto_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ficha_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clasificacion_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void continuar_Click(object sender, EventArgs e)
        {
            {
                Form sigueInscripcion = new Nueva_Inscripcion_2();
                sigueInscripcion.ShowDialog();
            }
            if
            (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show(
                "Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                /*
                string respuesta;
               Nueva_Inscripcion cliente = new Nueva_Inscripcion();
                cliente.Nombre = textBox1.Text;
                cliente.Apellido = textBox2.Text;
                cliente.Dni = textBox3.Text;
                cliente.Telefono = textBox4.Text;
                cliente.Email = textBox5.Text;
                cliente.Direccion = textBox6.Text;
                cliente.Apto_fisico = comboBox1.Text;
                cliente.Ficha_medica = comboBox2.Text;
                cliente.Fecha = dateTimePicker1.Text;
                cliente.Categoria = comboBox3.Text;
                */
            }

        }
        private void volver_Click(object sender, EventArgs e)
        {
            {
                Form volver = new Cliente();
                volver.ShowDialog();
                this.Hide();
            }
        }

        /*private void Nueva_Inscripcion_Load(object sender, EventArgs e)
        {

        }*/

        //Se agrega el botón que dice limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
