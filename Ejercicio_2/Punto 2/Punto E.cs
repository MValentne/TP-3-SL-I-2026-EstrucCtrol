using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Punto_2
{
    public partial class Punto_E : Form
    {
        public Punto_E()
        {
            InitializeComponent();
        }

        private void Btn_Suma_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(Num_Ingresar.Value);
            double resultado = 0;
            int i = 0;
            for (i = 0; i <= numero; i += 2)
            {
                if (i % 2 == 0)
                {
                    resultado += Math.Pow(i, 2);
                }
            }
            Lbl_Confirmacion.Text = $"El resultado de la suma de los cuadrados de los {numero} primeros numeros enteros pares es: {resultado}";
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
