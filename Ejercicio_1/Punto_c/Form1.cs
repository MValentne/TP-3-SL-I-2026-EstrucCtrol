namespace Punto_c
{
    public partial class Form1 : Form
    {
        int i = 0;
        int[] numeros = new int[3];
        int numero;
        int suma;
        double producto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if ((i < 3) && (txtNumero.Text != ""))
            {
                numeros[i] = int.Parse(txtNumero.Text);
                i++;
                if (i < 3)
                {
                    lblPongaNumero.Text = "Ponga el número " + (i + 1).ToString();
                    txtNumero.Clear();
                }
                else
                {
                    lblPongaNumero.Text = "Ya se han ingresado los 3 números";
                    MessageBox.Show("Ya se han ingresado los 3 números");
                    txtNumero.Clear();
                    btnIngresar.Enabled = false;
                    lblArrayNumeros.Visible = true;
                    lblArrayNumeros.Text = "Los números ingresados son: " + numeros[0].ToString() + ", " + numeros[1].ToString() + ", " + numeros[2].ToString();
                }
            }
            else
            {
                MessageBox.Show("No se pueden ingresar más números o el campo está vacío");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (numeros[0] < 0)
            {
                suma = numeros[0] + numeros[1] + numeros[2];
                MessageBox.Show("La suma de los números es: " + suma.ToString());
                lblPrimerCaso.Visible = true;
                lblPrimerCaso.Text = "Primer caso el primer numero es menor a cero: " + suma.ToString();
            }
            else
            {
                producto = numeros[0] * numeros[1] * numeros[2];
                MessageBox.Show("El producto de los números es: " + producto.ToString());
                lblPrimerCaso.Visible = true;
                lblPrimerCaso.Text = "Segundo caso el primer numero es mayor o igual a cero: " + producto.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
