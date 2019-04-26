using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1_Dimensionamento_Viga
{
    public partial class Form1 : Form
    {
        public double Ecmax = 0;
        public double b = 0;
        public double d = 0;
        public double dl = 0;
        public double Eaco = 0;
        public double As = 0;
        public double Asl = 0;
        public double fck = 0;
        public double fyk = 0;
        public double lambda = 0;
        public double alfa = 0;
        public double[] resultados = new double[4];
        public double Es = 0;
        public double Esl = 0;
        public double x = 0;
        FuncoesCalculo calculos = new FuncoesCalculo();

        public Form1()
        {
            InitializeComponent();
        }
        //CÁLCULO DE ALFA E LAMBDA A PARTIR DO FCK FORNECIDO PELO USUÁRIO
        private void txtFck_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fck = Convert.ToDouble(txtFck.Text);
                if (fck <= 50)
                {
                    lambda = 0.8;
                    alfa = 0.85;
                }
                else
                {
                    lambda = 0.8 - ((fck - 50) / 400);
                    alfa = 0.85 * (1 - ((fck - 50) / 200));
                }
                txtLambda.Text = Convert.ToString(lambda);
                txtAlfa.Text = Convert.ToString(alfa);
            }
            catch { }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Ecmax = Convert.ToDouble(txtEcmax.Text);
            b = Convert.ToDouble(txtLarguraViga.Text);
            d = Convert.ToDouble(txtAlturaUtil.Text);
            dl = Convert.ToDouble(txtDlinha.Text);
            Eaco = Convert.ToDouble(txtModuloElasticidadeAco.Text);
            As = Convert.ToDouble(txtAs.Text);
            Asl = Convert.ToDouble(txtAslinha.Text);
            fck = Convert.ToDouble(txtFck.Text);
            fyk = Convert.ToDouble(txtFyk.Text);
            lambda = Convert.ToDouble(txtLambda.Text);
            alfa = Convert.ToDouble(txtAlfa.Text);

            resultados = calculos.calculaMomentoFletor1(Eaco, d, Ecmax, dl, fyk, fck, alfa, lambda, b, As, Asl);

            txtMomentoFletor.Text = Convert.ToString(resultados[0]);
            txtEsl.Text = Convert.ToString(resultados[3]);
            txtEs.Text = Convert.ToString(resultados[2]);
            txtX.Text = Convert.ToString(resultados[1]);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
