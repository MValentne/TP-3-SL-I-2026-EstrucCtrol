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
            try
            {
                listBox1.Items.Clear();
                Random rnd = new Random();
                int[] notas = new int[100];
                double suma = 0;
                for (int i = 0; i < notas.Length; i++)
                {
                    notas[i] = rnd.Next(1, 101); // números entre 1 y 100 (rango de 1...100 según consigna)
                    suma = suma + notas[i];
                }

                //Cargo la lista (para visualizar)
                for (int i = 0; i < notas.Length; i++)
                {
                    listBox1.Items.Add(notas[i]);
                }

                double promedio = suma / notas.Length;
                MessageBox.Show("El promedio de las notas es: " + promedio.ToString("F2"), "Promedio de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
