using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consigna4PuntoN
{
    public partial class Form1 : Form
    {
        // La lista a nivel de clase para guardar los números
        List<double> numeros = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string entrada = textBox1.Text.Trim().ToLower();


            switch (entrada)
            {
                case "fin":

                    if (numeros.Count > 0)
                    {
                        numeros.Sort();
                        string ascendente = string.Join(" ; ", numeros);

                        numeros.Reverse();
                        string descendente = string.Join(" ; ", numeros);

                        string mensajeFinal = $"Lista ordenada de MENOR a MAYOR:\n{ascendente}\n\nLista ordenada de MAYOR a MENOR:\n{descendente}";
                        MessageBox.Show(mensajeFinal, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        numeros.Clear();
                        label1.Text = "Lista procesada. Ingresa un nuevo número:";
                    }
                    else
                    {
                        MessageBox.Show("Todavía no agregaste ningún número a la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    textBox1.Clear();
                    break;

                default:

                    if (double.TryParse(textBox1.Text.Trim(), out double numero))
                    {
                        numeros.Add(numero);
                        label1.Text = $"Número {numero} agregado. Total: {numeros.Count}";
                    }
                    else
                    {

                        MessageBox.Show("Por favor, ingresa un número válido o escribe 'fin' para procesar.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    textBox1.Clear();
                    textBox1.Focus();
                    break;
            }
        }
    }
}