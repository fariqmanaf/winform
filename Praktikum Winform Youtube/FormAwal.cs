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
    public partial class formAwal : Form
    {
        public formAwal()
        {
            InitializeComponent();

            tabelMahasiswa.DataSource = M_Mahasiswa.all();
            DataGridViewButtonColumn ubahButton = new DataGridViewButtonColumn();
            ubahButton.HeaderText = "Ubah";
            ubahButton.Text = "Update";
            ubahButton.Name = "ubahButton";
            ubahButton.UseColumnTextForButtonValue = true;
            tabelMahasiswa.Columns.Insert(0, ubahButton);

            tabelMahasiswa.DataSource = M_Mahasiswa.all();
            DataGridViewButtonColumn hapusButton = new DataGridViewButtonColumn();
            hapusButton.HeaderText = "Hapus";
            hapusButton.Text = "Delete";
            hapusButton.Name = "hapusButton";
            hapusButton.UseColumnTextForButtonValue = true;
            tabelMahasiswa.Columns.Insert(1, hapusButton);
        }

        private void formAwal_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (formBaru formSlide = new formBaru())
            {
                formBaru halamanBaru = new formBaru();
                halamanBaru.ShowDialog();
            }
            tabelMahasiswa.DataSource = null;
            tabelMahasiswa.DataSource = M_Mahasiswa.all();
        }

        private void tabelMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabelMahasiswa.Columns["hapusButton"].Index && e.RowIndex >= -0)
            {
                int idToDelete = Convert.ToInt32(tabelMahasiswa.Rows[e.RowIndex].Cells["Id"].Value);
                M_Mahasiswa.destroy(idToDelete);

                tabelMahasiswa.DataSource = null;
                tabelMahasiswa.DataSource = M_Mahasiswa.all();
            }

            if (e.ColumnIndex == tabelMahasiswa.Columns["ubahButton"].Index && e.RowIndex >= -0)
            {
                int idToUpdate = Convert.ToInt32(tabelMahasiswa.Rows[e.RowIndex].Cells["Id"].Value);
                using (formUbah formUpdate = new formUbah(idToUpdate))
                {
                    formUbah halamanUpdate = new formUbah(idToUpdate);
                    halamanUpdate.ShowDialog();
                }
                tabelMahasiswa.DataSource = null;
                tabelMahasiswa.DataSource = M_Mahasiswa.all();
            }
        }
    }
}
