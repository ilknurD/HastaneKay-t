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
    public partial class randevu : Form
    {
        public randevu()
        {
            InitializeComponent();
        }

        private void randevu_Load(object sender, EventArgs e)
        {
            dtpSaat.MinDate = DateTime.Parse("9:00:00");
            dtpSaat.MaxDate = DateTime.Parse("17:00:00");
            dtpTarih.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string doktor = CmbxDoctor.Text;            
            string tarih = dtpTarih.Text;
            string saat = dtpSaat.Text;
            string TcNo = txtTcNo.Text;

            if (string.IsNullOrEmpty(TcNo) || TcNo.Length != 11)//TcNo boşsa ve 11 haneli değilse 
            {
                MessageBox.Show("Eksik Veya Hatalı Bilgi Girdiniz");
                return;
            }

            if (File.Exists("randevukayıtları.txt"))//EĞER TXT VAR İSE
            {
                bool kayitvar = false;
                string[] asd = File.ReadAllLines("randevukayıtları.txt");
                foreach (var i in asd)//SATIR SATIR İŞLEM YAP
                {
                    if (i.Contains(doktor + "-" + tarih + "-" + saat))
                    {
                        MessageBox.Show("Doktor dolu");
                        kayitvar = true;//KAYIT VAR
                        break;
                    }
                    if (i.Contains(doktor + "-" + tarih + "-" + saat + "-" + TcNo))//EĞER n'imci satır içeriyorsa (contains içeriyorsa demektir)
                    {
                        MessageBox.Show("Hastanın Kaydı Zaten Var");
                        break;
                    }
                }
                if (!kayitvar)//kayıt yoksa kayıt oluştur
                {
                    File.WriteAllText("randevukayıtları.txt", File.ReadAllText("randevukayıtları.txt") + doktor + "-" + tarih + "-" + saat + "-" + TcNo + Environment.NewLine);
                    MessageBox.Show("Kayıt Oluşturuldu");
                    
                }

            }
            else//txt yoksa
            {
                File.WriteAllText("randevukayıtları.txt", File.ReadAllText("randevukayıtları.txt") + doktor + "-" + tarih + "-" + saat + "-" + TcNo + Environment.NewLine);
                MessageBox.Show("Kayıt Oluşturuldu");
            }

        }
        
    }
}
