namespace Punto_2
{
    partial class Punto_G
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
            Btn_Regresar = new Button();
            Btn_Conversion = new Button();
            Num_Ingresar = new NumericUpDown();
            label1 = new Label();
            panel1 = new Panel();
            Lbl_Confirmacion = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Num_Ingresar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Regresar
            // 
            Btn_Regresar.Location = new Point(135, 139);
            Btn_Regresar.Name = "Btn_Regresar";
            Btn_Regresar.Size = new Size(128, 62);
            Btn_Regresar.TabIndex = 18;
            Btn_Regresar.Text = "Cerrar Pestaña/Regresar";
            Btn_Regresar.UseVisualStyleBackColor = true;
            // 
            // Btn_Conversion
            // 
            Btn_Conversion.Location = new Point(1, 139);
            Btn_Conversion.Name = "Btn_Conversion";
            Btn_Conversion.Size = new Size(128, 62);
            Btn_Conversion.TabIndex = 17;
            Btn_Conversion.Text = "Realizar Conversión";
            Btn_Conversion.UseVisualStyleBackColor = true;
            Btn_Conversion.Click += Btn_Suma_Click;
            // 
            // Num_Ingresar
            // 
            Num_Ingresar.Location = new Point(71, 110);
            Num_Ingresar.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Num_Ingresar.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            Num_Ingresar.Name = "Num_Ingresar";
            Num_Ingresar.Size = new Size(123, 23);
            Num_Ingresar.TabIndex = 16;
            // 
            // label1
            // 
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(251, 48);
            label1.TabIndex = 15;
            label1.Text = "Por Favor, Ingrese el valor de temperatura en grados Celsius. \r\n(Minimo, -273,15; Maximo, 250)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Lbl_Confirmacion);
            panel1.Location = new Point(269, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 139);
            panel1.TabIndex = 14;
            // 
            // Lbl_Confirmacion
            // 
            Lbl_Confirmacion.Location = new Point(3, 0);
            Lbl_Confirmacion.Name = "Lbl_Confirmacion";
            Lbl_Confirmacion.Size = new Size(210, 139);
            Lbl_Confirmacion.TabIndex = 0;
            Lbl_Confirmacion.Text = "Aquí se mostrará su resultado final";
            Lbl_Confirmacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(2, 10);
            label2.Name = "label2";
            label2.Size = new Size(467, 49);
            label2.TabIndex = 13;
            label2.Text = "Consigna: Realizar un programa que genere una tabla que convierta y muestre grados Celsius\r\ningresados por el usuario y genere su equivalentes en Fahrenheit y Kelvin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Punto_G
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 213);
            Controls.Add(Btn_Regresar);
            Controls.Add(Btn_Conversion);
            Controls.Add(Num_Ingresar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "Punto_G";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punto_G";
            ((System.ComponentModel.ISupportInitialize)Num_Ingresar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Regresar;
        private Button Btn_Conversion;
        private NumericUpDown Num_Ingresar;
        private Label label1;
        private Panel panel1;
        private Label Lbl_Confirmacion;
        private Label label2;
    }
}