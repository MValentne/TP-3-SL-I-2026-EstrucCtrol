namespace Punto_d
{
    public partial class Form1 : Form
    {
        public int año;
        public int mes;
        public int dia;
        string[] separarfecha;
        int fechaNacimiento;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarAño_Click(object sender, EventArgs e)
        {
            // para el mtbFechitaNacimiento
            separarfecha = new string[3];
            if (mtbFechitaNacimiento.MaskCompleted == false)
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Por favor, ingrese una fecha de nacimiento válida.";   
                MessageBox.Show("Por favor, ingrese una fecha de nacimiento válida.");
                return;
            }

            separarfecha = mtbFechitaNacimiento.Text.Split('/');
            dia = int.Parse(separarfecha[0]);
            mes = int.Parse(separarfecha[1]);
            año = int.Parse(separarfecha[2]) + 2000;

            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
            {
                lblResultado.Visible = true;
                lblResultado.Text = "El año es bisiesto.";
                MessageBox.Show("El año es bisiesto.");
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "El año no es bisiesto.";
                MessageBox.Show("El año no es bisiesto.");
            }

            /* para el txtFechaNacimiento
            fechaNacimiento = int.Parse(txtFechaNacimiento.Text);
            if (fechaNacimiento % 4 == 0 && (fechaNacimiento % 100 != 0 || fechaNacimiento % 400 == 0))
            {
                lblResultado.Visible = true;
                lblResultado.Text = "El año es bisiesto.";
                MessageBox.Show("El año es bisiesto.");
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "El año no es bisiesto.";
                MessageBox.Show("El año no es bisiesto.");
            }
        
            */
        }
    }
}
