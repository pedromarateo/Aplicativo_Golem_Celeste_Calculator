namespace WindowsFormsApp1
{
    partial class Frm_FazerGolem1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FazerGolem1));
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Lbl_TextoImgFazer = new System.Windows.Forms.Label();
            this.Lbl_TextoImgAprender = new System.Windows.Forms.Label();
            this.Lbl_SubTitulo = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.FonteDeJade;
            this.button1.Location = new System.Drawing.Point(104, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 66);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(363, 236);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 13;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Lbl_TextoImgFazer
            // 
            this.Lbl_TextoImgFazer.AutoSize = true;
            this.Lbl_TextoImgFazer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TextoImgFazer.Location = new System.Drawing.Point(245, 125);
            this.Lbl_TextoImgFazer.Name = "Lbl_TextoImgFazer";
            this.Lbl_TextoImgFazer.Size = new System.Drawing.Size(124, 19);
            this.Lbl_TextoImgFazer.TabIndex = 12;
            this.Lbl_TextoImgFazer.Text = "matérias primas";
            // 
            // Lbl_TextoImgAprender
            // 
            this.Lbl_TextoImgAprender.AutoSize = true;
            this.Lbl_TextoImgAprender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TextoImgAprender.Location = new System.Drawing.Point(63, 109);
            this.Lbl_TextoImgAprender.Name = "Lbl_TextoImgAprender";
            this.Lbl_TextoImgAprender.Size = new System.Drawing.Size(152, 19);
            this.Lbl_TextoImgAprender.TabIndex = 11;
            this.Lbl_TextoImgAprender.Text = "Quantidade de itens";
            // 
            // Lbl_SubTitulo
            // 
            this.Lbl_SubTitulo.AutoSize = true;
            this.Lbl_SubTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SubTitulo.Location = new System.Drawing.Point(73, 74);
            this.Lbl_SubTitulo.Name = "Lbl_SubTitulo";
            this.Lbl_SubTitulo.Size = new System.Drawing.Size(306, 23);
            this.Lbl_SubTitulo.TabIndex = 10;
            this.Lbl_SubTitulo.Text = "Selecione a Informação que Deseja:";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(108, 26);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(223, 26);
            this.Lbl_Titulo.TabIndex = 9;
            this.Lbl_Titulo.Text = "Fazer Golem Celeste";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = " para fazer o Golem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Calcular o preço das ";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(275, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 66);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(363, 265);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 18;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Frm_FazerGolem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Lbl_TextoImgFazer);
            this.Controls.Add(this.Lbl_TextoImgAprender);
            this.Controls.Add(this.Lbl_SubTitulo);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FazerGolem1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fazer Golem Celeste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label Lbl_TextoImgFazer;
        private System.Windows.Forms.Label Lbl_TextoImgAprender;
        private System.Windows.Forms.Label Lbl_SubTitulo;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Exit;
    }
}