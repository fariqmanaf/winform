namespace Praktikum_Winform_Youtube
{
    partial class formAwal
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.tabelMahasiswa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Window;
            this.btnTambah.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(291, 338);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(103, 23);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah Data";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tabelMahasiswa
            // 
            this.tabelMahasiswa.AllowUserToAddRows = false;
            this.tabelMahasiswa.AllowUserToDeleteRows = false;
            this.tabelMahasiswa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabelMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelMahasiswa.Location = new System.Drawing.Point(12, 32);
            this.tabelMahasiswa.Name = "tabelMahasiswa";
            this.tabelMahasiswa.ReadOnly = true;
            this.tabelMahasiswa.Size = new System.Drawing.Size(677, 290);
            this.tabelMahasiswa.TabIndex = 1;
            this.tabelMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelMahasiswa_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "DATA MAHASISWA";
            // 
            // formAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(701, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabelMahasiswa);
            this.Controls.Add(this.btnTambah);
            this.Name = "formAwal";
            this.Text = "FormAwal";
            this.Load += new System.EventHandler(this.formAwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView tabelMahasiswa;
        private System.Windows.Forms.Label label1;
    }
}

