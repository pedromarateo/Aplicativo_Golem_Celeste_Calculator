namespace WindowsFormsApp1
{
    partial class Frm_FazerGolemEH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FazerGolemEH));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Msk_PrecoEH = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(28, 26);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(390, 26);
            this.Lbl_Titulo.TabIndex = 20;
            this.Lbl_Titulo.Text = "Produção com Espírito da Harmonia";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Msk_PrecoEH
            // 
            this.Msk_PrecoEH.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_PrecoEH.Location = new System.Drawing.Point(64, 126);
            this.Msk_PrecoEH.Mask = "0000";
            this.Msk_PrecoEH.Name = "Msk_PrecoEH";
            this.Msk_PrecoEH.Size = new System.Drawing.Size(307, 26);
            this.Msk_PrecoEH.TabIndex = 22;
            this.Msk_PrecoEH.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Msk_PrecoEH_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Consideramos 72 E.H para comprar 90 B.T + 90 E.H para junto as Barras de Trílio, " +
    "criar ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "30 A.V + 30 E.H para comprar 600 mínerios de F.F e criar 300 B.F.F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Totalizando 192 E.H";
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.Location = new System.Drawing.Point(181, 163);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(75, 23);
            this.Btn_Continue.TabIndex = 26;
            this.Btn_Continue.Text = "Continue";
            this.Btn_Continue.UseVisualStyleBackColor = true;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(363, 236);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 27;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Quanto está custando o E.H nesse momento?";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(363, 265);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 39;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Frm_FazerGolemEH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Msk_PrecoEH);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FazerGolemEH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custo Espírito de Harmonía";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.MaskedTextBox Msk_PrecoEH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Exit;
    }
}