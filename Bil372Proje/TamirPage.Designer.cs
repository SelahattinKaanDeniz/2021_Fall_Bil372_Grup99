
namespace Bil372ProjeGrup99
{
    partial class TamirPage
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
            this.ServisIDcb = new System.Windows.Forms.ComboBox();
            this.PersonelIDcb = new System.Windows.Forms.ComboBox();
            this.UcakIDcb = new System.Windows.Forms.ComboBox();
            this.KazaSebebitb = new System.Windows.Forms.TextBox();
            this.TamirSonucutb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KazaTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ServisIDcb
            // 
            this.ServisIDcb.FormattingEnabled = true;
            this.ServisIDcb.Location = new System.Drawing.Point(122, 52);
            this.ServisIDcb.Name = "ServisIDcb";
            this.ServisIDcb.Size = new System.Drawing.Size(121, 21);
            this.ServisIDcb.TabIndex = 0;
            this.ServisIDcb.SelectedIndexChanged += new System.EventHandler(this.ServisIDcb_SelectedIndexChanged);
            // 
            // PersonelIDcb
            // 
            this.PersonelIDcb.FormattingEnabled = true;
            this.PersonelIDcb.Location = new System.Drawing.Point(122, 130);
            this.PersonelIDcb.Name = "PersonelIDcb";
            this.PersonelIDcb.Size = new System.Drawing.Size(121, 21);
            this.PersonelIDcb.TabIndex = 1;
            // 
            // UcakIDcb
            // 
            this.UcakIDcb.FormattingEnabled = true;
            this.UcakIDcb.Location = new System.Drawing.Point(122, 213);
            this.UcakIDcb.Name = "UcakIDcb";
            this.UcakIDcb.Size = new System.Drawing.Size(121, 21);
            this.UcakIDcb.TabIndex = 2;
            // 
            // KazaSebebitb
            // 
            this.KazaSebebitb.Location = new System.Drawing.Point(399, 52);
            this.KazaSebebitb.Name = "KazaSebebitb";
            this.KazaSebebitb.Size = new System.Drawing.Size(121, 20);
            this.KazaSebebitb.TabIndex = 3;
            // 
            // TamirSonucutb
            // 
            this.TamirSonucutb.Location = new System.Drawing.Point(399, 131);
            this.TamirSonucutb.Name = "TamirSonucutb";
            this.TamirSonucutb.Size = new System.Drawing.Size(121, 20);
            this.TamirSonucutb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Geri Don";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ServisID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PersonelID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "UcakID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kaza Sebebi";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(320, 134);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 13);
            this.label.TabIndex = 12;
            this.label.Text = "Tamir Sonucu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kaza Tarihi";
            // 
            // KazaTarihi
            // 
            this.KazaTarihi.Location = new System.Drawing.Point(399, 214);
            this.KazaTarihi.Name = "KazaTarihi";
            this.KazaTarihi.Size = new System.Drawing.Size(200, 20);
            this.KazaTarihi.TabIndex = 14;
            // 
            // TamirPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 387);
            this.Controls.Add(this.KazaTarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TamirSonucutb);
            this.Controls.Add(this.KazaSebebitb);
            this.Controls.Add(this.UcakIDcb);
            this.Controls.Add(this.PersonelIDcb);
            this.Controls.Add(this.ServisIDcb);
            this.Name = "TamirPage";
            this.Text = "TamirPage";
            this.Load += new System.EventHandler(this.TamirPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ServisIDcb;
        private System.Windows.Forms.ComboBox PersonelIDcb;
        private System.Windows.Forms.ComboBox UcakIDcb;
        private System.Windows.Forms.TextBox KazaSebebitb;
        private System.Windows.Forms.TextBox TamirSonucutb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker KazaTarihi;
    }
}