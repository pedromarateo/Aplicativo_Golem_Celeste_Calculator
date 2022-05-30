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
    public partial class Frm_ResultadoEH : Form
    {
        public static int QuantidadeGolem;
        public static int CustoTotal;

        public Frm_ResultadoEH()
        {
            InitializeComponent();
            var quantidadeGolem = Frm_FazerGolemEHQuantidade.QuantidadeGolemEH;
            int quantidadeGolemInt = int.Parse(quantidadeGolem);
            QuantidadeGolem = quantidadeGolemInt;

            Lbl_QuantidadeResposta.Text = quantidadeGolem.ToString();

            var custoEH = Frm_FazerGolemEH.precoEH;
            int custoEHInt = int.Parse(custoEH);

            int custoTotal = (custoEHInt * 192) * quantidadeGolemInt;
            CustoTotal = custoTotal;


            string custoTotalString = custoTotal.ToString();

            Lbl_ResultadoEH.Text = custoTotalString + " Gold";
        }

        private void Lbl_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            Frm_CalcularLucro f = new Frm_CalcularLucro();
            f.ShowDialog();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Frm_FazerGolemEHQuantidade f = new Frm_FazerGolemEHQuantidade();
            f.ShowDialog();
        }
    }
}
