
namespace Bil372ProjeGrup99
{
    partial class GenelBakimTeknisyeniPage
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
            this.PersonelAdicb = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teknisyenderecesitb = new System.Windows.Forms.TextBox();
            this.onayla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servis Personel ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teknisyen Derecesi";
            // 
            // PersonelAdicb
            // 
            this.PersonelAdicb.FormattingEnabled = true;
            this.PersonelAdicb.Location = new System.Drawing.Point(189, 45);
            this.PersonelAdicb.Name = "PersonelAdicb";
            this.PersonelAdicb.Size = new System.Drawing.Size(121, 24);
            this.PersonelAdicb.TabIndex = 3;
            this.PersonelAdicb.SelectedIndexChanged += new System.EventHandler(this.PersonelAdicb_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // teknisyenderecesitb
            // 
            this.teknisyenderecesitb.Location = new System.Drawing.Point(189, 134);
            this.teknisyenderecesitb.Name = "teknisyenderecesitb";
            this.teknisyenderecesitb.Size = new System.Drawing.Size(121, 22);
            this.teknisyenderecesitb.TabIndex = 5;
            // 
            // onayla
            // 
            this.onayla.Location = new System.Drawing.Point(258, 195);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(75, 23);
            this.onayla.TabIndex = 6;
            this.onayla.Text = "Kaydet";
            this.onayla.UseVisualStyleBackColor = true;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GenelBakimTeknisyeniPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.onayla);
            this.Controls.Add(this.teknisyenderecesitb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PersonelAdicb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenelBakimTeknisyeniPage";
            this.Text = "GenelBakimTeknisyeniPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PersonelAdicb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox teknisyenderecesitb;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Button button2;
    }
}