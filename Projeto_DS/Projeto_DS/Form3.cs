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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMedia.Clear();
            txtNota.Clear();
            txtNota.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] vetorNota = new int[30];
            int i, soma = 0, x;
            double media;

            for (i = 0; i < 30; i++)
            {
                x = Convert.ToInt32(txtNota.Text);
                vetorNota[i] = x;
                soma = soma + vetorNota[i];
                txtNota.Clear();
               
            }
            media = soma / 30;
            txtMedia.Text = media.ToString();
        }
    }
}
