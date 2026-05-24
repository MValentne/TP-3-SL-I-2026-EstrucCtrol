namespace Punto_a
{
    public partial class Form1 : Form
    {
        int nota;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificarNota_Click(object sender, EventArgs e)
        {
            nota = int.Parse(txtPuntuacion.Text);
            if ((nota >= 90) && (nota <= 100))
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Su nota es A! :)";
            }
            else
            {
                if ((nota >= 80) && (nota <= 89))
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Su nota es B! :)";
                }
                else
                {
                    if ((nota >= 70) && (nota <= 79))
                    {
                        lblResultado.Visible = true;
                        lblResultado.Text = "Su nota es C!";
                    }
                    else
                    {
                        if ((nota >= 60) && (nota <= 69))
                        {
                            lblResultado.Visible = true;
                            lblResultado.Text = "Su nota es D";
                        }
                        else
                        {
                            if ((nota >= 40) && (nota <= 59))
                            {
                                lblResultado.Visible = true;
                                lblResultado.Text = "Su nota es E :(";
                            }
                            else
                            {
                                lblResultado.Visible = true;
                                lblResultado.Text = "Su nota es F :(";

                            }
                        }
                    }
                }
            }
        }
    }
}
