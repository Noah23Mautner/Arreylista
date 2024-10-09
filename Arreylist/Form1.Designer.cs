namespace Arreylist
{
    partial class Form1
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
            this.btnNoviauto = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtUnesi = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNoviauto
            // 
            this.btnNoviauto.Location = new System.Drawing.Point(39, 13);
            this.btnNoviauto.Name = "btnNoviauto";
            this.btnNoviauto.Size = new System.Drawing.Size(182, 31);
            this.btnNoviauto.TabIndex = 0;
            this.btnNoviauto.Text = "Novi auto";
            this.btnNoviauto.UseVisualStyleBackColor = true;
            this.btnNoviauto.Click += new System.EventHandler(this.btnNoviauto_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(249, 75);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(159, 36);
            this.btnUnesi.TabIndex = 1;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(39, 351);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(182, 28);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtUnesi
            // 
            this.txtUnesi.Location = new System.Drawing.Point(39, 84);
            this.txtUnesi.Name = "txtUnesi";
            this.txtUnesi.Size = new System.Drawing.Size(182, 26);
            this.txtUnesi.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 158);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 170);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtUnesi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnNoviauto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoviauto;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtUnesi;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

