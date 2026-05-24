namespace Punto_c
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
            btnIngresar = new Button();
            lblPongaNumero = new Label();
            txtNumero = new TextBox();
            grpNumeros = new GroupBox();
            lblPrimerCaso = new Label();
            lblArrayNumeros = new Label();
            btnCalcular = new Button();
            grpNumeros.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese 3 Numeros";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(174, 82);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(80, 51);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar Numero";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblPongaNumero
            // 
            lblPongaNumero.AutoSize = true;
            lblPongaNumero.Location = new Point(3, 49);
            lblPongaNumero.Name = "lblPongaNumero";
            lblPongaNumero.Size = new Size(143, 20);
            lblPongaNumero.TabIndex = 2;
            lblPongaNumero.Text = "Ingrese el numero 1:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(152, 49);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 3;
            // 
            // grpNumeros
            // 
            grpNumeros.Controls.Add(lblPrimerCaso);
            grpNumeros.Controls.Add(lblArrayNumeros);
            grpNumeros.Location = new Point(448, 12);
            grpNumeros.Name = "grpNumeros";
            grpNumeros.Size = new Size(641, 139);
            grpNumeros.TabIndex = 4;
            grpNumeros.TabStop = false;
            grpNumeros.Text = "Sus numeros son:";
            // 
            // lblPrimerCaso
            // 
            lblPrimerCaso.AutoSize = true;
            lblPrimerCaso.Location = new Point(6, 44);
            lblPrimerCaso.Name = "lblPrimerCaso";
            lblPrimerCaso.Size = new Size(314, 20);
            lblPrimerCaso.TabIndex = 6;
            lblPrimerCaso.Text = "Primer caso el primer numero es menor que 0:";
            lblPrimerCaso.Visible = false;
            lblPrimerCaso.Click += label2_Click;
            // 
            // lblArrayNumeros
            // 
            lblArrayNumeros.AutoSize = true;
            lblArrayNumeros.Location = new Point(6, 23);
            lblArrayNumeros.Name = "lblArrayNumeros";
            lblArrayNumeros.Size = new Size(104, 20);
            lblArrayNumeros.TabIndex = 0;
            lblArrayNumeros.Text = "ArrayNumeros";
            lblArrayNumeros.Visible = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(160, 155);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 450);
            Controls.Add(btnCalcular);
            Controls.Add(grpNumeros);
            Controls.Add(txtNumero);
            Controls.Add(lblPongaNumero);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grpNumeros.ResumeLayout(false);
            grpNumeros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIngresar;
        private Label lblPongaNumero;
        private TextBox txtNumero;
        private GroupBox grpNumeros;
        private Label lblArrayNumeros;
        private Button btnCalcular;
        private Label lblPrimerCaso;
    }
}
