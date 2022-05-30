using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Questao : Form
    {
        public static string RespostaMskQuantidade;

        public Frm_Questao()
        {
            InitializeComponent();
            Msk_resposta.Text = "1";
            Msk_resposta.Focus();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (Msk_resposta.Text != "" && Msk_resposta.Text != "0")
            {
                RespostaMskQuantidade = Msk_resposta.Text;
                Frm_AprenderGolem f = new Frm_AprenderGolem(RespostaMskQuantidade);
                f.ShowDialog();

                Msk_resposta.Text = "1";
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_GolemCeleste f = new Frm_GolemCeleste();
            f.Show();
        }

        private void Msk_resposta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
