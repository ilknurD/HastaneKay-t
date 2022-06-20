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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKayıt frmKayıt = new FrmKayıt();
            frmKayıt.ShowDialog();
                
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string[] tx = File.ReadAllLines("hastanekayıt.txt");
            string kontrol = TxtName.Text + ":" + TxtSurname.Text + ":" + TxtNo.Text;
            bool basari = false;
            foreach ( var satir in tx)
            {
                if (satir == kontrol)
                {
                    MessageBox.Show("Başarıyla Giriş Yapıldı");
                    TxtName.Clear();
                    TxtSurname.Clear();
                    TxtNo.Clear();                   
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.ShowDialog();

                    basari = true;
                    break;
                }
                
            }
            if (basari == false)
            {
                MessageBox.Show("Kayıt Bulunamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
