namespace WindowsFormsApp1
{
    partial class Frm_CalcularLucro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CalcularLucro));
            this.label1 = new System.Windows.Forms.Label();
            this.Msk_PrecoGolem = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Calcular Lucro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Msk_PrecoGolem
            // 
            this.Msk_PrecoGolem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_PrecoGolem.Location = new System.Drawing.Point(124, 126);
            this.Msk_PrecoGolem.Mask = "000000";
            this.Msk_PrecoGolem.Name = "Msk_PrecoGolem";
            this.Msk_PrecoGolem.Size = new System.Drawing.Size(189, 26);
            this.Msk_PrecoGolem.TabIndex = 39;
            this.Msk_PrecoGolem.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Msk_PrecoGolem_MaskInputRejected);
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
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(363, 236);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 41;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(363, 265);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 42;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Quanto está custando o Golem Celeste atualmente?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Consideramos Multplicar o valor do Golem pela quantidade informada anteriormente." +
    "";
            // 
            // Frm_CalcularLucro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.Msk_PrecoGolem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CalcularLucro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Lucro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Msk_PrecoGolem;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}