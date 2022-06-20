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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string soyisim = textBox2.Text;
            string[] asd = File.ReadAllLines("HastaKayıtları.txt");
            foreach(var i in asd)
            {
                if (i == isim + ":" + soyisim)
                {
                    MessageBox.Show("Hastanın kaydı zaten var");
                }
                
            }

        }
    }
}
