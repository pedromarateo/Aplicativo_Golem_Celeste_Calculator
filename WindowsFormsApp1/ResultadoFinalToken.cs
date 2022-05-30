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
    public partial class ResultadoFinalToken : Form
    {
        public ResultadoFinalToken()
        {
            InitializeComponent();

            var valorToken = Frm_CalculoToken.valorToken;
            int valorTokenInt = int.Parse(valorToken);
            Lbl_PrecoToken.Text = valorTokenInt.ToString();




            if (Frm_FazerGolemEH.EHEscolhido == true)
            {
                Lbl_QuantidadeResposta.Text = Frm_ResultadoEH.QuantidadeGolem.ToString();
                int lucroComEH = Frm_ResultadoLucroVenda.LucroComEH;
                int resultadoFinal = lucroComEH - valorTokenInt;
                string resultadoFinalString = resultadoFinal.ToString();
                if(resultadoFinal < 0)
                {
                    Lbl_LucroOuPrejuizo.Text = "Não";
                    Lbl_ResultadoComplemento.Text = "Prejuizo Final:";
                    Lbl_Resultado.Text = resultadoFinalString + " Gold";
                }
                else
                {
                    Lbl_LucroOuPrejuizo.Text = "Sim";
                    Lbl_ResultadoComplemento.Text = "Lucro Final:";
                    Lbl_Resultado.Text = resultadoFinalString + " Gold";
                }
            }
            else
            {
                Lbl_QuantidadeResposta.Text = Frm_ResultadoAV.QuantidadeGolem.ToString();
                int lucroComAV = Frm_ResultadoLucroVenda.LucroComAV;
                int resultadoFinal = lucroComAV - valorTokenInt;
                string resultadoFinalString = resultadoFinal.ToString();
                if (resultadoFinal < 0)
                {
                    Lbl_LucroOuPrejuizo.Text = "Não";
                    Lbl_ResultadoComplemento.Text = "Prejuizo Final:";
                    Lbl_Resultado.Text = resultadoFinalString;
                }
                else
                {
                    Lbl_LucroOuPrejuizo.Text = "Sim";
                    Lbl_ResultadoComplemento.Text = "Lucro Final:";
                    Lbl_Resultado.Text = resultadoFinalString;
                }
            }

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lbl_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_QuantidadeResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
