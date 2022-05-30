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
    public partial class Frm_FazerGolemEH : Form
    {
        public static string precoEH;
        public static bool EHEscolhido = false;

        public Frm_FazerGolemEH()
        {
            InitializeComponent();
            EHEscolhido = true;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_FazerGolem2 f = new Frm_FazerGolem2();
            f.Show();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            precoEH = Msk_PrecoEH.Text;            
            if (Msk_PrecoEH.Text == "0" || Msk_PrecoEH.Text == "")
            {
                MessageBox.Show("Dado inválido. Por favor, insira um valor maior que 0", "Mensagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_FazerGolemEHQuantidade f = new Frm_FazerGolemEHQuantidade();
                f.ShowDialog();
            }
            
        }

        private void Msk_PrecoEH_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
