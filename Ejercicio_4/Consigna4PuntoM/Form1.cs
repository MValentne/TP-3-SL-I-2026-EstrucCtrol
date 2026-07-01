using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consigna4PuntoM
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
                string textoUsuario = this.textBox1.Text;
                int NumeroEntero;
                int.TryParse(textoUsuario, out NumeroEntero);

                if (NumeroEntero < 1 || NumeroEntero > 7)
                {
                    throw new Exception("Ingrese un número correspondiente a un día de la semana (Del 1 al 7)");   
                }
                {

                    switch (NumeroEntero)
                    {

                        case 1:
                            MessageBox.Show("El dia de la semana es Lunes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case 2:
                            MessageBox.Show("El dia de la semana es Martes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case 3:
                            MessageBox.Show("El dia de la semana es Miercoles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case 4:
                            MessageBox.Show("El dia de la semana es Jueves", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case 5:
                            MessageBox.Show("El dia de la semana es Viernes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case 6:
                            MessageBox.Show("El dia de la semana Sabado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case 7:
                            MessageBox.Show("El dia de la semana es Domingo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
