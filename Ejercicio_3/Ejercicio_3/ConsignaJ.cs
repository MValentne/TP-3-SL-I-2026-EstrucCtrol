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
                    return numero * factorial(numero - 1);
            }
            try
            {
                int numerito = int.Parse(textBox1.Text);
                if(numerito < 0) 
                { 
                    //Lanzo error
                    throw new FormatException();
                }
                long resultado = factorial(numerito);
                
                MessageBox.Show($"El factorial de {numerito} es: {resultado}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
                textBox1.Focus();
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
