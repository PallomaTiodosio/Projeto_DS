using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DS
{
    public partial class frmVetorNotas : Form
    {
        double[] vetorNotas = new double[30];
        double soma = 0, x;
        int i;

        public frmVetorNotas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 30; i++)
            {
                x = Convert.ToDouble(txtNota.Text);
                vetorNotas[i] = x;
                soma = soma + vetorNotas[i];
                txtNota.Clear();
                txtNota.Focus();
                break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            soma = 0;
            txtMedia.Clear();
            txtNota.Clear();
            txtNota.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtMedia.Text = (soma / 30).ToString();
        }
    }
}
