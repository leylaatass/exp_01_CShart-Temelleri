
namespace Kendi_Yaptıklarım
{
    partial class Döngüler
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblvize = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.txtvize = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir sayı giriniz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(107, 106);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 2;
            this.btnSonuc.Text = "button1";
            this.btnSonuc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mevsim Giriniz";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblvize
            // 
            this.lblvize.AutoSize = true;
            this.lblvize.Location = new System.Drawing.Point(448, 54);
            this.lblvize.Name = "lblvize";
            this.lblvize.Size = new System.Drawing.Size(65, 17);
            this.lblvize.TabIndex = 6;
            this.lblvize.Text = "vize notu";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(448, 141);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(66, 17);
            this.lblfinal.TabIndex = 6;
            this.lblfinal.Text = "final notu";
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(576, 136);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(100, 22);
            this.txtfinal.TabIndex = 7;
            // 
            // txtvize
            // 
            this.txtvize.Location = new System.Drawing.Point(576, 54);
            this.txtvize.Name = "txtvize";
            this.txtvize.Size = new System.Drawing.Size(100, 22);
            this.txtvize.TabIndex = 7;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(582, 213);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(109, 33);
            this.btnhesapla.TabIndex = 8;
            this.btnhesapla.Text = "hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Döngüler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtvize);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblvize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Döngüler";
            this.Text = "Döngüler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblvize;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.TextBox txtvize;
        private System.Windows.Forms.Button btnhesapla;
    }
}