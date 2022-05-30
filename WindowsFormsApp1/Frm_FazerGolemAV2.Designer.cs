namespace WindowsFormsApp1
{
    partial class Frm_FazerGolemAV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FazerGolemAV2));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Msk_PrecoAV = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_SubTitulo = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
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
            // Btn_Continue
            // 
            this.Btn_Continue.Location = new System.Drawing.Point(181, 163);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(75, 23);
            this.Btn_Continue.TabIndex = 40;
            this.Btn_Continue.Text = "Continue";
            this.Btn_Continue.UseVisualStyleBackColor = true;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Consideramos comprar 300 B.F.F e 30 A.V prontas na Action House.";
            // 
            // Msk_PrecoAV
            // 
            this.Msk_PrecoAV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_PrecoAV.Location = new System.Drawing.Point(64, 126);
            this.Msk_PrecoAV.Mask = "00000";
            this.Msk_PrecoAV.Name = "Msk_PrecoAV";
            this.Msk_PrecoAV.Size = new System.Drawing.Size(307, 26);
            this.Msk_PrecoAV.TabIndex = 38;
            // 
            // Lbl_SubTitulo
            // 
            this.Lbl_SubTitulo.AutoSize = true;
            this.Lbl_SubTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SubTitulo.Location = new System.Drawing.Point(39, 90);
            this.Lbl_SubTitulo.Name = "Lbl_SubTitulo";
            this.Lbl_SubTitulo.Size = new System.Drawing.Size(373, 19);
            this.Lbl_SubTitulo.TabIndex = 37;
            this.Lbl_SubTitulo.Text = "Quanto está custando a Barra de Aço Vivo nesse momento?";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(116, 26);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(192, 26);
            this.Lbl_Titulo.TabIndex = 36;
            this.Lbl_Titulo.Text = "Produção Padrão";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(363, 265);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 42;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Frm_FazerGolemAV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Msk_PrecoAV);
            this.Controls.Add(this.Lbl_SubTitulo);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FazerGolemAV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custo Barra de Aço Vivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Msk_PrecoAV;
        private System.Windows.Forms.Label Lbl_SubTitulo;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Exit;
    }
}