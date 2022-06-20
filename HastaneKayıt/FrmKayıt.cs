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
    public partial class FrmKayıt : Form
    {
        public FrmKayıt()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string isim = TxtName.Text;
            string soyisim = TxtSurname.Text;
            string no = TxtNo.Text;
            if (File.Exists("hastanekayıt.txt")) // Exists dosyanın olup olmadığı kontrol eder varsa true döner yoksa false döner
            {
                File.WriteAllText("hastanekayıt.txt",File.ReadAllText("hastanekayıt.txt") + isim + ":" + soyisim + ":" + no + Environment.NewLine);
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu");
                TxtName.Clear();
                TxtSurname.Clear();
                TxtNo.Clear();
                
            }
            else
            {
                File.WriteAllText("hastanekayıt.txt", isim + ":" + soyisim + ":" + no + Environment.NewLine);
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu");
                
            }
            Close();
        }
    }
}
