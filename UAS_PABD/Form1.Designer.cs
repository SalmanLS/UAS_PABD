namespace UAS_PABD
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDtTamu = new System.Windows.Forms.Button();
            this.btnDtKar = new System.Windows.Forms.Button();
            this.btnDtCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "DAFTAR DATA";
            // 
            // btnDtTamu
            // 
            this.btnDtTamu.Location = new System.Drawing.Point(340, 149);
            this.btnDtTamu.Name = "btnDtTamu";
            this.btnDtTamu.Size = new System.Drawing.Size(113, 38);
            this.btnDtTamu.TabIndex = 5;
            this.btnDtTamu.Text = "Data Tamu";
            this.btnDtTamu.UseVisualStyleBackColor = true;
            // 
            // btnDtKar
            // 
            this.btnDtKar.Location = new System.Drawing.Point(340, 207);
            this.btnDtKar.Name = "btnDtKar";
            this.btnDtKar.Size = new System.Drawing.Size(113, 38);
            this.btnDtKar.TabIndex = 6;
            this.btnDtKar.Text = "Data Karyawan";
            this.btnDtKar.UseVisualStyleBackColor = true;
            // 
            // btnDtCat
            // 
            this.btnDtCat.Location = new System.Drawing.Point(340, 269);
            this.btnDtCat.Name = "btnDtCat";
            this.btnDtCat.Size = new System.Drawing.Size(113, 38);
            this.btnDtCat.TabIndex = 7;
            this.btnDtCat.Text = "Data Catering";
            this.btnDtCat.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.btnDtCat);
            this.Controls.Add(this.btnDtKar);
            this.Controls.Add(this.btnDtTamu);
            this.Controls.Add(this.label3);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDtTamu;
        private System.Windows.Forms.Button btnDtKar;
        private System.Windows.Forms.Button btnDtCat;
    }
}