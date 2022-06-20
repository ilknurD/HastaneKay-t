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
    public partial class FrmHastaKayıtları : Form
    {
        public FrmHastaKayıtları()
        {
            InitializeComponent();
        }

      

       

      
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (datakayıtlar.SelectedRows.Count > 0)
            {
                    string degisecek = datakayıtlar.CurrentRow.Cells["doktor"].Value.ToString() + "-" + datakayıtlar.CurrentRow.Cells["tarih"].Value.ToString() + "-" + datakayıtlar.CurrentRow.Cells["saat"].Value.ToString() + "-" + datakayıtlar.CurrentRow.Cells["tcno"].Value.ToString();
                    File.WriteAllText("randevukayıtları.txt", File.ReadAllText("randevukayıtları.txt").Replace(degisecek, ""));
                    güncelle();
            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Satırı Seçin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmHastaKayıtları_Load(object sender, EventArgs e)
        {
            güncelle();
        }

        private void güncelle()
        {
            datakayıtlar.Rows.Clear();
            string[] veri = File.ReadAllLines("randevukayıtları.txt");
            foreach (string i in veri)
            {
                string[] bilgi = i.Split('-');
                if (bilgi.Length == 4)
                {
                   datakayıtlar.Rows.Add(bilgi[0], bilgi[1], bilgi[2], bilgi[3]);        
                }               
            }
            
        }

        private void datakayıtlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            randevu randevu = new randevu();
            randevu.ShowDialog();
        }
    }
}
