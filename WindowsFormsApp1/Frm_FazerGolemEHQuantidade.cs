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
    public partial class Frm_FazerGolemEHQuantidade : Form
    {
        public static string QuantidadeGolemEH;

        public Frm_FazerGolemEHQuantidade()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_FazerGolemEH f = new Frm_FazerGolemEH();
            f.Show();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            QuantidadeGolemEH = Msk_QuantidadeCharEH.Text;

            if (Msk_QuantidadeCharEH.Text == "0" || Msk_QuantidadeCharEH.Text == "")
            {
                MessageBox.Show("Dado inválido. Por favor, insira um valor maior que 0", "Mensagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_ResultadoEH f = new Frm_ResultadoEH();
                f.ShowDialog();
            }
            
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
