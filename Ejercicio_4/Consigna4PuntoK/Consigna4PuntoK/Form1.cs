using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consigna4PuntoK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                int puntuacion = int.Parse(textBox1.Text);
                string calificacionFinal = "";

                switch (puntuacion)
                {
                    case int n when (n >= 90 && n <= 100):
                        calificacionFinal = "A";
                        break;

                    case int n when (n >= 80 && n <= 89):
                        calificacionFinal = "B";
                        break;

                    case int n when (n >= 70 && n <= 79):
                        calificacionFinal = "C";
                        break;

                    case int n when (n >= 60 && n <= 69):
                        calificacionFinal = "D";
                        break;

                    case int n when (n >= 40 && n <= 59):
                        calificacionFinal = "E";
                        break;

                    case int n when (n >= 0 && n < 40):
                        calificacionFinal = "F";
                        break;

                    default:
                        MessageBox.Show("Por favor, ingresa una puntuación válida entre 0 y 100.", "Fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                MessageBox.Show($"La calificación del estudiante es: {calificacionFinal}", "Resultado de la Evaluación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox1.Focus();
            }catch
            {
                MessageBox.Show("Hubo un error en la proceso, ingrese nuevamente la calificacion.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
