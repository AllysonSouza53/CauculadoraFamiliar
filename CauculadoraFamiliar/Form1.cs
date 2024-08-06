using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CauculadoraFamiliar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Caucular_Click(object sender, EventArgs e)
        {
            double GT = int.Parse(CTenergia.Text);
            GT += int.Parse(CTagua.Text);
            GT += int.Parse(CTtv.Text);
            GT += int.Parse(CTalimentacao.Text);
            GT += int.Parse(CToutros.Text);

            TextoTG.Text = GT.ToString();

            double RF = int.Parse(CTrendaf.Text);

            TextoSaldo.Text = (RF-GT).ToString();
        }

        private void NovoCalculo_Click(object sender, EventArgs e)
        {
            CTrendaf.Text = " ";
            CTenergia.Text = " ";
            CTagua.Text = " ";
            CTtv.Text = " ";
            CTalimentacao.Text = " ";
            CToutros.Text = " ";
            TextoTG.Text = " ";
            TextoSaldo.Text = " ";

            CTrendaf.Focus();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
