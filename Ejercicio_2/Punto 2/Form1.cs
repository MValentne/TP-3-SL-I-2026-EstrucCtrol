namespace Punto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form MostrarPuntoE = new Punto_E();
            MostrarPuntoE.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form MostrarPuntoF = new Punto_F();
            MostrarPuntoF.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form MostrarPuntoG = new Punto_G();
            MostrarPuntoG.ShowDialog();
        }
    }
}
