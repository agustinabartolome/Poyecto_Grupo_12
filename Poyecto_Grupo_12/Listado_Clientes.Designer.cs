namespace Poyecto_Grupo_12
{
    partial class Listado_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1 A partir de acá tendríamos que poder ver, en la siguiente pantalla el listado de socios.
            // 
            button1.Location = new System.Drawing.Point(124, 165);
            button1.Name = "lista socios";
            button1.Size = new System.Drawing.Size(226, 92);
            button1.TabIndex = 2;
            button1.Text = "LISTADO DE SOCIOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += socios1_Click;
            // 
            // button2 A partir de acá, en la siguiente pantalla tendríamos que ver el listado de los no socios.
            // 
            button2.Location = new System.Drawing.Point(450, 165);
            button2.Name = "lista no socios";
            button2.Size = new System.Drawing.Size(200, 92);
            button2.TabIndex = 3;
            button2.Text = "LISTADO DE NO SOCIOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += nosocios2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(184, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(434, 25);
            label1.TabIndex = 4;
            label1.Text = "LISTADO DE CLIENTES REGISTRADOS EN EL SISTEMA";
            label1.Click += label1_Click;
            // 
            // button3 A partir de acá, volveríamos a la ventana anterior, la que nos muestra las difernetes opciones del cliente.
            // 
            button3.Location = new System.Drawing.Point(294, 315);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(176, 48);
            button3.TabIndex = 23;
            button3.Text = "VOLVER";
            button3.UseVisualStyleBackColor = true;
            button3.Click += volver3_Click;
            // 
            // Listado_Clientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Listado_Clientes";
            Text = "Listado_Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}