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
    public partial class Frm_ResultadoLucroVenda : Form
    {
        public static int LucroComEH;
        public static int LucroComAV;

        public Frm_ResultadoLucroVenda()
        {           

            InitializeComponent();
            var precoGolem = Frm_CalcularLucro.valorGolem;
            int precoGolemInt = int.Parse(precoGolem);
            if (Frm_FazerGolemEH.EHEscolhido == true)
            {
                Lbl_QuantidadeResposta.Text = Frm_ResultadoEH.QuantidadeGolem.ToString();
                int precoGolemXChar = precoGolemInt * Frm_ResultadoEH.QuantidadeGolem;
                int lucroGolemEH = precoGolemXChar - Frm_ResultadoEH.CustoTotal;
                LucroComEH = lucroGolemEH;
                string lucroString = lucroGolemEH.ToString();
                if (lucroGolemEH < 0)
                {
                    Lbl_LucroOuPrejuizo.Text = "Não";
                    Lbl_ResultadoComplemento.Text = "Prejuizo Final:";
                    Lbl_Lucro.Text = lucroString;
                }
                else
                {
                    Lbl_ResultadoComplemento.Text = "Lucro Final:";
                    Lbl_LucroOuPrejuizo.Text = "Sim";
                    Lbl_Lucro.Text = lucroString;
                }
               
            }
            else
            {
                Lbl_QuantidadeResposta.Text = Frm_ResultadoAV.QuantidadeGolem.ToString();
                int precoGolemXChar = precoGolemInt * Frm_ResultadoAV.QuantidadeGolem;
                int lucroGolemAV = precoGolemXChar - Frm_ResultadoAV.CustoTotal;
                LucroComAV = lucroGolemAV;
                string lucroGolemAVString = lucroGolemAV.ToString();
                if (lucroGolemAV < 0)
                {
                    Lbl_ResultadoComplemento.Text = "Prejuizo Final:";
                    Lbl_LucroOuPrejuizo.Text = "Não";
                    Lbl_Lucro.Text = lucroGolemAVString;
                }
                else
                {
                    Lbl_ResultadoComplemento.Text = "Lucro Final:";
                    Lbl_LucroOuPrejuizo.Text = "Sim";
                    Lbl_Lucro.Text = lucroGolemAVString;
                }
                
            }
            
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            Frm_CalculoToken f = new Frm_CalculoToken();
            f.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
