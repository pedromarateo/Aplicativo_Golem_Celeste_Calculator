namespace WindowsFormsApp1
{
    partial class Frm_CalculoToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CalculoToken));
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.Msk_PrecoToken = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_SubTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.Location = new System.Drawing.Point(148, 179);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(123, 36);
            this.Btn_Continue.TabIndex = 45;
            this.Btn_Continue.Text = "Obter Resultado";
            this.Btn_Continue.UseVisualStyleBackColor = true;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // Msk_PrecoToken
            // 
            this.Msk_PrecoToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_PrecoToken.Location = new System.Drawing.Point(112, 137);
            this.Msk_PrecoToken.Mask = "000000";
            this.Msk_PrecoToken.Name = "Msk_PrecoToken";
            this.Msk_PrecoToken.Size = new System.Drawing.Size(189, 26);
            this.Msk_PrecoToken.TabIndex = 44;
            // 
            // Lbl_SubTitulo
            // 
            this.Lbl_SubTitulo.AutoSize = true;
            this.Lbl_SubTitulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SubTitulo.Location = new System.Drawing.Point(60, 103);
            this.Lbl_SubTitulo.Name = "Lbl_SubTitulo";
            this.Lbl_SubTitulo.Size = new System.Drawing.Size(330, 21);
            this.Lbl_SubTitulo.TabIndex = 43;
            this.Lbl_SubTitulo.Text = "Quanto está custando o Token atualmente?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 26);
            this.label1.TabIndex = 42;
            this.label1.Text = "Calcular Lucro com Token";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_CalculoToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.Msk_PrecoToken);
            this.Controls.Add(this.Lbl_SubTitulo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CalculoToken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular subtração do Token";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.MaskedTextBox Msk_PrecoToken;
        private System.Windows.Forms.Label Lbl_SubTitulo;
        private System.Windows.Forms.Label label1;
    }
}