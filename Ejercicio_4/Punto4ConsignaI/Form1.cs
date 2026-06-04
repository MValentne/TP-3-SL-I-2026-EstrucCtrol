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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int mes))
            {
                switch (mes)
                {

                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        MessageBox.Show("El mes tiene 31 dias.");
                        break;



                    case 4: case 6: case 9: case 11:
                        MessageBox.Show("El mes tiene 30 dias.");
                        break;


                    case 2:

                        MessageBox.Show("Febrero detectado. Se abrirá la verificación de año bisiesto.", "Aviso");

                        Form2 form2 = new Form2();

                        form2.ShowDialog();
                        break;

                    default: 
                        MessageBox.Show ("Error: El numero del mes debe estar entre 1 y 12.");
                        break;
                }
            } else
            { 
                MessageBox.Show("Error: Por favor ingrese un número válido para el mes.");
            }

            textBox1.Clear();
        }
    }


    
}
