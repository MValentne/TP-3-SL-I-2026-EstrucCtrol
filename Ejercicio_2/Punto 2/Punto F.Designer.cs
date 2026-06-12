namespace Punto_2
{
    partial class Punto_F
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
            Btn_Ecuacion = new Button();
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
            Btn_Regresar.Location = new Point(135, 119);
            Btn_Regresar.Name = "Btn_Regresar";
            Btn_Regresar.Size = new Size(128, 62);
            Btn_Regresar.TabIndex = 12;
            Btn_Regresar.Text = "Cerrar Pestaña/Regresar";
            Btn_Regresar.UseVisualStyleBackColor = true;
            // 
            // Btn_Ecuacion
            // 
            Btn_Ecuacion.Location = new Point(1, 119);
            Btn_Ecuacion.Name = "Btn_Ecuacion";
            Btn_Ecuacion.Size = new Size(128, 62);
            Btn_Ecuacion.TabIndex = 11;
            Btn_Ecuacion.Text = "Realizar Ecuacion";
            Btn_Ecuacion.UseVisualStyleBackColor = true;
            Btn_Ecuacion.Click += Btn_Suma_Click;
            // 
            // Num_Ingresar
            // 
            Num_Ingresar.Location = new Point(73, 94);
            Num_Ingresar.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            Num_Ingresar.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            Num_Ingresar.Name = "Num_Ingresar";
            Num_Ingresar.Size = new Size(123, 23);
            Num_Ingresar.TabIndex = 10;
            // 
            // label1
            // 
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(251, 30);
            label1.TabIndex = 9;
            label1.Text = "Por Favor, Ingrese el valor de X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Lbl_Confirmacion);
            panel1.Location = new Point(269, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 118);
            panel1.TabIndex = 8;
            // 
            // Lbl_Confirmacion
            // 
            Lbl_Confirmacion.Location = new Point(0, -3);
            Lbl_Confirmacion.Name = "Lbl_Confirmacion";
            Lbl_Confirmacion.Size = new Size(210, 118);
            Lbl_Confirmacion.TabIndex = 0;
            Lbl_Confirmacion.Text = "Aquí se mostrará su resultado final";
            Lbl_Confirmacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(467, 49);
            label2.TabIndex = 7;
            label2.Text = "Consigna: Hacer un programa que imprima una tabla de valores para la siguiente función: \r\ny = x2 + x + 1 , para valores de x desde –10 hasta +10, con incrementos enteros y/o\r\ndecimales";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Punto_F
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 193);
            Controls.Add(Btn_Regresar);
            Controls.Add(Btn_Ecuacion);
            Controls.Add(Num_Ingresar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "Punto_F";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punto_F";
            ((System.ComponentModel.ISupportInitialize)Num_Ingresar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Regresar;
        private Button Btn_Ecuacion;
        private NumericUpDown Num_Ingresar;
        private Label label1;
        private Panel panel1;
        private Label Lbl_Confirmacion;
        private Label label2;
    }
}