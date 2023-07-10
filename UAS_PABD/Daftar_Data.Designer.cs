namespace UAS_PABD
{
    partial class Daftar_Data
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRsv = new System.Windows.Forms.Button();
            this.btnCtr = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTamu
            // 
            this.btnTamu.Location = new System.Drawing.Point(132, 267);
            this.btnTamu.Name = "btnTamu";
            this.btnTamu.Size = new System.Drawing.Size(121, 33);
            this.btnTamu.TabIndex = 0;
            this.btnTamu.Text = "TAMU";
            this.btnTamu.UseVisualStyleBackColor = true;
            this.btnTamu.Click += new System.EventHandler(this.btnTamu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "DAFTAR DATA";
            // 
            // btnRsv
            // 
            this.btnRsv.Location = new System.Drawing.Point(340, 267);
            this.btnRsv.Name = "btnRsv";
            this.btnRsv.Size = new System.Drawing.Size(121, 33);
            this.btnRsv.TabIndex = 4;
            this.btnRsv.Text = "RESERVASI";
            this.btnRsv.UseVisualStyleBackColor = true;
            this.btnRsv.Click += new System.EventHandler(this.btnRsv_Click);
            // 
            // btnCtr
            // 
            this.btnCtr.Location = new System.Drawing.Point(522, 267);
            this.btnCtr.Name = "btnCtr";
            this.btnCtr.Size = new System.Drawing.Size(121, 33);
            this.btnCtr.TabIndex = 5;
            this.btnCtr.Text = "CATERING";
            this.btnCtr.UseVisualStyleBackColor = true;
            this.btnCtr.Click += new System.EventHandler(this.btnCtr_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(713, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Daftar_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCtr);
            this.Controls.Add(this.btnRsv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTamu);
            this.Name = "Daftar_Data";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Daftar_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRsv;
        private System.Windows.Forms.Button btnCtr;
        private System.Windows.Forms.Button btnBack;
    }
}