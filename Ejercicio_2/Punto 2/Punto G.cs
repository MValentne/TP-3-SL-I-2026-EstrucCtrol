using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Punto_2
{
    public partial class Punto_G : Form
    {
        public Punto_G()
        {
            InitializeComponent();
        }

        private void Btn_Suma_Click(object sender, EventArgs e)
        {
            double temperaturaCelsius = Convert.ToDouble(Num_Ingresar.Value);
            double temperaturaFahrenheit = temperaturaCelsius * 9.0 / 5.0 + 32.0;
            double temperaturaKelvin = temperaturaCelsius + 273.15;
            Lbl_Confirmacion.Text = $"Resultados de las conversiones: \n Celsius: {temperaturaCelsius} °C{1}" +
                $"\nFahrenheit: {temperaturaFahrenheit} " +
                $"°F\n{1}Kelvin: {temperaturaKelvin} K\"";
        }

    }
}
