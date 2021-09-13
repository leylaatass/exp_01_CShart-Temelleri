
namespace k11_Metotlar
{
    partial class Form1
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
            this.btnadsoyadgöster = new System.Windows.Forms.Button();
            this.btngöster = new System.Windows.Forms.Button();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnadsoyadgöster
            // 
            this.btnadsoyadgöster.Location = new System.Drawing.Point(626, 24);
            this.btnadsoyadgöster.Name = "btnadsoyadgöster";
            this.btnadsoyadgöster.Size = new System.Drawing.Size(134, 36);
            this.btnadsoyadgöster.TabIndex = 0;
            this.btnadsoyadgöster.Text = "ad soyad göster";
            this.btnadsoyadgöster.UseVisualStyleBackColor = true;
            this.btnadsoyadgöster.Click += new System.EventHandler(this.btnadsoyadgöster_Click);
            // 
            // btngöster
            // 
            this.btngöster.Location = new System.Drawing.Point(171, 126);
            this.btngöster.Name = "btngöster";
            this.btngöster.Size = new System.Drawing.Size(75, 28);
            this.btngöster.TabIndex = 1;
            this.btngöster.Text = "Göster";
            this.btngöster.UseVisualStyleBackColor = true;
            this.btngöster.Click += new System.EventHandler(this.btngöster_Click);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(29, 34);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(46, 17);
            this.lblad.TabIndex = 2;
            this.lblad.Text = "Adınız";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(12, 77);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(69, 17);
            this.lblsoyad.TabIndex = 3;
            this.lblsoyad.Text = "Soyadınız";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(146, 34);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 22);
            this.txtad.TabIndex = 4;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(146, 77);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtsoyad.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.btngöster);
            this.Controls.Add(this.btnadsoyadgöster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadsoyadgöster;
        private System.Windows.Forms.Button btngöster;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
    }
}

