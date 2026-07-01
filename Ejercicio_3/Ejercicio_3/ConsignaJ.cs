using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class ConsignaJ : Form
    {
        public ConsignaJ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long factorial(int numero)
            {
                if (numero == 0 || numero == 1)
                    return 1;
                else
                    return checked(numero * factorial(numero - 1));
            }
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    throw new ArgumentException("Por favor, ingrese un número.");
                }

                int numerito = int.Parse(textBox1.Text);
                if (numerito < 0) 
                { 
                    throw new ArgumentOutOfRangeException(nameof(numerito), "No se permiten números negativos.");
                }
                
                long resultado = factorial(numerito);
                
                MessageBox.Show($"El factorial de {numerito} es: {resultado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                textBox1.Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número ingresado es demasiado grande. Ingrese un valor entre 0 y 20 para evitar desbordamiento.", "Error de Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                textBox1.SelectAll();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Valor Fuera de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                textBox1.SelectAll();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
