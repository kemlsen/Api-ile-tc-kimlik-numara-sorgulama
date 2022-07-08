using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;

namespace TC_Kimlik_Api_Ornegi
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-RF82O7V;Initial Catalog=Uygulama;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            veri();
            
        }
        public void veri()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from bilgiler",connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource= dataTable;
            connection.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into bilgiler(tc,ad,soyad,yil,cvv,sonkullanma,kredimiktari) values (@tc,@ad,@soyad,@yil,@cvv,@sonkullanma,@kredimiktari)",connection);
            cmd.Parameters.AddWithValue("@tc",txttc.Text);
            cmd.Parameters.AddWithValue("@ad", txtad.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@yil", txtyil.Text);
            cmd.Parameters.AddWithValue("@cvv", txtcvv.Text);
            cmd.Parameters.AddWithValue("@sonkullanma", txtson.Text);
            cmd.Parameters.AddWithValue("@kredimiktari", txtkredi.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            veri();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from bilgiler where tc=@tc", connection);
            cmd.Parameters.AddWithValue("@tc", txttc.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            veri();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update bilgiler set tc=@tc,ad=@ad,soyad=@soyad,yil=@yil,cvv=@cvv,sonkullanma=@sonkullanma,kredimiktari=@kredimiktari where tc=@tc", connection);
            cmd.Parameters.AddWithValue("@tc", txttc.Text);
            cmd.Parameters.AddWithValue("@ad", txtad.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@yil", txtyil.Text);
            cmd.Parameters.AddWithValue("@cvv", txtcvv.Text);
            cmd.Parameters.AddWithValue("@sonkullanma", txtson.Text);
            cmd.Parameters.AddWithValue("@kredimiktari", txtkredi.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            veri();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtyil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtcvv.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtson.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtkredi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }
    }
    
    

}
