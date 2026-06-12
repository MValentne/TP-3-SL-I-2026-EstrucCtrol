using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Punto_2
{
    public partial class Punto_F : Form
    {
        public Punto_F()
        {
            InitializeComponent();
        }

        private void Btn_Suma_Click(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(Num_Ingresar.Value);
            double Resultado = Math.Pow(X, 2) + X - 1;
            Lbl_Confirmacion.Text = $"El resultado de la ecuacion X^2 + X - 1 con el valor de X = {X} es: {Resultado}";
        }
    }
}
