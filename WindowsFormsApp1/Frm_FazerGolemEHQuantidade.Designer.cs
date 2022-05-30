namespace WindowsFormsApp1
{
    partial class Frm_FazerGolemEHQuantidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FazerGolemEHQuantidade));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Msk_QuantidadeCharEH = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(363, 236);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 35;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.Location = new System.Drawing.Point(181, 158);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(75, 23);
            this.Btn_Continue.TabIndex = 34;
            this.Btn_Continue.Text = "Continue";
            this.Btn_Continue.UseVisualStyleBackColor = true;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "O cálculo consiste em: Quantidade Informada * 192 E.H";
            // 
            // Msk_QuantidadeCharEH
            // 
            this.Msk_QuantidadeCharEH.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_QuantidadeCharEH.Location = new System.Drawing.Point(64, 126);
            this.Msk_QuantidadeCharEH.Mask = "000";
            this.Msk_QuantidadeCharEH.Name = "Msk_QuantidadeCharEH";
            this.Msk_QuantidadeCharEH.Size = new System.Drawing.Size(307, 26);
            this.Msk_QuantidadeCharEH.TabIndex = 30;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(43, 26);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(365, 26);
            this.Lbl_Titulo.TabIndex = 28;
            this.Lbl_Titulo.Text = "Quantos Golens serão produzidos?";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Informe a quantidade de Golem a ser produzida:";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(363, 265);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 45;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Frm_FazerGolemEHQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Msk_QuantidadeCharEH);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FazerGolemEHQuantidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantiade de Golens para produzir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Msk_QuantidadeCharEH;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Exit;
    }
}