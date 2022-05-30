namespace WindowsFormsApp1
{
    partial class ResultadoFinalToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoFinalToken));
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Lbl_QuantidadeResposta = new System.Windows.Forms.Label();
            this.Lbl_QuantidadeComplemento = new System.Windows.Forms.Label();
            this.Lbl_HouveLucroComplemento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_PrecoToken = new System.Windows.Forms.Label();
            this.Lbl_ResultadoComplemento = new System.Windows.Forms.Label();
            this.Lbl_LucroOuPrejuizo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(258, 158);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(80, 22);
            this.Lbl_Resultado.TabIndex = 33;
            this.Lbl_Resultado.Text = "Resposta";
            this.Lbl_Resultado.Click += new System.EventHandler(this.Lbl_Resultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "O Total de Gold arrecadado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(158, 215);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(123, 36);
            this.Btn_Cancel.TabIndex = 34;
            this.Btn_Cancel.Text = "Exit";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lbl_QuantidadeResposta
            // 
            this.Lbl_QuantidadeResposta.AutoSize = true;
            this.Lbl_QuantidadeResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_QuantidadeResposta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QuantidadeResposta.Location = new System.Drawing.Point(258, 70);
            this.Lbl_QuantidadeResposta.Name = "Lbl_QuantidadeResposta";
            this.Lbl_QuantidadeResposta.Size = new System.Drawing.Size(21, 23);
            this.Lbl_QuantidadeResposta.TabIndex = 55;
            this.Lbl_QuantidadeResposta.Text = "1";
            this.Lbl_QuantidadeResposta.Click += new System.EventHandler(this.Lbl_QuantidadeResposta_Click);
            // 
            // Lbl_QuantidadeComplemento
            // 
            this.Lbl_QuantidadeComplemento.AutoSize = true;
            this.Lbl_QuantidadeComplemento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QuantidadeComplemento.Location = new System.Drawing.Point(72, 72);
            this.Lbl_QuantidadeComplemento.Name = "Lbl_QuantidadeComplemento";
            this.Lbl_QuantidadeComplemento.Size = new System.Drawing.Size(180, 21);
            this.Lbl_QuantidadeComplemento.TabIndex = 54;
            this.Lbl_QuantidadeComplemento.Text = "Quantidade de Golens:";
            // 
            // Lbl_HouveLucroComplemento
            // 
            this.Lbl_HouveLucroComplemento.AutoSize = true;
            this.Lbl_HouveLucroComplemento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HouveLucroComplemento.Location = new System.Drawing.Point(108, 130);
            this.Lbl_HouveLucroComplemento.Name = "Lbl_HouveLucroComplemento";
            this.Lbl_HouveLucroComplemento.Size = new System.Drawing.Size(117, 21);
            this.Lbl_HouveLucroComplemento.TabIndex = 56;
            this.Lbl_HouveLucroComplemento.Text = "Houve Lucro?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Considerando Token a:";
            // 
            // Lbl_PrecoToken
            // 
            this.Lbl_PrecoToken.AutoSize = true;
            this.Lbl_PrecoToken.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_PrecoToken.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PrecoToken.Location = new System.Drawing.Point(258, 102);
            this.Lbl_PrecoToken.Name = "Lbl_PrecoToken";
            this.Lbl_PrecoToken.Size = new System.Drawing.Size(21, 23);
            this.Lbl_PrecoToken.TabIndex = 58;
            this.Lbl_PrecoToken.Text = "1";
            // 
            // Lbl_ResultadoComplemento
            // 
            this.Lbl_ResultadoComplemento.AutoSize = true;
            this.Lbl_ResultadoComplemento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ResultadoComplemento.Location = new System.Drawing.Point(108, 158);
            this.Lbl_ResultadoComplemento.Name = "Lbl_ResultadoComplemento";
            this.Lbl_ResultadoComplemento.Size = new System.Drawing.Size(100, 21);
            this.Lbl_ResultadoComplemento.TabIndex = 59;
            this.Lbl_ResultadoComplemento.Text = "Lucro Final:";
            // 
            // Lbl_LucroOuPrejuizo
            // 
            this.Lbl_LucroOuPrejuizo.AutoSize = true;
            this.Lbl_LucroOuPrejuizo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_LucroOuPrejuizo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LucroOuPrejuizo.Location = new System.Drawing.Point(258, 130);
            this.Lbl_LucroOuPrejuizo.Name = "Lbl_LucroOuPrejuizo";
            this.Lbl_LucroOuPrejuizo.Size = new System.Drawing.Size(2, 23);
            this.Lbl_LucroOuPrejuizo.TabIndex = 60;
            // 
            // ResultadoFinalToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Lbl_LucroOuPrejuizo);
            this.Controls.Add(this.Lbl_ResultadoComplemento);
            this.Controls.Add(this.Lbl_PrecoToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_HouveLucroComplemento);
            this.Controls.Add(this.Lbl_QuantidadeResposta);
            this.Controls.Add(this.Lbl_QuantidadeComplemento);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultadoFinalToken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucro Final (Com Token Incluso)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label Lbl_QuantidadeResposta;
        private System.Windows.Forms.Label Lbl_QuantidadeComplemento;
        private System.Windows.Forms.Label Lbl_HouveLucroComplemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_PrecoToken;
        private System.Windows.Forms.Label Lbl_ResultadoComplemento;
        private System.Windows.Forms.Label Lbl_LucroOuPrejuizo;
    }
}