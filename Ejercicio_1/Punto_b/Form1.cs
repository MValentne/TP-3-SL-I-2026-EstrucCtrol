using System.Diagnostics.Eventing.Reader;

namespace Punto_b
{
    public partial class Form1 : Form
    {
        int[] numeros;
        int valor;
        int i = 0;
        int suma;
        public Form1()
        {
            InitializeComponent();
            numeros = new int[5];  //aca le damos el tamaño al array, de 5 numeros
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if ((i < 5) && (txtNumero.Text != string.Empty))
            {

                numeros[i] = int.Parse(txtNumero.Text);
                i++; // Suma 1 para q en el click siguiente guarde en la siguiente posición del array, es como el for.
                txtNumero.Clear();
                

                if (i < 5)
                {
                    lblNumeroIngresar.Text = "Ingrese el numero " + (i + 1) + ":";
                }
                else
                {
                    MessageBox.Show("Se han ingresado los 5 numeros");
                    lblNumeroIngresar.Text = "Arreglo lleno.";
                    btnIngresar.Enabled = false; //desactiva el botón al terminar
                    lblArray.Visible = true;
                    lblArray.Text = $"Numeros ingresados: {numeros[0]} {numeros[1]} {numeros[2]} {numeros[3]} {numeros[4]}";
                }
            }else
            {
                MessageBox.Show("Por favor ingrese un numero valido.");
            }
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            valor = numeros[0]; // Inicializa con el valor mínimo posible
            for (int i = 0; i < 5; i++)
            {
                if (numeros[i] > valor)
                {
                    valor = numeros[i];
                }
            }
            MessageBox.Show($"El numero mayor es: {valor}");
            lblMayor.Visible = true;
            lblMayor.Text = $"El numero mayor es: {valor}";
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            valor = numeros[0];

            for (int i = 0; i < 5; i++)
            {
                if (numeros[i] < valor)
                {
                    valor = numeros[i];
                }
            }
            MessageBox.Show($"El numero menor es: {valor}");
            lblMenor.Visible = true;
            lblMenor.Text = $"El numero menor es: {valor}";
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += numeros[i]; // es como poner suma = suma + numeros[i], va sumando cada numero del array a la variable suma.
            }
            double media = (double)suma / 5;
            MessageBox.Show($"La media de los numeros es: {media}");
            lblMedia.Visible = true;
            lblMedia.Text = $"La media de los numeros es: {media}";
        }
    }
}
