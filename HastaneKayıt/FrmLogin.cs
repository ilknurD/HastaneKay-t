using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneKayıt
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string degisecek = dataGridView1.CurrentRow.Cells["isim"].Value.ToString() +
                    ":" +
                    dataGridView1.CurrentRow.Cells["soyisim"].Value.ToString() +
                    ":" +
                    dataGridView1.CurrentRow.Cells["numara"].Value.ToString();
                File.WriteAllText("hastanekayıt.txt", File.ReadAllText("hastanekayıt.txt").Replace(degisecek, ""));
                listeguncelle();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            listeguncelle();
        }


        private void listeguncelle()
        {
            dataGridView1.Rows.Clear(); // eski satırları temizle
            string[] veri = File.ReadAllLines("hastanekayıt.txt"); // dosyayı oku
            foreach (string i in veri) // tüm satırlar için işlem yap
            {
                string[] bilgi = i.Split(':'); //
                if(bilgi.Length == 3)
                {
                    dataGridView1.Rows.Add(bilgi[0], bilgi[1], bilgi[2]);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıtları frmHastaKayıtları = new FrmHastaKayıtları();
            frmHastaKayıtları.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
