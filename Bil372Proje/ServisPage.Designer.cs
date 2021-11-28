
namespace Bil372ProjeGrup99
{
    partial class ServisPage
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
            this.UcakIDcb = new System.Windows.Forms.ComboBox();
            this.ServisTipitb = new System.Windows.Forms.TextBox();
            this.BaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.BitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServisIDcb
            // 
            this.ServisIDcb.FormattingEnabled = true;
            this.ServisIDcb.Location = new System.Drawing.Point(116, 63);
            this.ServisIDcb.Name = "ServisIDcb";
            this.ServisIDcb.Size = new System.Drawing.Size(121, 21);
            this.ServisIDcb.TabIndex = 0;
            this.ServisIDcb.SelectedIndexChanged += new System.EventHandler(this.ServisIDcb_SelectedIndexChanged);
            // 
            // UcakIDcb
            // 
            this.UcakIDcb.FormattingEnabled = true;
            this.UcakIDcb.Location = new System.Drawing.Point(116, 135);
            this.UcakIDcb.Name = "UcakIDcb";
            this.UcakIDcb.Size = new System.Drawing.Size(121, 21);
            this.UcakIDcb.TabIndex = 1;
            // 
            // ServisTipitb
            // 
            this.ServisTipitb.Location = new System.Drawing.Point(116, 220);
            this.ServisTipitb.Name = "ServisTipitb";
            this.ServisTipitb.Size = new System.Drawing.Size(121, 20);
            this.ServisTipitb.TabIndex = 2;
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.Location = new System.Drawing.Point(366, 64);
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            this.BaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.BaslangicTarihi.TabIndex = 3;
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.Location = new System.Drawing.Point(366, 136);
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.BitisTarihi.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Geri Don";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ServisID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "UcakID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ServisTipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "BaslangicTarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "BitisTarihi";
            // 
            // ServisPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BitisTarihi);
            this.Controls.Add(this.BaslangicTarihi);
            this.Controls.Add(this.ServisTipitb);
            this.Controls.Add(this.UcakIDcb);
            this.Controls.Add(this.ServisIDcb);
            this.Name = "ServisPage";
            this.Text = "ServisPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ServisIDcb;
        private System.Windows.Forms.ComboBox UcakIDcb;
        private System.Windows.Forms.TextBox ServisTipitb;
        private System.Windows.Forms.DateTimePicker BaslangicTarihi;
        private System.Windows.Forms.DateTimePicker BitisTarihi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}