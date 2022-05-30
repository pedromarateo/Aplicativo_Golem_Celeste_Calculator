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
    public partial class Frm_CalcularLucro : Form
    {
        public static string valorGolem;

        public Frm_CalcularLucro()
        {
            InitializeComponent();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            valorGolem = Msk_PrecoGolem.Text;

            if (Msk_PrecoGolem.Text == "0" || Msk_PrecoGolem.Text == "")
            {
                MessageBox.Show("Dado inválido. Por favor, insira um valor maior que 0", "Mensagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_ResultadoLucroVenda f = new Frm_ResultadoLucroVenda();
                f.ShowDialog();
            }            
        }

        private void Msk_PrecoGolem_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
