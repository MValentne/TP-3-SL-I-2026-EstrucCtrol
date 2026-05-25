namespace Punto_d
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
            label1 = new Label();
            btnVerificarAño = new Button();
            lblResultado = new Label();
            mtbFechitaNacimiento = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 20);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su fecha de nacimiento";
            // 
            // btnVerificarAño
            // 
            btnVerificarAño.Location = new Point(109, 67);
            btnVerificarAño.Name = "btnVerificarAño";
            btnVerificarAño.Size = new Size(94, 62);
            btnVerificarAño.TabIndex = 2;
            btnVerificarAño.Text = "Verificar Año";
            btnVerificarAño.UseVisualStyleBackColor = true;
            btnVerificarAño.Click += btnVerificarAño_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(235, 67);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            lblResultado.Visible = false;
            // 
            // mtbFechitaNacimiento
            // 
            mtbFechitaNacimiento.Location = new Point(278, 17);
            mtbFechitaNacimiento.Mask = "##/##/##";
            mtbFechitaNacimiento.Name = "mtbFechitaNacimiento";
            mtbFechitaNacimiento.Size = new Size(125, 27);
            mtbFechitaNacimiento.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtbFechitaNacimiento);
            Controls.Add(lblResultado);
            Controls.Add(btnVerificarAño);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnVerificarAño;
        private Label lblResultado;
        private MaskedTextBox mtbFechitaNacimiento;
    }
}
