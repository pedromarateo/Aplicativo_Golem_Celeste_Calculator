namespace WindowsFormsApp1
{
    partial class Frm_ResultadoLucroVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ResultadoLucroVenda));
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Lucro = new System.Windows.Forms.Label();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Lbl_DesejaContinuar = new System.Windows.Forms.Label();
            this.Lbl_QuantidadeResposta = new System.Windows.Forms.Label();
            this.Lbl_QuantidadeComplemento = new System.Windows.Forms.Label();
            this.Lbl_ResultadoComplemento = new System.Windows.Forms.Label();
            this.Lbl_LucroOuPrejuizo = new System.Windows.Forms.Label();
            this.Lbl_HouveLucroComplemento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "O Total de Gold arrecadado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Lucro
            // 
            this.Lbl_Lucro.AutoSize = true;
            this.Lbl_Lucro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Lucro.Location = new System.Drawing.Point(258, 130);
            this.Lbl_Lucro.Name = "Lbl_Lucro";
            this.Lbl_Lucro.Size = new System.Drawing.Size(80, 22);
            this.Lbl_Lucro.TabIndex = 31;
            this.Lbl_Lucro.Text = "Resposta";
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.Location = new System.Drawing.Point(158, 215);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(123, 36);
            this.Btn_Continue.TabIndex = 42;
            this.Btn_Continue.Text = "Sim, quero";
            this.Btn_Continue.UseVisualStyleBackColor = true;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(158, 257);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(123, 36);
            this.Btn_Exit.TabIndex = 44;
            this.Btn_Exit.Text = "Não. Encerrar Programa";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lbl_DesejaContinuar
            // 
            this.Lbl_DesejaContinuar.AutoSize = true;
            this.Lbl_DesejaContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DesejaContinuar.Location = new System.Drawing.Point(33, 188);
            this.Lbl_DesejaContinuar.Name = "Lbl_DesejaContinuar";
            this.Lbl_DesejaContinuar.Size = new System.Drawing.Size(405, 16);
            this.Lbl_DesejaContinuar.TabIndex = 45;
            this.Lbl_DesejaContinuar.Text = "Deseja Calcular o Valor total com a subtração do preço do Token?";
            // 
            // Lbl_QuantidadeResposta
            // 
            this.Lbl_QuantidadeResposta.AutoSize = true;
            this.Lbl_QuantidadeResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_QuantidadeResposta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QuantidadeResposta.Location = new System.Drawing.Point(258, 70);
            this.Lbl_QuantidadeResposta.Name = "Lbl_QuantidadeResposta";
            this.Lbl_QuantidadeResposta.Size = new System.Drawing.Size(21, 23);
            this.Lbl_QuantidadeResposta.TabIndex = 54;
            this.Lbl_QuantidadeResposta.Text = "1";
            // 
            // Lbl_QuantidadeComplemento
            // 
            this.Lbl_QuantidadeComplemento.AutoSize = true;
            this.Lbl_QuantidadeComplemento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QuantidadeComplemento.Location = new System.Drawing.Point(72, 72);
            this.Lbl_QuantidadeComplemento.Name = "Lbl_QuantidadeComplemento";
            this.Lbl_QuantidadeComplemento.Size = new System.Drawing.Size(180, 21);
            this.Lbl_QuantidadeComplemento.TabIndex = 53;
            this.Lbl_QuantidadeComplemento.Text = "Quantidade de Golens:";
            // 
            // Lbl_ResultadoComplemento
            // 
            this.Lbl_ResultadoComplemento.AutoSize = true;
            this.Lbl_ResultadoComplemento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ResultadoComplemento.Location = new System.Drawing.Point(108, 130);
            this.Lbl_ResultadoComplemento.Name = "Lbl_ResultadoComplemento";
            this.Lbl_ResultadoComplemento.Size = new System.Drawing.Size(100, 21);
            this.Lbl_ResultadoComplemento.TabIndex = 55;
            this.Lbl_ResultadoComplemento.Text = "Lucro Final:";
            // 
            // Lbl_LucroOuPrejuizo
            // 
            this.Lbl_LucroOuPrejuizo.AutoSize = true;
            this.Lbl_LucroOuPrejuizo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_LucroOuPrejuizo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LucroOuPrejuizo.Location = new System.Drawing.Point(258, 102);
            this.Lbl_LucroOuPrejuizo.Name = "Lbl_LucroOuPrejuizo";
            this.Lbl_LucroOuPrejuizo.Size = new System.Drawing.Size(2, 23);
            this.Lbl_LucroOuPrejuizo.TabIndex = 64;
            // 
            // Lbl_HouveLucroComplemento
            // 
            this.Lbl_HouveLucroComplemento.AutoSize = true;
            this.Lbl_HouveLucroComplemento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HouveLucroComplemento.Location = new System.Drawing.Point(108, 102);
            this.Lbl_HouveLucroComplemento.Name = "Lbl_HouveLucroComplemento";
            this.Lbl_HouveLucroComplemento.Size = new System.Drawing.Size(117, 21);
            this.Lbl_HouveLucroComplemento.TabIndex = 61;
            this.Lbl_HouveLucroComplemento.Text = "Houve Lucro?";
            // 
            // Frm_ResultadoLucroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Lbl_LucroOuPrejuizo);
            this.Controls.Add(this.Lbl_HouveLucroComplemento);
            this.Controls.Add(this.Lbl_ResultadoComplemento);
            this.Controls.Add(this.Lbl_QuantidadeResposta);
            this.Controls.Add(this.Lbl_QuantidadeComplemento);
            this.Controls.Add(this.Lbl_DesejaContinuar);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.Lbl_Lucro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ResultadoLucroVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor Arrecadado nas Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Lucro;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lbl_DesejaContinuar;
        private System.Windows.Forms.Label Lbl_QuantidadeResposta;
        private System.Windows.Forms.Label Lbl_QuantidadeComplemento;
        private System.Windows.Forms.Label Lbl_ResultadoComplemento;
        private System.Windows.Forms.Label Lbl_LucroOuPrejuizo;
        private System.Windows.Forms.Label Lbl_HouveLucroComplemento;
    }
}