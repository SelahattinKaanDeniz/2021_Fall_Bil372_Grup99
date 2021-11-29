
namespace Bil372ProjeGrup99
{
    partial class KullaniciEkle
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
            this.PersonelIDcb = new System.Windows.Forms.ComboBox();
            this.KullaniciAditb = new System.Windows.Forms.TextBox();
            this.KullaniciTipicb = new System.Windows.Forms.ComboBox();
            this.Sifretb = new System.Windows.Forms.TextBox();
            this.Onayla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonelIDcb
            // 
            this.PersonelIDcb.FormattingEnabled = true;
            this.PersonelIDcb.Location = new System.Drawing.Point(169, 192);
            this.PersonelIDcb.Name = "PersonelIDcb";
            this.PersonelIDcb.Size = new System.Drawing.Size(121, 21);
            this.PersonelIDcb.TabIndex = 0;
            // 
            // KullaniciAditb
            // 
            this.KullaniciAditb.Location = new System.Drawing.Point(169, 56);
            this.KullaniciAditb.Name = "KullaniciAditb";
            this.KullaniciAditb.Size = new System.Drawing.Size(121, 20);
            this.KullaniciAditb.TabIndex = 1;
            this.KullaniciAditb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KullaniciTipicb
            // 
            this.KullaniciTipicb.FormattingEnabled = true;
            this.KullaniciTipicb.Location = new System.Drawing.Point(169, 262);
            this.KullaniciTipicb.Name = "KullaniciTipicb";
            this.KullaniciTipicb.Size = new System.Drawing.Size(121, 21);
            this.KullaniciTipicb.TabIndex = 2;
            // 
            // Sifretb
            // 
            this.Sifretb.Location = new System.Drawing.Point(169, 125);
            this.Sifretb.Name = "Sifretb";
            this.Sifretb.Size = new System.Drawing.Size(121, 20);
            this.Sifretb.TabIndex = 3;
            // 
            // Onayla
            // 
            this.Onayla.Location = new System.Drawing.Point(99, 349);
            this.Onayla.Name = "Onayla";
            this.Onayla.Size = new System.Drawing.Size(102, 41);
            this.Onayla.TabIndex = 4;
            this.Onayla.Text = "Onayla";
            this.Onayla.UseVisualStyleBackColor = true;
            this.Onayla.Click += new System.EventHandler(this.Onayla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Geri Don";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "KullaniciAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PersonelD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "KullaniciTipi";
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Onayla);
            this.Controls.Add(this.Sifretb);
            this.Controls.Add(this.KullaniciTipicb);
            this.Controls.Add(this.KullaniciAditb);
            this.Controls.Add(this.PersonelIDcb);
            this.Name = "KullaniciEkle";
            this.Text = "KullaniciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PersonelIDcb;
        private System.Windows.Forms.TextBox KullaniciAditb;
        private System.Windows.Forms.ComboBox KullaniciTipicb;
        private System.Windows.Forms.TextBox Sifretb;
        private System.Windows.Forms.Button Onayla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}