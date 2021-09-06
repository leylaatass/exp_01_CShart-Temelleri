
namespace k08_Diziler
{
    partial class Form2
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
            this.btnörnek1 = new System.Windows.Forms.Button();
            this.lstsonuc = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstçiftler = new System.Windows.Forms.ListBox();
            this.lsttekler = new System.Windows.Forms.ListBox();
            this.btnörnek3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnörnek1
            // 
            this.btnörnek1.Location = new System.Drawing.Point(12, 38);
            this.btnörnek1.Name = "btnörnek1";
            this.btnörnek1.Size = new System.Drawing.Size(170, 51);
            this.btnörnek1.TabIndex = 0;
            this.btnörnek1.Text = "elemanları listeye ekle";
            this.btnörnek1.UseVisualStyleBackColor = true;
            this.btnörnek1.Click += new System.EventHandler(this.btnörnek1_Click);
            // 
            // lstsonuc
            // 
            this.lstsonuc.FormattingEnabled = true;
            this.lstsonuc.ItemHeight = 20;
            this.lstsonuc.Location = new System.Drawing.Point(198, 38);
            this.lstsonuc.Name = "lstsonuc";
            this.lstsonuc.Size = new System.Drawing.Size(150, 344);
            this.lstsonuc.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "1 den 10 a kadar çiftleri ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstçiftler
            // 
            this.lstçiftler.FormattingEnabled = true;
            this.lstçiftler.ItemHeight = 20;
            this.lstçiftler.Location = new System.Drawing.Point(404, 128);
            this.lstçiftler.Name = "lstçiftler";
            this.lstçiftler.Size = new System.Drawing.Size(150, 104);
            this.lstçiftler.TabIndex = 3;
            // 
            // lsttekler
            // 
            this.lsttekler.FormattingEnabled = true;
            this.lsttekler.ItemHeight = 20;
            this.lsttekler.Location = new System.Drawing.Point(595, 128);
            this.lsttekler.Name = "lsttekler";
            this.lsttekler.Size = new System.Drawing.Size(150, 104);
            this.lsttekler.TabIndex = 4;
            // 
            // btnörnek3
            // 
            this.btnörnek3.Location = new System.Drawing.Point(404, 251);
            this.btnörnek3.Name = "btnörnek3";
            this.btnörnek3.Size = new System.Drawing.Size(185, 47);
            this.btnörnek3.TabIndex = 5;
            this.btnörnek3.Text = "1 den 20 ye kadar ekle";
            this.btnörnek3.UseVisualStyleBackColor = true;
            this.btnörnek3.Click += new System.EventHandler(this.btnörnek3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnörnek3);
            this.Controls.Add(this.lsttekler);
            this.Controls.Add(this.lstçiftler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstsonuc);
            this.Controls.Add(this.btnörnek1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnörnek1;
        private System.Windows.Forms.ListBox lstsonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstçiftler;
        private System.Windows.Forms.ListBox lsttekler;
        private System.Windows.Forms.Button btnörnek3;
    }
}