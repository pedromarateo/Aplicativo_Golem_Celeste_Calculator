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
    public partial class Frm_FazerGolemAVQuantidade : Form
    {
        public static string quantidade;

        public Frm_FazerGolemAVQuantidade()
        {
            InitializeComponent();
            
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            quantidade = Msk_QuantidadeCharAV.Text;

            if (Msk_QuantidadeCharAV.Text == "0" || Msk_QuantidadeCharAV.Text == "")
            {
                MessageBox.Show("Dado inválido. Por favor, insira um valor maior que 0", "Mensagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_ResultadoAV f = new Frm_ResultadoAV();
                f.ShowDialog();
            }            
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
