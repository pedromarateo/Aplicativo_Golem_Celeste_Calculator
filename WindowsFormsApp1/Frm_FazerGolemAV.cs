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
    public partial class Frm_FazerGolemAV : Form
    {
        public static string precoBFF;

        public Frm_FazerGolemAV()
        {
            InitializeComponent();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            precoBFF = Msk_PrecoBFF.Text;
            if (Msk_PrecoBFF.Text == "0" || Msk_PrecoBFF.Text == "")
            {
                MessageBox.Show("Dado inválido. Por favor, insira um valor maior que 0", "Mensagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_FazerGolemAV2 f = new Frm_FazerGolemAV2();
                f.ShowDialog();
            }            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_FazerGolem2 f = new Frm_FazerGolem2();
            f.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
