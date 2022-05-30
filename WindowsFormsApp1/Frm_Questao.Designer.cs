namespace WindowsFormsApp1
{
    partial class Frm_Questao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Questao));
            this.Msk_resposta = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Pergunta = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Msk_resposta
            // 
            this.Msk_resposta.Location = new System.Drawing.Point(192, 60);
            this.Msk_resposta.Mask = "000";
            this.Msk_resposta.Name = "Msk_resposta";
            this.Msk_resposta.Size = new System.Drawing.Size(111, 20);
            this.Msk_resposta.TabIndex = 0;
            this.Msk_resposta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Msk_resposta_MaskInputRejected);
            // 
            // Lbl_Pergunta
            // 
            this.Lbl_Pergunta.AutoSize = true;
            this.Lbl_Pergunta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pergunta.Location = new System.Drawing.Point(41, 21);
            this.Lbl_Pergunta.Name = "Lbl_Pergunta";
            this.Lbl_Pergunta.Size = new System.Drawing.Size(293, 22);
            this.Lbl_Pergunta.TabIndex = 1;
            this.Lbl_Pergunta.Text = "Quantos Golens Deseja Aprender?";
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(211, 96);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(75, 23);
            this.btn_continue.TabIndex = 2;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(211, 125);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_question_64;
            this.pictureBox1.Location = new System.Drawing.Point(61, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 189);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.Lbl_Pergunta);
            this.Controls.Add(this.Msk_resposta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Questao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_resposta;
        private System.Windows.Forms.Label Lbl_Pergunta;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}