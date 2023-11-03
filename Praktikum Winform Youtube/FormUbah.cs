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
    public partial class formUbah : Form
    {
        private int idMahasiswa;
        public formUbah(int idMahasiswa)
        {
            InitializeComponent();
            this.idMahasiswa = idMahasiswa;
            var dataMahasiswa = M_Mahasiswa.getByID(this.idMahasiswa);
            tbUNama.Text = dataMahasiswa.nama;
            tbUNIM.Text = dataMahasiswa.NIM;
            cbUProdi.Text = dataMahasiswa.Prodi;
        }

        private void FormUbah_Load(object sender, EventArgs e)
        {

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            var nama = tbUNama.Text;
            var nim = tbUNIM.Text;
            var prodi = cbUProdi.Text;

            M_Mahasiswa.update(this.idMahasiswa, nama, nim, prodi);

            DialogResult message = MessageBox.Show("Data Berhasil Diubah", "Sukses", MessageBoxButtons.OK);

            if (message == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
