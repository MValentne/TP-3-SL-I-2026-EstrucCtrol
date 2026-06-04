using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto4ConsignaK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int año))
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    MessageBox.Show("El año " + año + " es bisiesto. Febrero tiene 29 días.");
                }
                else
                {
                    MessageBox.Show("El año " + año + " no es bisiesto. Febrero tiene 28 días.");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Por favor ingrese un número válido para el año.");
            }
        }
    }
}
