using System;
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
    public partial class ConsignaH : Form
    {
        public ConsignaH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] numeros = new int[10]; //Array de 10 elementos

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 501) * 2; // números entre 1 y 500, multiplicados por 2 para asegurar que sean pares
            }

            for(int i = 0; i < numeros.Length; i++)
            {
                listBox1.Items.Add(numeros[i]); // Agrega cada número al ListBox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cerrar ventana
            this.Close();
        }
    }
}
