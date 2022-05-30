namespace WindowsFormsApp1
{
    partial class Frm_GolemCeleste
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GolemCeleste));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_SubTitulo = new System.Windows.Forms.Label();
            this.Lbl_TextoImgAprender = new System.Windows.Forms.Label();
            this.Lbl_TextoImgFazer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(98, 26);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(233, 26);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Tabela Golem Celeste";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_SubTitulo
            // 
            this.Lbl_SubTitulo.AutoSize = true;
            this.Lbl_SubTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SubTitulo.Location = new System.Drawing.Point(70, 74);
            this.Lbl_SubTitulo.Name = "Lbl_SubTitulo";
            this.Lbl_SubTitulo.Size = new System.Drawing.Size(306, 23);
            this.Lbl_SubTitulo.TabIndex = 1;
            this.Lbl_SubTitulo.Text = "Selecione a Informação que Deseja:";
            // 
            // Lbl_TextoImgAprender
            // 
            this.Lbl_TextoImgAprender.AutoSize = true;
            this.Lbl_TextoImgAprender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TextoImgAprender.Location = new System.Drawing.Point(70, 125);
            this.Lbl_TextoImgAprender.Name = "Lbl_TextoImgAprender";
            this.Lbl_TextoImgAprender.Size = new System.Drawing.Size(140, 19);
            this.Lbl_TextoImgAprender.TabIndex = 2;
            this.Lbl_TextoImgAprender.Text = "Aprender o Golem";
            // 
            // Lbl_TextoImgFazer
            // 
            this.Lbl_TextoImgFazer.AutoSize = true;
            this.Lbl_TextoImgFazer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TextoImgFazer.Location = new System.Drawing.Point(253, 125);
            this.Lbl_TextoImgFazer.Name = "Lbl_TextoImgFazer";
            this.Lbl_TextoImgFazer.Size = new System.Drawing.Size(114, 19);
            this.Lbl_TextoImgFazer.TabIndex = 3;
            this.Lbl_TextoImgFazer.Text = "Fazer o Golem";
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.LivroAprender;
            this.button1.Location = new System.Drawing.Point(104, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 66);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.MarteloFerreiro;
            this.button2.Location = new System.Drawing.Point(275, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 66);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(363, 265);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 9;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Frm_GolemCeleste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_TextoImgFazer);
            this.Controls.Add(this.Lbl_TextoImgAprender);
            this.Controls.Add(this.Lbl_SubTitulo);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_GolemCeleste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golem Celeste Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_SubTitulo;
        private System.Windows.Forms.Label Lbl_TextoImgAprender;
        private System.Windows.Forms.Label Lbl_TextoImgFazer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Exit;
    }
}

