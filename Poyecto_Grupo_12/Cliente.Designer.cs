namespace Poyecto_Grupo_12
{
    partial class Cliente
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(359, 58);
            label1.Name = "Cliente";
            label1.Size = new System.Drawing.Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "CLIENTE";
            // 
            // button1 Lo que se quiere hacer en este caso es comprobar si el nuevo cliente ya se encuentra registrado.
            // 
            button1.Location = new System.Drawing.Point(95, 177);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(149, 104);
            button1.TabIndex = 1;
            button1.Text = "COMPROBAR DNI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2 Se quiere generar una nueva inscripción y el alta en el sistema.
            // 
            button2.Location = new System.Drawing.Point(326, 173);
            button2.Name = "Inscripcion";
            button2.Size = new System.Drawing.Size(149, 104);
            button2.TabIndex = 2;
            button2.Text = "GENERAR INSCRIPCIÓN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += alta_Click;
            // 
            // button3 Se quiere generar la modificación de una inscripción previamente realizada.
            // 
            button3.Location = new System.Drawing.Point(573, 173);
            button3.Name = "Modificar Inscripcion";
            button3.Size = new System.Drawing.Size(149, 104);
            button3.TabIndex = 3;
            button3.Text = "MODIFICAR INSCRIPCIÓN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += modificacion_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Cliente";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}