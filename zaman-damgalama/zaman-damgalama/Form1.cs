using System;
using System.IO;
using System.Windows.Forms;

namespace zaman_damgalama
{
    public partial class Form1 : Form
    {
        private string dosyaYolu = "zaman_damgalari.txt";

        public Form1()
        {
            InitializeComponent();
            ZamanDamgalariniYukle();
        }

        private void btnZamanDamgasiEkle_Click(object sender, EventArgs e)
        {
            string zamanDamgasi = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dgvZamanDamgalari.Rows.Add(zamanDamgasi);
            ZamanDamgasiniDosyayaKaydet(zamanDamgasi);
        }

        private void btnZamanDamgasiSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvZamanDamgalari.SelectedRows)
            {
                dgvZamanDamgalari.Rows.Remove(row);
            }
            ZamanDamgalariniDosyayaKaydet();
        }

        private void btnTumunuTemizle_Click(object sender, EventArgs e)
        {
            dgvZamanDamgalari.Rows.Clear();
            File.Delete(dosyaYolu);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtAra.Text.ToLower();
            foreach (DataGridViewRow row in dgvZamanDamgalari.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains(aramaMetni))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void ZamanDamgalariniYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                string[] zamanDamgalari = File.ReadAllLines(dosyaYolu);
                foreach (string zamanDamgasi in zamanDamgalari)
                {
                    dgvZamanDamgalari.Rows.Add(zamanDamgasi);
                }
            }
        }

        private void ZamanDamgasiniDosyayaKaydet(string zamanDamgasi)
        {
            using (StreamWriter sw = File.AppendText(dosyaYolu))
            {
                sw.WriteLine(zamanDamgasi);
            }
        }

        private void ZamanDamgalariniDosyayaKaydet()
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (DataGridViewRow row in dgvZamanDamgalari.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        sw.WriteLine(row.Cells[0].Value.ToString());
                    }
                }
            }
        }
    }
}