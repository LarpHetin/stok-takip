namespace Stok_Takip_sistemi.Forms
{
    partial class frmAnaSayfaYonetici
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
            this.btnUrunler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunler.Location = new System.Drawing.Point(212, 203);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(208, 120);
            this.btnUrunler.TabIndex = 10;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(205, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stok Takip Sistemi Ana Ekranı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(359, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 83);
            this.button1.TabIndex = 11;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalis
            // 
            this.btnCalis.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalis.Location = new System.Drawing.Point(501, 205);
            this.btnCalis.Name = "btnCalis";
            this.btnCalis.Size = new System.Drawing.Size(208, 118);
            this.btnCalis.TabIndex = 12;
            this.btnCalis.Text = "Çalışanlar";
            this.btnCalis.UseVisualStyleBackColor = false;
            this.btnCalis.Click += new System.EventHandler(this.btnCalis_Click);
            // 
            // frmAnaSayfaYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(942, 569);
            this.Controls.Add(this.btnCalis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.label1);
            this.Name = "frmAnaSayfaYonetici";
            this.Text = "frmAnaSayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalis;
    }
}