namespace UAS_PABD
{
    partial class Halaman_Utama
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
            this.btnTamu = new System.Windows.Forms.Button();
            this.btnKatering = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReservasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTamu
            // 
            this.btnTamu.Location = new System.Drawing.Point(307, 188);
            this.btnTamu.Name = "btnTamu";
            this.btnTamu.Size = new System.Drawing.Size(157, 39);
            this.btnTamu.TabIndex = 0;
            this.btnTamu.Text = "DATA TAMU";
            this.btnTamu.UseVisualStyleBackColor = true;
            this.btnTamu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKatering
            // 
            this.btnKatering.Location = new System.Drawing.Point(307, 278);
            this.btnKatering.Name = "btnKatering";
            this.btnKatering.Size = new System.Drawing.Size(157, 39);
            this.btnKatering.TabIndex = 1;
            this.btnKatering.Text = "CATHERING";
            this.btnKatering.UseVisualStyleBackColor = true;
            this.btnKatering.Click += new System.EventHandler(this.btnKatering_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU UTAMA";
            // 
            // btnReservasi
            // 
            this.btnReservasi.Location = new System.Drawing.Point(307, 233);
            this.btnReservasi.Name = "btnReservasi";
            this.btnReservasi.Size = new System.Drawing.Size(157, 39);
            this.btnReservasi.TabIndex = 4;
            this.btnReservasi.Text = "RESERVASI";
            this.btnReservasi.UseVisualStyleBackColor = true;
            this.btnReservasi.Click += new System.EventHandler(this.btnReservasi_Click);
            // 
            // Halaman_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKatering);
            this.Controls.Add(this.btnTamu);
            this.Name = "Halaman_Utama";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Halaman_Utama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamu;
        private System.Windows.Forms.Button btnKatering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReservasi;
    }
}

