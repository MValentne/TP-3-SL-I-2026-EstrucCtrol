namespace Punto_b
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
            txtNumero = new TextBox();
            label1 = new Label();
            btnIngresar = new Button();
            lblNumeroIngresar = new Label();
            btnMayor = new Button();
            lblMayor = new Label();
            label3 = new Label();
            lblArray = new Label();
            btnMenor = new Button();
            lblMenor = new Label();
            btnMedia = new Button();
            lblMedia = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(149, 80);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 24);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Escriba 5 numeros";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(158, 123);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(99, 48);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar numero";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // lblNumeroIngresar
            // 
            lblNumeroIngresar.AutoSize = true;
            lblNumeroIngresar.Location = new Point(3, 80);
            lblNumeroIngresar.Name = "lblNumeroIngresar";
            lblNumeroIngresar.Size = new Size(140, 20);
            lblNumeroIngresar.TabIndex = 3;
            lblNumeroIngresar.Text = "Ingrese el numero 1";
            // 
            // btnMayor
            // 
            btnMayor.Location = new Point(21, 239);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(94, 48);
            btnMayor.TabIndex = 4;
            btnMayor.Text = "Calcular Mayor";
            btnMayor.UseVisualStyleBackColor = true;
            btnMayor.Click += btnMayor_Click;
            // 
            // lblMayor
            // 
            lblMayor.AutoSize = true;
            lblMayor.Location = new Point(121, 253);
            lblMayor.Name = "lblMayor";
            lblMayor.Size = new Size(54, 20);
            lblMayor.TabIndex = 5;
            lblMayor.Text = "Mayor:";
            lblMayor.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 24);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 6;
            label3.Text = "Su array es el siguiente:";
            // 
            // lblArray
            // 
            lblArray.AutoSize = true;
            lblArray.Location = new Point(333, 57);
            lblArray.Name = "lblArray";
            lblArray.Size = new Size(47, 20);
            lblArray.TabIndex = 7;
            lblArray.Text = "Array:";
            lblArray.Visible = false;
            // 
            // btnMenor
            // 
            btnMenor.Location = new Point(21, 293);
            btnMenor.Name = "btnMenor";
            btnMenor.Size = new Size(94, 60);
            btnMenor.TabIndex = 8;
            btnMenor.Text = "Calcular Menor";
            btnMenor.UseVisualStyleBackColor = true;
            btnMenor.Click += btnMenor_Click;
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(121, 313);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(55, 20);
            lblMenor.TabIndex = 9;
            lblMenor.Text = "Menor:";
            lblMenor.Visible = false;
            // 
            // btnMedia
            // 
            btnMedia.Location = new Point(21, 359);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(94, 55);
            btnMedia.TabIndex = 10;
            btnMedia.Text = "Calcular Media";
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(121, 376);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(54, 20);
            lblMedia.TabIndex = 11;
            lblMedia.Text = "Media:";
            lblMedia.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMedia);
            Controls.Add(btnMedia);
            Controls.Add(lblMenor);
            Controls.Add(btnMenor);
            Controls.Add(lblArray);
            Controls.Add(label3);
            Controls.Add(lblMayor);
            Controls.Add(btnMayor);
            Controls.Add(lblNumeroIngresar);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private Button btnIngresar;
        private Label lblNumeroIngresar;
        private Button btnMayor;
        private Label lblMayor;
        private Label label3;
        private Label lblArray;
        private Button btnMenor;
        private Label lblMenor;
        private Button btnMedia;
        private Label lblMedia;
    }
}
