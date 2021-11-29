
namespace Bil372ProjeGrup99
{
    partial class GenelBakimPage
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
            this.PersonelIDcb = new System.Windows.Forms.ComboBox();
            this.BakimTurutb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServisIDcb
            // 
            this.ServisIDcb.FormattingEnabled = true;
            this.ServisIDcb.Location = new System.Drawing.Point(179, 47);
            this.ServisIDcb.Name = "ServisIDcb";
            this.ServisIDcb.Size = new System.Drawing.Size(121, 21);
            this.ServisIDcb.TabIndex = 0;
            this.ServisIDcb.SelectedIndexChanged += new System.EventHandler(this.ServisIDcb_SelectedIndexChanged);
            // 
            // UcakIDcb
            // 
            this.UcakIDcb.FormattingEnabled = true;
            this.UcakIDcb.Location = new System.Drawing.Point(179, 120);
            this.UcakIDcb.Name = "UcakIDcb";
            this.UcakIDcb.Size = new System.Drawing.Size(121, 21);
            this.UcakIDcb.TabIndex = 1;
            // 
            // PersonelIDcb
            // 
            this.PersonelIDcb.FormattingEnabled = true;
            this.PersonelIDcb.Location = new System.Drawing.Point(179, 186);
            this.PersonelIDcb.Name = "PersonelIDcb";
            this.PersonelIDcb.Size = new System.Drawing.Size(121, 21);
            this.PersonelIDcb.TabIndex = 2;
            // 
            // BakimTurutb
            // 
            this.BakimTurutb.Location = new System.Drawing.Point(179, 255);
            this.BakimTurutb.Name = "BakimTurutb";
            this.BakimTurutb.Size = new System.Drawing.Size(121, 20);
            this.BakimTurutb.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Geri Don";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ServisID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "UcakID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PersonelID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "BakimTuru";
            // 
            // GenelBakimPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BakimTurutb);
            this.Controls.Add(this.PersonelIDcb);
            this.Controls.Add(this.UcakIDcb);
            this.Controls.Add(this.ServisIDcb);
            this.Name = "GenelBakimPage";
            this.Text = "GenelBakimPage";
            this.Load += new System.EventHandler(this.GenelBakimPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ServisIDcb;
        private System.Windows.Forms.ComboBox UcakIDcb;
        private System.Windows.Forms.ComboBox PersonelIDcb;
        private System.Windows.Forms.TextBox BakimTurutb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}