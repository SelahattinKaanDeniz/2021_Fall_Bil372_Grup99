
namespace Bil372ProjeGrup99
{
    partial class PilotPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AdSoyadComboBox = new System.Windows.Forms.ComboBox();
            this.UcakIDComboBox = new System.Windows.Forms.ComboBox();
            this.MurettebatIDTextBox = new System.Windows.Forms.TextBox();
            this.PersonelIDTextBox = new System.Windows.Forms.TextBox();
            this.LisansTuruTextBox = new System.Windows.Forms.TextBox();
            this.PilotRoluTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mürettebat ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uçak ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personel ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lisans Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pilot Rolü:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdSoyadComboBox
            // 
            this.AdSoyadComboBox.FormattingEnabled = true;
            this.AdSoyadComboBox.Location = new System.Drawing.Point(114, 50);
            this.AdSoyadComboBox.Name = "AdSoyadComboBox";
            this.AdSoyadComboBox.Size = new System.Drawing.Size(174, 24);
            this.AdSoyadComboBox.TabIndex = 8;
            this.AdSoyadComboBox.SelectedIndexChanged += new System.EventHandler(this.AdSoyadComboBox_SelectedIndexChanged);
            // 
            // UcakIDComboBox
            // 
            this.UcakIDComboBox.FormattingEnabled = true;
            this.UcakIDComboBox.Location = new System.Drawing.Point(114, 191);
            this.UcakIDComboBox.Name = "UcakIDComboBox";
            this.UcakIDComboBox.Size = new System.Drawing.Size(174, 24);
            this.UcakIDComboBox.TabIndex = 9;
            // 
            // MurettebatIDTextBox
            // 
            this.MurettebatIDTextBox.Location = new System.Drawing.Point(114, 120);
            this.MurettebatIDTextBox.Name = "MurettebatIDTextBox";
            this.MurettebatIDTextBox.Size = new System.Drawing.Size(174, 22);
            this.MurettebatIDTextBox.TabIndex = 10;
            // 
            // PersonelIDTextBox
            // 
            this.PersonelIDTextBox.Location = new System.Drawing.Point(423, 50);
            this.PersonelIDTextBox.Name = "PersonelIDTextBox";
            this.PersonelIDTextBox.Size = new System.Drawing.Size(174, 22);
            this.PersonelIDTextBox.TabIndex = 11;
            // 
            // LisansTuruTextBox
            // 
            this.LisansTuruTextBox.Location = new System.Drawing.Point(423, 123);
            this.LisansTuruTextBox.Name = "LisansTuruTextBox";
            this.LisansTuruTextBox.Size = new System.Drawing.Size(174, 22);
            this.LisansTuruTextBox.TabIndex = 12;
            // 
            // PilotRoluTextBox
            // 
            this.PilotRoluTextBox.Location = new System.Drawing.Point(423, 191);
            this.PilotRoluTextBox.Name = "PilotRoluTextBox";
            this.PilotRoluTextBox.Size = new System.Drawing.Size(174, 22);
            this.PilotRoluTextBox.TabIndex = 13;
            // 
            // PilotPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 368);
            this.Controls.Add(this.PilotRoluTextBox);
            this.Controls.Add(this.LisansTuruTextBox);
            this.Controls.Add(this.PersonelIDTextBox);
            this.Controls.Add(this.MurettebatIDTextBox);
            this.Controls.Add(this.UcakIDComboBox);
            this.Controls.Add(this.AdSoyadComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PilotPage";
            this.Text = "PilotPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox AdSoyadComboBox;
        private System.Windows.Forms.ComboBox UcakIDComboBox;
        private System.Windows.Forms.TextBox MurettebatIDTextBox;
        private System.Windows.Forms.TextBox PersonelIDTextBox;
        private System.Windows.Forms.TextBox LisansTuruTextBox;
        private System.Windows.Forms.TextBox PilotRoluTextBox;
    }
}