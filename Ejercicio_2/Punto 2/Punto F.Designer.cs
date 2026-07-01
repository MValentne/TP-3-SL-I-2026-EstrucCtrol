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
            label2 = new Label();
            Lista_Resultado = new ListBox();
            ((System.ComponentModel.ISupportInitialize)Num_Ingresar).BeginInit();
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
            label1.Location = new Point(2, 76);
            label1.Name = "label1";
            label1.Size = new Size(251, 18);
            label1.TabIndex = 9;
            label1.Text = "Por Favor, Ingrese el valor del incremento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(477, 67);
            label2.TabIndex = 7;
            label2.Text = "Consigna: Hacer un programa que imprima una tabla de valores para la siguiente función:\r\ny = x^2 + x + 1 , para valores de x desde –10 hasta +10, con incrementos enteros y/o decimales";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lista_Resultado
            // 
            Lista_Resultado.FormattingEnabled = true;
            Lista_Resultado.Location = new Point(331, 79);
            Lista_Resultado.Name = "Lista_Resultado";
            Lista_Resultado.Size = new Size(120, 109);
            Lista_Resultado.TabIndex = 13;
            // 
            // Punto_F
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 193);
            Controls.Add(Lista_Resultado);
            Controls.Add(Btn_Regresar);
            Controls.Add(Btn_Ecuacion);
            Controls.Add(Num_Ingresar);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Punto_F";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punto_F";
            ((System.ComponentModel.ISupportInitialize)Num_Ingresar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Regresar;
        private Button Btn_Ecuacion;
        private NumericUpDown Num_Ingresar;
        private Label label1;
        private Label label2;
        private ListBox Lista_Resultado;
    }
}