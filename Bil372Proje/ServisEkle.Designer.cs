
namespace Bil372ProjeGrup99
{
    partial class ServisEkle
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
            this.UcakIDcb = new System.Windows.Forms.ComboBox();
            this.ServisIDtb = new System.Windows.Forms.TextBox();
            this.BitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.BaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ServisTipicb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UcakIDcb
            // 
            this.UcakIDcb.FormattingEnabled = true;
            this.UcakIDcb.Location = new System.Drawing.Point(109, 60);
            this.UcakIDcb.Name = "UcakIDcb";
            this.UcakIDcb.Size = new System.Drawing.Size(149, 21);
            this.UcakIDcb.TabIndex = 0;
            // 
            // ServisIDtb
            // 
            this.ServisIDtb.Location = new System.Drawing.Point(109, 139);
            this.ServisIDtb.Name = "ServisIDtb";
            this.ServisIDtb.Size = new System.Drawing.Size(149, 20);
            this.ServisIDtb.TabIndex = 1;
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.Location = new System.Drawing.Point(383, 139);
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.BitisTarihi.TabIndex = 2;
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.Location = new System.Drawing.Point(383, 61);
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            this.BaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.BaslangicTarihi.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Geri Don";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "UcakID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ServisID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ServisTipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Baslangic Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "BitisTarihi";
            // 
            // ServisTipicb
            // 
            this.ServisTipicb.FormattingEnabled = true;
            this.ServisTipicb.Location = new System.Drawing.Point(109, 224);
            this.ServisTipicb.Name = "ServisTipicb";
            this.ServisTipicb.Size = new System.Drawing.Size(149, 21);
            this.ServisTipicb.TabIndex = 12;
            // 
            // ServisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 392);
            this.Controls.Add(this.ServisTipicb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BaslangicTarihi);
            this.Controls.Add(this.BitisTarihi);
            this.Controls.Add(this.ServisIDtb);
            this.Controls.Add(this.UcakIDcb);
            this.Name = "ServisEkle";
            this.Text = "ServisEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UcakIDcb;
        private System.Windows.Forms.TextBox ServisIDtb;
        private System.Windows.Forms.DateTimePicker BitisTarihi;
        private System.Windows.Forms.DateTimePicker BaslangicTarihi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ServisTipicb;
    }
}