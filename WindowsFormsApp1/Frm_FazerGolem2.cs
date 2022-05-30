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
    public partial class Frm_FazerGolem2 : Form
    {
        public Frm_FazerGolem2()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_FazerGolem1 f = new Frm_FazerGolem1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_FazerGolemEH f = new Frm_FazerGolemEH();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_FazerGolemAV f = new Frm_FazerGolemAV();
            f.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
