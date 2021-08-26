
namespace k04_Yasamdongusu
{
    partial class YasanDongusu
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "arttır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(91, 217);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(433, 22);
            this.txtDeger.TabIndex = 1;
            this.txtDeger.TextChanged += new System.EventHandler(this.textDeger_TextChanged);
            // 
            // YasanDongusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 357);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.button1);
            this.Name = "YasanDongusu";
            this.Text = "YasanDongusu";
            this.Load += new System.EventHandler(this.YasanDongusu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDeger;
    }
}