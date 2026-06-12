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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conexion con la consigna h
            Form ventanaH = new ConsignaH();
            ventanaH.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ventanaI = new ConsignaI();
            ventanaI.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ventanaJ = new ConsignaJ();
            ventanaJ.ShowDialog();
        }
    }
}
