namespace Punto_2
{
    partial class Punto_E
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
            label2 = new Label();
            panel1 = new Panel();
            Lbl_Confirmacion = new Label();
            label1 = new Label();
            Num_Ingresar = new NumericUpDown();
            Btn_Suma = new Button();
            Btn_Regresar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Num_Ingresar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(467, 49);
            label2.TabIndex = 1;
            label2.Text = "Consigna: Escribir un programa que sume los cuadrados de los n primeros números enteros pares,";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Lbl_Confirmacion);
            panel1.Location = new Point(269, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 118);
            panel1.TabIndex = 2;
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
            // label1
            // 
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(251, 30);
            label1.TabIndex = 3;
            label1.Text = "Por Favor, Ingrese un numero para sumar sus iteraciones pares (Maximo 1000)";
            // 
            // Num_Ingresar
            // 
            Num_Ingresar.Location = new Point(73, 94);
            Num_Ingresar.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Num_Ingresar.Name = "Num_Ingresar";
            Num_Ingresar.Size = new Size(123, 23);
            Num_Ingresar.TabIndex = 4;
            // 
            // Btn_Suma
            // 
            Btn_Suma.Location = new Point(1, 119);
            Btn_Suma.Name = "Btn_Suma";
            Btn_Suma.Size = new Size(128, 62);
            Btn_Suma.TabIndex = 5;
            Btn_Suma.Text = "Realizar Suma";
            Btn_Suma.UseVisualStyleBackColor = true;
            Btn_Suma.Click += Btn_Suma_Click;
            // 
            // Btn_Regresar
            // 
            Btn_Regresar.Location = new Point(135, 119);
            Btn_Regresar.Name = "Btn_Regresar";
            Btn_Regresar.Size = new Size(128, 62);
            Btn_Regresar.TabIndex = 6;
            Btn_Regresar.Text = "Cerrar Pestaña/Regresar";
            Btn_Regresar.UseVisualStyleBackColor = true;
            Btn_Regresar.Click += Btn_Regresar_Click;
            // 
            // Punto_E
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 193);
            Controls.Add(Btn_Regresar);
            Controls.Add(Btn_Suma);
            Controls.Add(Num_Ingresar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "Punto_E";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Punto_E";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Num_Ingresar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label1;
        private NumericUpDown Num_Ingresar;
        private Button Btn_Suma;
        private Button Btn_Regresar;
        private Label Lbl_Confirmacion;
    }
}