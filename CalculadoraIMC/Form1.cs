using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            altura = Math.Pow(altura, 2);
            imc = Math.Round (peso / altura);


            txtResultado.Text = imc.ToString();

            if (imc < 18.5)
            {
                lblClassificacao.Text = ("Abaixo do peso!");
                lblClassificacao.ForeColor = Color.YellowGreen;
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                lblClassificacao.Text = ("Peso ideal!(Parabéns!)");
                lblClassificacao.ForeColor = Color.Green;
            }
            else if (imc >25.0 &&  imc < 29.9)
            {
                lblClassificacao.Text = ("Levemente acima do peso");
                lblClassificacao.ForeColor = Color.Orange;
            }
            else if (imc > 30.0 && imc < 34.9)
            {
                lblClassificacao.Text = ("Obesidade grau 1!");
                lblClassificacao.ForeColor = Color.OrangeRed;
            }
            else if (imc > 35.0 && imc < 39.9)
            {
                lblClassificacao.Text = ("Obsidade grau 2!(Severa!)");
                lblClassificacao.ForeColor = Color.DarkOrange;
            }
            else if (imc > 40.0)
            {
                lblClassificacao.Text = ("Obsidade 3(Mórbida!)");
                lblClassificacao.ForeColor = Color.Red;
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
