using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Poyecto_Grupo_12
{
    public partial class Cliente : Form
    {

            public Cliente()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void alta_Click(object sender, EventArgs e)
            {
                {
                    Form nueva_inscripcion = new Nueva_Inscripcion();
                    nueva_inscripcion.ShowDialog();
                }
            }

            private void modificacion_Click(object sender, EventArgs e)
            {

            }
        }
    }
