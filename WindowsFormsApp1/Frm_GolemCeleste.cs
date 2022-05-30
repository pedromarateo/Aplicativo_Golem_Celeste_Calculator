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
    public partial class Frm_GolemCeleste : Form
    {
        public Frm_GolemCeleste()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Questao f = new Frm_Questao();
            f.ShowDialog();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Questao f = new Frm_Questao();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_FazerGolem1 f = new Frm_FazerGolem1();
            f.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
