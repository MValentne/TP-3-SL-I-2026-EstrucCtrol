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
    public partial class ConsignaI : Form
    {
        public ConsignaI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] notas = new int[100];
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = rnd.Next(1, 11); // números entre 1 y 10
                suma = suma + notas[i];
            }
            

            //Cargo la lista (para visualizar)
            for(int i = 0; i < notas.Length; i++)
            {
                listBox1.Items.Add(notas[i]);
            }

            double promedio = suma / notas.Length;
            MessageBox.Show("El promedio de las notas es: " + promedio.ToString("F2"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
