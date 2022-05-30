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
    public partial class Frm_CalculoToken : Form
    {
        public static string valorToken;
        public Frm_CalculoToken()
        {
            InitializeComponent();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            valorToken = Msk_PrecoToken.Text;

            if (Msk_PrecoToken.Text == "0" || Msk_PrecoToken.Text == "")
            {
                MessageBox.Show("Dado inválido. Por favor, insira um valor maior que 0", "Mensagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResultadoFinalToken f = new ResultadoFinalToken();
                f.ShowDialog();
            }            
        }
    }
}
