namespace Punto_a
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPuntuacion = new TextBox();
            label1 = new Label();
            btnVerificarNota = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(41, 67);
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(141, 27);
            txtPuntuacion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 35);
            label1.Name = "label1";
            label1.Size = new Size(314, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la puntuacion de su Examen por favor:";
            label1.Click += label1_Click;
            // 
            // btnVerificarNota
            // 
            btnVerificarNota.Location = new Point(41, 118);
            btnVerificarNota.Name = "btnVerificarNota";
            btnVerificarNota.Size = new Size(94, 60);
            btnVerificarNota.TabIndex = 2;
            btnVerificarNota.Text = "Verificar su Nota";
            btnVerificarNota.UseVisualStyleBackColor = true;
            btnVerificarNota.Click += btnVerificarNota_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(201, 118);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(96, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado es:";
            lblResultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnVerificarNota);
            Controls.Add(label1);
            Controls.Add(txtPuntuacion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPuntuacion;
        private Label label1;
        private Button btnVerificarNota;
        private Label lblResultado;
    }
}
