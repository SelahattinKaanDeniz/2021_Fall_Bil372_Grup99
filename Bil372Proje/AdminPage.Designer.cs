
namespace Bil372ProjeGrup99
{
    partial class AdminPage
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
            this.EkleButton = new System.Windows.Forms.Button();
            this.DuzenleButton = new System.Windows.Forms.Button();
            this.SilButton = new System.Windows.Forms.Button();
            this.CikisButton = new System.Windows.Forms.Button();
            this.AdminPageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşlem yapmak istediğiniz alanı seçiniz.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EkleButton
            // 
            this.EkleButton.Location = new System.Drawing.Point(25, 372);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(75, 38);
            this.EkleButton.TabIndex = 2;
            this.EkleButton.Text = "Ekle";
            this.EkleButton.UseVisualStyleBackColor = true;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // DuzenleButton
            // 
            this.DuzenleButton.Location = new System.Drawing.Point(130, 372);
            this.DuzenleButton.Name = "DuzenleButton";
            this.DuzenleButton.Size = new System.Drawing.Size(75, 38);
            this.DuzenleButton.TabIndex = 3;
            this.DuzenleButton.Text = "Düzenle";
            this.DuzenleButton.UseVisualStyleBackColor = true;
            this.DuzenleButton.Click += new System.EventHandler(this.DuzenleButton_Click);
            // 
            // SilButton
            // 
            this.SilButton.Location = new System.Drawing.Point(240, 372);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(75, 38);
            this.SilButton.TabIndex = 4;
            this.SilButton.Text = "Sil";
            this.SilButton.UseVisualStyleBackColor = true;
            this.SilButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // CikisButton
            // 
            this.CikisButton.Location = new System.Drawing.Point(340, 372);
            this.CikisButton.Name = "CikisButton";
            this.CikisButton.Size = new System.Drawing.Size(75, 38);
            this.CikisButton.TabIndex = 5;
            this.CikisButton.Text = "Çıkış";
            this.CikisButton.UseVisualStyleBackColor = true;
            this.CikisButton.Click += new System.EventHandler(this.CikisButton_Click);
            // 
            // AdminPageComboBox
            // 
            this.AdminPageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminPageComboBox.FormattingEnabled = true;
            this.AdminPageComboBox.Location = new System.Drawing.Point(60, 36);
            this.AdminPageComboBox.Name = "AdminPageComboBox";
            this.AdminPageComboBox.Size = new System.Drawing.Size(319, 37);
            this.AdminPageComboBox.TabIndex = 0;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 439);
            this.Controls.Add(this.CikisButton);
            this.Controls.Add(this.SilButton);
            this.Controls.Add(this.DuzenleButton);
            this.Controls.Add(this.EkleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminPageComboBox);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.Button DuzenleButton;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.Button CikisButton;
        private System.Windows.Forms.ComboBox AdminPageComboBox;
    }
}