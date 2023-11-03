namespace Praktikum_Winform_Youtube
{
    partial class formUbah
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
            this.lblProdi = new System.Windows.Forms.Label();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.tbUNama = new System.Windows.Forms.TextBox();
            this.tbUNIM = new System.Windows.Forms.TextBox();
            this.cbUProdi = new System.Windows.Forms.ComboBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "INPUT DATA MAHASISWA";
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdi.Location = new System.Drawing.Point(29, 169);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(37, 13);
            this.lblProdi.TabIndex = 6;
            this.lblProdi.Text = "Prodi :";
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIM.Location = new System.Drawing.Point(33, 122);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(33, 13);
            this.lblNIM.TabIndex = 5;
            this.lblNIM.Text = "NIM :";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(25, 75);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(41, 13);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama :";
            // 
            // tbUNama
            // 
            this.tbUNama.Location = new System.Drawing.Point(72, 75);
            this.tbUNama.Name = "tbUNama";
            this.tbUNama.Size = new System.Drawing.Size(217, 20);
            this.tbUNama.TabIndex = 7;
            // 
            // tbUNIM
            // 
            this.tbUNIM.Location = new System.Drawing.Point(72, 122);
            this.tbUNIM.Name = "tbUNIM";
            this.tbUNIM.Size = new System.Drawing.Size(217, 20);
            this.tbUNIM.TabIndex = 8;
            // 
            // cbUProdi
            // 
            this.cbUProdi.FormattingEnabled = true;
            this.cbUProdi.Items.AddRange(new object[] {
            "Sistem Informasi",
            "Teknologi Informasi",
            "Informatika"});
            this.cbUProdi.Location = new System.Drawing.Point(72, 169);
            this.cbUProdi.Name = "cbUProdi";
            this.cbUProdi.Size = new System.Drawing.Size(217, 21);
            this.cbUProdi.TabIndex = 9;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(121, 217);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 10;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // formUbah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 263);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.cbUProdi);
            this.Controls.Add(this.tbUNIM);
            this.Controls.Add(this.tbUNama);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.label1);
            this.Name = "formUbah";
            this.Text = "FormUbah";
            this.Load += new System.EventHandler(this.FormUbah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox tbUNama;
        private System.Windows.Forms.TextBox tbUNIM;
        private System.Windows.Forms.ComboBox cbUProdi;
        private System.Windows.Forms.Button btnUbah;
    }
}