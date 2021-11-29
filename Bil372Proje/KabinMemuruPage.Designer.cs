
namespace Bil372ProjeGrup99
{
    partial class KabinMemuruPage
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
            this.AdSoyadComboBox = new System.Windows.Forms.ComboBox();
            this.UcakIDComboBox = new System.Windows.Forms.ComboBox();
            this.MurettebatIDTextBox = new System.Windows.Forms.TextBox();
            this.MedeniDurumuTextBox = new System.Windows.Forms.TextBox();
            this.PersonelIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mürettebat ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uçak ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Personel ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Medeni Durumu:";
            // 
            // AdSoyadComboBox
            // 
            this.AdSoyadComboBox.FormattingEnabled = true;
            this.AdSoyadComboBox.Location = new System.Drawing.Point(124, 53);
            this.AdSoyadComboBox.Name = "AdSoyadComboBox";
            this.AdSoyadComboBox.Size = new System.Drawing.Size(174, 24);
            this.AdSoyadComboBox.TabIndex = 9;
            this.AdSoyadComboBox.SelectedIndexChanged += new System.EventHandler(this.AdSoyadComboBox_SelectedIndexChanged);
            // 
            // UcakIDComboBox
            // 
            this.UcakIDComboBox.FormattingEnabled = true;
            this.UcakIDComboBox.Location = new System.Drawing.Point(124, 202);
            this.UcakIDComboBox.Name = "UcakIDComboBox";
            this.UcakIDComboBox.Size = new System.Drawing.Size(174, 24);
            this.UcakIDComboBox.TabIndex = 10;
            // 
            // MurettebatIDTextBox
            // 
            this.MurettebatIDTextBox.Location = new System.Drawing.Point(124, 129);
            this.MurettebatIDTextBox.Name = "MurettebatIDTextBox";
            this.MurettebatIDTextBox.Size = new System.Drawing.Size(174, 22);
            this.MurettebatIDTextBox.TabIndex = 11;
            // 
            // MedeniDurumuTextBox
            // 
            this.MedeniDurumuTextBox.Location = new System.Drawing.Point(446, 132);
            this.MedeniDurumuTextBox.Name = "MedeniDurumuTextBox";
            this.MedeniDurumuTextBox.Size = new System.Drawing.Size(174, 22);
            this.MedeniDurumuTextBox.TabIndex = 12;
            // 
            // PersonelIDTextBox
            // 
            this.PersonelIDTextBox.Location = new System.Drawing.Point(446, 53);
            this.PersonelIDTextBox.Name = "PersonelIDTextBox";
            this.PersonelIDTextBox.Size = new System.Drawing.Size(174, 22);
            this.PersonelIDTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KabinMemuruPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PersonelIDTextBox);
            this.Controls.Add(this.MedeniDurumuTextBox);
            this.Controls.Add(this.MurettebatIDTextBox);
            this.Controls.Add(this.UcakIDComboBox);
            this.Controls.Add(this.AdSoyadComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KabinMemuruPage";
            this.Text = "KabinMemuruPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AdSoyadComboBox;
        private System.Windows.Forms.ComboBox UcakIDComboBox;
        private System.Windows.Forms.TextBox MurettebatIDTextBox;
        private System.Windows.Forms.TextBox MedeniDurumuTextBox;
        private System.Windows.Forms.TextBox PersonelIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}