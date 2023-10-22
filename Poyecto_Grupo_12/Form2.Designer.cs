namespace Poyecto_Grupo_12
{
    partial class Form2
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
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(566, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(293, 25);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE GESTIÓN DE CLIENTES";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(47, 144);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(223, 92);
            button1.TabIndex = 1;
            button1.Text = "NUEVO CLIENTE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += nuevo_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(643, 144);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(259, 96);
            button2.TabIndex = 2;
            button2.Text = "LISTA DE DEUDORES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += deudores_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(966, 144);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(337, 92);
            button3.TabIndex = 3;
            button3.Text = "REGISTRO DE ACTIVIDADES";
            button3.UseVisualStyleBackColor = true;
            button3.Click += actividades_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(321, 144);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(261, 96);
            button4.TabIndex = 4;
            button4.Text = "LISTA DE CLIENTES";
            button4.UseVisualStyleBackColor = true;
            button4.Click += listado_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1351, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
