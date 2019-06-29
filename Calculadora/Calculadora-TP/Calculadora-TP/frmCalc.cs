using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_TP
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Numero1 = Double.Parse(txtN1.Text);
            calculadora.Numero2 = Double.Parse(txtN2.Text);
            txtResultado.Text = Convert.ToString(calculadora.Multiplica());
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Numero1 = Double.Parse(txtN1.Text);
            calculadora.Numero2 = Double.Parse(txtN2.Text);
            txtResultado.Text = Convert.ToString(calculadora.Expo());
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {


            //Instanciação Tornar a classe um objeto (real)
            Calculadora calculadora = new Calculadora();

           calculadora.Numero1 = Double.Parse(txtN1.Text);
           calculadora.Numero2 = Double.Parse(txtN2.Text);
           txtResultado.Text = Convert.ToString(calculadora.Soma());         

        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Numero1 = Convert.ToDouble(txtN1.Text);
            calculadora.Numero2 = Convert.ToDouble(txtN2.Text);
            txtResultado.Text = Convert.ToString(calculadora.Subtrai());

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Numero1 = Convert.ToDouble(txtN1.Text);
            calculadora.Numero2 = Convert.ToDouble(txtN2.Text);
            txtResultado.Text = Convert.ToString(calculadora.Div());
        }
    }
}
