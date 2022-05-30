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
    public partial class Frm_AprenderGolem : Form
    {

        public Frm_AprenderGolem(string quantidade)
        {
            
            int IntQuantidade = int.Parse(quantidade);
            int IntItem1 = IntQuantidade * 1;
            int IntItem2 = IntQuantidade * 1;
            int IntItem3 = IntQuantidade * 60;
            int IntItem4 = IntQuantidade * 500;
            int IntItem5 = IntQuantidade * 45;
            int IntItem6 = IntQuantidade * 20;

            var novaQuantidadeItem1 = IntItem1.ToString();
            var novaQuantidadeItem2 = IntItem2.ToString();
            var novaQuantidadeItem3 = IntItem3.ToString();
            var novaQuantidadeItem4 = IntItem4.ToString();
            var novaQuantidadeItem5 = IntItem5.ToString();
            var novaQuantidadeItem6 = IntItem6.ToString();


            InitializeComponent();
            Lbl_QuantidadeGolem.Text = quantidade;
            Lbl_quantItem1.Text = novaQuantidadeItem1;
            Lbl_quantItem2.Text = novaQuantidadeItem2;
            Lbl_quantItem3.Text = novaQuantidadeItem3;
            Lbl_quantItem4.Text = novaQuantidadeItem4;
            Lbl_quantItem5.Text = novaQuantidadeItem5;
            Lbl_quantItem6.Text = novaQuantidadeItem6;



        }

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Questao f = new Frm_Questao();
            f.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
