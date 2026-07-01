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
            try
            {
                double temperaturaCelsius = Convert.ToDouble(Num_Ingresar.Value);

                if (temperaturaCelsius > 250)
                {
                    throw new Exception("Supera el máximo indicado (250), ingrese otra temperatura");
                }
                if (temperaturaCelsius < -273.15)
                {
                    throw new Exception("Es inferior al límite establecido (-273.15, cero absoluto). Ingrese otra temperatura");
                }

                double temperaturaFahrenheit = temperaturaCelsius * 9.0 / 5.0 + 32.0;
                double temperaturaKelvin = temperaturaCelsius + 273.15;
                Lbl_Confirmacion.Text = $"Resultados de las conversiones:\nCelsius: {temperaturaCelsius} °C" +
                    $"\nFahrenheit: {temperaturaFahrenheit} °F" +
                    $"\nKelvin: {temperaturaKelvin} K";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }
}}
