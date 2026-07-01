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
            try
            {
                int numero = Convert.ToInt16(Num_Ingresar.Value);
                double ConfirmacionNumero = Convert.ToDouble(Num_Ingresar.Value);
                if (numero != Math.Truncate(ConfirmacionNumero))
                {
                    throw new Exception("Ingrese solo números enteros.");
                }

                double resultado = 0;
                int contador = 0;
                int i;
                for (i = 2; !(contador == numero); i += 2)
                {
                    if (i % 2 == 0)
                    {
                        resultado += Math.Pow(i, 2);
                    }
                    contador++;
                }
                Lbl_Confirmacion.Text = $"El resultado de la suma de los cuadrados de los {numero} primeros numeros enteros pares es: {resultado}";
                Num_Ingresar.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Num_Ingresar.Value = 0;
                Focus();
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
