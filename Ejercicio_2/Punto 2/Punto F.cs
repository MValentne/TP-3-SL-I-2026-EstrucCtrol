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
            try
            {
                if (Num_Ingresar.Value < 0)
                {
                    throw new Exception("Los incrementos no pueden ser negativos, Ingrese un valor diferente.");
                }
                double ValorIngresado = Convert.ToDouble(Num_Ingresar.Value);
            for (double X = -10; X <= 10; X++)
                {
                    double Resultado = (Math.Pow(X, 2) + X + 1) + ValorIngresado;
                    Lista_Resultado.Items.Add($"f({X}) = {Resultado}");
                }
                    
                
            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
}}
