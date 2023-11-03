using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_Winform_Youtube.App.Models
{
    internal class M_Mahasiswa
    {
        public int? id { get; set; }
        public string nama { get; set; }
        public string NIM { get; set; }
        public string Prodi { get; set; }

        private static List<M_Mahasiswa> dataMahasiswa = new List<M_Mahasiswa>
        {
            new M_Mahasiswa
            {
                id = 1,
                nama = "Fariq Abdhe Manaf",
                NIM = "222410101069",
                Prodi = "Sistem Informasi"
            },
            new M_Mahasiswa
            {
                id = 2,
                nama = "Fariq Lagi",
                NIM = "222410102070",
                Prodi = "Teknologi Informasi"
            }
        };

        public static List<M_Mahasiswa> all()
        {
            return dataMahasiswa;
        }

        public static M_Mahasiswa getByID(int id)
        {
            return dataMahasiswa.FirstOrDefault(m => m.id == id);
        }

        public static void create(string nama, string NIM, string Prodi)
        {
            int nextid = dataMahasiswa.Count + 1;
            M_Mahasiswa newMahasiswa = new M_Mahasiswa()
            {
                id = nextid,
                nama = nama,
                NIM = NIM,
                Prodi = Prodi
            };

            dataMahasiswa.Add(newMahasiswa);
        }

        public static void destroy(int id)
        {
            var hapusMahasiswa = dataMahasiswa.FirstOrDefault(m => m.id == id);
            dataMahasiswa.Remove(hapusMahasiswa);
        }

        public static void update(int id, string nama, string NIM, string Prodi)
        {
            var mahasiswaToUpdate = dataMahasiswa.FirstOrDefault(m => m.id == id);
            if (mahasiswaToUpdate != null)
            {
                mahasiswaToUpdate.nama = nama;
                mahasiswaToUpdate.NIM = NIM;
                mahasiswaToUpdate.Prodi = Prodi;
            }
        }
    }
}
