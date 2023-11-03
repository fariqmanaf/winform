using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktikum_Winform_Youtube.App.Models;

namespace Praktikum_Winform_Youtube
{
    public partial class formBaru : Form
    {
        public formBaru()
        {
            InitializeComponent();
        }

        private void formBaru_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var Nama = tbNama.Text;
            var Nim = tbNIM.Text;
            var prodi = cbProdi.Text;

            M_Mahasiswa.create(Nama, Nim, prodi);

            DialogResult message = MessageBox.Show("Data Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK);

            if (message == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
