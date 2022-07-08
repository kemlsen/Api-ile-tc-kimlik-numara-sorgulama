using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace TC_Kimlik_Api_Ornegi
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            long tc = long.Parse(textBox3.Text);
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            int yil = Convert.ToInt32(textBox4.Text);
            kimlik.KPSPublicSoapClient kontrol = new kimlik.KPSPublicSoapClient();
            bool durum = kontrol.TCKimlikNoDogrula(tc, ad, soyad, yil);
            if (durum==true)
            {
                MessageBox.Show("Girilen kimlik bilgileri doğrudur");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                form2.txtad.Text = textBox1.Text;
                form2.txtsoyad.Text= textBox2.Text;
                form2.txttc.Text = textBox3.Text;
                form2.txtyil.Text = textBox4.Text;

            }
            else
            {
                MessageBox.Show("Böyle bir vatandaş bulunmamaktadır");
            }
            
        }
    }
}
