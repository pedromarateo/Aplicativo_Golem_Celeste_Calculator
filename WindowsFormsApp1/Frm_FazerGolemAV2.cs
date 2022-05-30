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
    public partial class Frm_FazerGolemAV2 : Form
    {
        public static string precoAV;

        public Frm_FazerGolemAV2()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {

            
            this.Close();
            Frm_FazerGolemAV f = new Frm_FazerGolemAV();
            f.ShowDialog();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            if (Msk_PrecoAV.Text == "0" || Msk_PrecoAV.Text == "")
            {
                MessageBox.Show("Dado inválido. Por favor, insira um valor maior que 0", "Mensagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                precoAV = Msk_PrecoAV.Text;
                Frm_FazerGolemAVQuantidade f = new Frm_FazerGolemAVQuantidade();
                f.ShowDialog();
            }
            
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
