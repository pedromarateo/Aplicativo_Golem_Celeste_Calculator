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
    public partial class Frm_ItensFazerGolem : Form
    {
        public Frm_ItensFazerGolem()
        {
            InitializeComponent();
        }

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_FazerGolem1 f = new Frm_FazerGolem1();
            f.Show();
        }
    }
}
