namespace WindowsFormsApp1
{
    partial class Frm_ResultadoEH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ResultadoEH));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Lbl_ResultadoEH = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.Lbl_QuantidadeComplemento = new System.Windows.Forms.Label();
            this.Lbl_ResultadoComplemento = new System.Windows.Forms.Label();
            this.Lbl_QuantidadeResposta = new System.Windows.Forms.Label();
            this.Lbl_Question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(363, 236);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 41;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(363, 265);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 40;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lbl_ResultadoEH
            // 
            this.Lbl_ResultadoEH.AutoSize = true;
            this.Lbl_ResultadoEH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_ResultadoEH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ResultadoEH.Location = new System.Drawing.Point(258, 102);
            this.Lbl_ResultadoEH.Name = "Lbl_ResultadoEH";
            this.Lbl_ResultadoEH.Size = new System.Drawing.Size(175, 23);
            this.Lbl_ResultadoEH.TabIndex = 37;
            this.Lbl_ResultadoEH.Text = "Custo TotalResultado";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(79, 26);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(281, 26);
            this.Lbl_Titulo.TabIndex = 36;
            this.Lbl_Titulo.Text = "Custo Total Produção E.H";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Titulo.Click += new System.EventHandler(this.Lbl_Titulo_Click);
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.Location = new System.Drawing.Point(156, 179);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(123, 36);
            this.Btn_Continue.TabIndex = 47;
            this.Btn_Continue.Text = "Sim. Calcular Lucro";
            this.Btn_Continue.UseVisualStyleBackColor = true;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // Lbl_QuantidadeComplemento
            // 
            this.Lbl_QuantidadeComplemento.AutoSize = true;
            this.Lbl_QuantidadeComplemento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QuantidadeComplemento.Location = new System.Drawing.Point(72, 72);
            this.Lbl_QuantidadeComplemento.Name = "Lbl_QuantidadeComplemento";
            this.Lbl_QuantidadeComplemento.Size = new System.Drawing.Size(180, 21);
            this.Lbl_QuantidadeComplemento.TabIndex = 51;
            this.Lbl_QuantidadeComplemento.Text = "Quantidade de Golens:";
            // 
            // Lbl_ResultadoComplemento
            // 
            this.Lbl_ResultadoComplemento.AutoSize = true;
            this.Lbl_ResultadoComplemento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ResultadoComplemento.Location = new System.Drawing.Point(108, 102);
            this.Lbl_ResultadoComplemento.Name = "Lbl_ResultadoComplemento";
            this.Lbl_ResultadoComplemento.Size = new System.Drawing.Size(102, 21);
            this.Lbl_ResultadoComplemento.TabIndex = 50;
            this.Lbl_ResultadoComplemento.Text = "Custo Total:";
            // 
            // Lbl_QuantidadeResposta
            // 
            this.Lbl_QuantidadeResposta.AutoSize = true;
            this.Lbl_QuantidadeResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_QuantidadeResposta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QuantidadeResposta.Location = new System.Drawing.Point(258, 70);
            this.Lbl_QuantidadeResposta.Name = "Lbl_QuantidadeResposta";
            this.Lbl_QuantidadeResposta.Size = new System.Drawing.Size(21, 23);
            this.Lbl_QuantidadeResposta.TabIndex = 52;
            this.Lbl_QuantidadeResposta.Text = "1";
            // 
            // Lbl_Question
            // 
            this.Lbl_Question.AutoSize = true;
            this.Lbl_Question.Location = new System.Drawing.Point(55, 154);
            this.Lbl_Question.Name = "Lbl_Question";
            this.Lbl_Question.Size = new System.Drawing.Size(335, 13);
            this.Lbl_Question.TabIndex = 53;
            this.Lbl_Question.Text = "Deseja Calcular qual será seu lucro a partir deste custo de produção?";
            // 
            // Frm_ResultadoEH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Lbl_Question);
            this.Controls.Add(this.Lbl_QuantidadeResposta);
            this.Controls.Add(this.Lbl_QuantidadeComplemento);
            this.Controls.Add(this.Lbl_ResultadoComplemento);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Lbl_ResultadoEH);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ResultadoEH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado do Cálculo Custo Produção E.H";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lbl_ResultadoEH;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Label Lbl_QuantidadeComplemento;
        private System.Windows.Forms.Label Lbl_ResultadoComplemento;
        private System.Windows.Forms.Label Lbl_QuantidadeResposta;
        private System.Windows.Forms.Label Lbl_Question;
    }
}