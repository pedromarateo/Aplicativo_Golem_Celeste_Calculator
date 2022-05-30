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
    public partial class Frm_FazerGolem1 : Form
    {
        public Frm_FazerGolem1()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_GolemCeleste f = new Frm_GolemCeleste();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ItensFazerGolem f = new Frm_ItensFazerGolem();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_FazerGolem2 f = new Frm_FazerGolem2();
            f.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
