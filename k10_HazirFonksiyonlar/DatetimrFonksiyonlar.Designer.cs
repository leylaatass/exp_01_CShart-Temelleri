
namespace k10_HazirFonksiyonlar
{
    partial class DatetimrFonksiyonlar
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnuzunzaman = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.btnkısazaman = new System.Windows.Forms.Button();
            this.btngun = new System.Windows.Forms.Button();
            this.bynay = new System.Windows.Forms.Button();
            this.btnyıl = new System.Windows.Forms.Button();
            this.btnzamanekle = new System.Windows.Forms.Button();
            this.btnyaşhesaplatma = new System.Windows.Forms.Button();
            this.btnparse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "şimdikizaman";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnuzunzaman
            // 
            this.btnuzunzaman.Location = new System.Drawing.Point(47, 93);
            this.btnuzunzaman.Name = "btnuzunzaman";
            this.btnuzunzaman.Size = new System.Drawing.Size(180, 31);
            this.btnuzunzaman.TabIndex = 1;
            this.btnuzunzaman.Text = "uzun zaman gösterimi";
            this.btnuzunzaman.UseVisualStyleBackColor = true;
            this.btnuzunzaman.Click += new System.EventHandler(this.btnuzunzaman_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(729, 34);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(46, 17);
            this.lblsonuc.TabIndex = 2;
            this.lblsonuc.Text = "label1";
            // 
            // btnkısazaman
            // 
            this.btnkısazaman.Location = new System.Drawing.Point(47, 150);
            this.btnkısazaman.Name = "btnkısazaman";
            this.btnkısazaman.Size = new System.Drawing.Size(180, 33);
            this.btnkısazaman.TabIndex = 3;
            this.btnkısazaman.Text = "kısa zaman gösterimi";
            this.btnkısazaman.UseVisualStyleBackColor = true;
            this.btnkısazaman.Click += new System.EventHandler(this.btnkısazaman_Click);
            // 
            // btngun
            // 
            this.btngun.Location = new System.Drawing.Point(50, 217);
            this.btngun.Name = "btngun";
            this.btngun.Size = new System.Drawing.Size(75, 32);
            this.btngun.TabIndex = 4;
            this.btngun.Text = "gün";
            this.btngun.UseVisualStyleBackColor = true;
            this.btngun.Click += new System.EventHandler(this.btngun_Click);
            // 
            // bynay
            // 
            this.bynay.Location = new System.Drawing.Point(50, 268);
            this.bynay.Name = "bynay";
            this.bynay.Size = new System.Drawing.Size(75, 38);
            this.bynay.TabIndex = 5;
            this.bynay.Text = "ay";
            this.bynay.UseVisualStyleBackColor = true;
            this.bynay.Click += new System.EventHandler(this.bynay_Click);
            // 
            // btnyıl
            // 
            this.btnyıl.Location = new System.Drawing.Point(50, 324);
            this.btnyıl.Name = "btnyıl";
            this.btnyıl.Size = new System.Drawing.Size(75, 32);
            this.btnyıl.TabIndex = 6;
            this.btnyıl.Text = "yıl";
            this.btnyıl.UseVisualStyleBackColor = true;
            this.btnyıl.Click += new System.EventHandler(this.btnyıl_Click);
            // 
            // btnzamanekle
            // 
            this.btnzamanekle.Location = new System.Drawing.Point(50, 379);
            this.btnzamanekle.Name = "btnzamanekle";
            this.btnzamanekle.Size = new System.Drawing.Size(117, 32);
            this.btnzamanekle.TabIndex = 7;
            this.btnzamanekle.Text = "zaman ekle";
            this.btnzamanekle.UseVisualStyleBackColor = true;
            this.btnzamanekle.Click += new System.EventHandler(this.btnzamanekle_Click);
            // 
            // btnyaşhesaplatma
            // 
            this.btnyaşhesaplatma.Location = new System.Drawing.Point(258, 29);
            this.btnyaşhesaplatma.Name = "btnyaşhesaplatma";
            this.btnyaşhesaplatma.Size = new System.Drawing.Size(126, 27);
            this.btnyaşhesaplatma.TabIndex = 8;
            this.btnyaşhesaplatma.Text = "yaş hesaplatma";
            this.btnyaşhesaplatma.UseVisualStyleBackColor = true;
            this.btnyaşhesaplatma.Click += new System.EventHandler(this.btnyaşhesaplatma_Click);
            // 
            // btnparse
            // 
            this.btnparse.Location = new System.Drawing.Point(267, 88);
            this.btnparse.Name = "btnparse";
            this.btnparse.Size = new System.Drawing.Size(117, 36);
            this.btnparse.TabIndex = 9;
            this.btnparse.Text = "parse/tryparse";
            this.btnparse.UseVisualStyleBackColor = true;
            this.btnparse.Click += new System.EventHandler(this.btnparse_Click);
            // 
            // DatetimrFonksiyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnparse);
            this.Controls.Add(this.btnyaşhesaplatma);
            this.Controls.Add(this.btnzamanekle);
            this.Controls.Add(this.btnyıl);
            this.Controls.Add(this.bynay);
            this.Controls.Add(this.btngun);
            this.Controls.Add(this.btnkısazaman);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnuzunzaman);
            this.Controls.Add(this.button1);
            this.Name = "DatetimrFonksiyonlar";
            this.Text = "DatetimrFonksiyonlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnuzunzaman;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button btnkısazaman;
        private System.Windows.Forms.Button btngun;
        private System.Windows.Forms.Button bynay;
        private System.Windows.Forms.Button btnyıl;
        private System.Windows.Forms.Button btnzamanekle;
        private System.Windows.Forms.Button btnyaşhesaplatma;
        private System.Windows.Forms.Button btnparse;
    }
}