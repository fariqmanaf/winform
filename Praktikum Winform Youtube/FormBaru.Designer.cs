namespace Praktikum_Winform_Youtube
{
    partial class formBaru
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNIM = new System.Windows.Forms.TextBox();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT DATA MAHASISWA";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(26, 78);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(41, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama :";
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIM.Location = new System.Drawing.Point(34, 125);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(33, 13);
            this.lblNIM.TabIndex = 2;
            this.lblNIM.Text = "NIM :";
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdi.Location = new System.Drawing.Point(30, 172);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(37, 13);
            this.lblProdi.TabIndex = 3;
            this.lblProdi.Text = "Prodi :";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(121, 218);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(73, 78);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(213, 20);
            this.tbNama.TabIndex = 5;
            // 
            // tbNIM
            // 
            this.tbNIM.Location = new System.Drawing.Point(73, 122);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(213, 20);
            this.tbNIM.TabIndex = 6;
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "Sistem Informasi",
            "Teknologi Informasi",
            "Informatika"});
            this.cbProdi.Location = new System.Drawing.Point(73, 169);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(213, 21);
            this.cbProdi.TabIndex = 7;
            // 
            // formBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(315, 263);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.tbNIM);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.label1);
            this.Name = "formBaru";
            this.Text = "FormBaru";
            this.Load += new System.EventHandler(this.formBaru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNIM;
        private System.Windows.Forms.ComboBox cbProdi;
    }
}