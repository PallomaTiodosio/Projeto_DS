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
    public partial class frmVetorSorteio : Form
    {
        public frmVetorSorteio()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int[] vetorPares = new int[15];
            int i;
            Random num = new Random();

            for (i = 0; i < 15; i++)
            {
                vetorPares[i] = num.Next(1, 100);
                if (i % 2 == 0)
                {
                    txtGerar.Text += vetorPares[i].ToString() + Environment.NewLine;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGerar.Clear();
        }
    }
}
