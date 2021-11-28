
namespace Bil372ProjeGrup99
{
    partial class ServisPersoneliPage
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
            this.onayla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.servispersoneliadicb = new System.Windows.Forms.ComboBox();
            this.servispersonelitipitb = new System.Windows.Forms.TextBox();
            this.servispersonelicalistigihavalimanitb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.servispersonelspid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // onayla
            // 
            this.onayla.Location = new System.Drawing.Point(236, 225);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(75, 23);
            this.onayla.TabIndex = 0;
            this.onayla.Text = "Kaydet";
            this.onayla.UseVisualStyleBackColor = true;
            this.onayla.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çalıştığı Havalimanı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // servispersoneliadicb
            // 
            this.servispersoneliadicb.FormattingEnabled = true;
            this.servispersoneliadicb.Location = new System.Drawing.Point(190, 59);
            this.servispersoneliadicb.Name = "servispersoneliadicb";
            this.servispersoneliadicb.Size = new System.Drawing.Size(121, 24);
            this.servispersoneliadicb.TabIndex = 5;
            this.servispersoneliadicb.SelectedIndexChanged += new System.EventHandler(this.servispersoneliadicb_SelectedIndexChanged);
            // 
            // servispersonelitipitb
            // 
            this.servispersonelitipitb.Location = new System.Drawing.Point(190, 140);
            this.servispersonelitipitb.Name = "servispersonelitipitb";
            this.servispersonelitipitb.Size = new System.Drawing.Size(121, 22);
            this.servispersonelitipitb.TabIndex = 6;
            // 
            // servispersonelicalistigihavalimanitb
            // 
            this.servispersonelicalistigihavalimanitb.Location = new System.Drawing.Point(190, 177);
            this.servispersonelicalistigihavalimanitb.Name = "servispersonelicalistigihavalimanitb";
            this.servispersonelicalistigihavalimanitb.Size = new System.Drawing.Size(121, 22);
            this.servispersonelicalistigihavalimanitb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Servis Personel ID";
            // 
            // servispersonelspid
            // 
            this.servispersonelspid.Location = new System.Drawing.Point(190, 97);
            this.servispersonelspid.Name = "servispersonelspid";
            this.servispersonelspid.Size = new System.Drawing.Size(121, 22);
            this.servispersonelspid.TabIndex = 9;
            // 
            // ServisPersoneliPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 260);
            this.Controls.Add(this.servispersonelspid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.servispersonelicalistigihavalimanitb);
            this.Controls.Add(this.servispersonelitipitb);
            this.Controls.Add(this.servispersoneliadicb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.onayla);
            this.Name = "ServisPersoneliPage";
            this.Text = "ServisPersoneliPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox servispersoneliadicb;
        private System.Windows.Forms.TextBox servispersonelitipitb;
        private System.Windows.Forms.TextBox servispersonelicalistigihavalimanitb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox servispersonelspid;
    }
}