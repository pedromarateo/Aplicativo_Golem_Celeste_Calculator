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
    public partial class Frm_ResultadoAV : Form
    {
        public static int QuantidadeGolem;
        public static int CustoTotal;

        public Frm_ResultadoAV()
        {
            InitializeComponent();
            var precoBFF = Frm_FazerGolemAV.precoBFF;
            int precoBFFInt = int.Parse(precoBFF);

            var precoAV = Frm_FazerGolemAV2.precoAV;
            int precoAVInt = int.Parse(precoAV);

            var quantidade = Frm_FazerGolemAVQuantidade.quantidade;
            int quantidadeInt = int.Parse(quantidade);
            QuantidadeGolem = quantidadeInt;

            Lbl_QuantidadeResposta.Text = quantidade;

            int custoTotal = ((precoBFFInt * 300) + (precoAVInt * 30)) * quantidadeInt;
            CustoTotal = custoTotal;
            string custoTotalString = custoTotal.ToString();

            Lbl_ResultadoAV.Text = custoTotalString;
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
    }
}
