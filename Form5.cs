using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_okul_veri_sistemi_uygulaması
{
    public partial class Form_ogretmen_giris_sistemi : Form
    {
        public Form_ogretmen_giris_sistemi()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-8S3J1T5\\SQLEXPRESS;Initial Catalog=e_okul_veri_sistemi;Integrated Security=True;Encrypt=False";

        SqlConnection con = new SqlConnection(constring);

        private void Form_ogretmen_giris_sistemi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_okul_veri_sistemiDataSet1.e_okul_ogrenci_tablosu' table. You can move, or remove it, as needed.
            this.e_okul_ogrenci_tablosuTableAdapter1.Fill(this.e_okul_veri_sistemiDataSet1.e_okul_ogrenci_tablosu);
            // TODO: This line of code loads data into the 'e_okul_veri_sistemiDataSet._e_okul_ogrenci_tablosu' table. You can move, or remove it, as needed.
           // e_okul_ogrenci_tablosuTableAdapter.Fill(this.e_okul_veri_sistemiDataSet1.e_okul_ogrenci_tablosu);
        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            this.e_okul_ogrenci_tablosuTableAdapter1.Fill(this.e_okul_veri_sistemiDataSet1.e_okul_ogrenci_tablosu);
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into e_okul_ogrenci_tablosu (ogrenci_no, ogrenci_isim, ogrenci_soyisim, ogrenci_cinsiyet, ogrenci_DT, ogrenci_sınıf, ogrenci_adres, ogrenci_not1, ogrenci_per1, ogrenci_not2, ogrenci_per2, ogrenci_ortalama, ogrenci_geçdi_kaldi) " +
            "VALUES (@no, @isim, @soyisim, @cinsiyet, @DT, @sinif, @adres, @not1, @per1, @not2, @per2, @ortalama, @durum);", con);

            cmd.Parameters.AddWithValue("@no", maskedTextBox_ogrenci_no.Text);
            cmd.Parameters.AddWithValue("@isim", textBox_ogrenci_isim.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox_ogrenci_soyisim.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox_ogrenci_cinsiyet.Text);
            cmd.Parameters.AddWithValue("@DT", maskedTextBox_ogrenci_DT.Text);
            cmd.Parameters.AddWithValue("@sinif", textBox_ogrenci_sınıf.Text);
            cmd.Parameters.AddWithValue("@adres", textBox_ogrenci_adres.Text);
            cmd.Parameters.AddWithValue("@not1", maskedTextBox_not1.Text);
            cmd.Parameters.AddWithValue("@per1", maskedTextBox_per1.Text);
            cmd.Parameters.AddWithValue("@not2", maskedTextBox_not2.Text);
            cmd.Parameters.AddWithValue("@per2", maskedTextBox_per2.Text);

            int not1 = int.Parse(maskedTextBox_not1.Text);
            int not2 = int.Parse(maskedTextBox_not2.Text);
            int per1 = int.Parse(maskedTextBox_per1.Text);
            int per2 = int.Parse(maskedTextBox_per2.Text);
            float ortalama = (not1 + not2 + per1 + per2) / 4;
            string durum;

            if (not1 == null)
            {
                ortalama = (not2 + per1 + per2) / 3;
            }
            else if (not2 == null)
            {
                ortalama = (not1 + per1 + per2) / 3;
            }
            else if (per1 == null)
            {
                ortalama = (not1 + not2 + per2) / 3;
            }
            else if (per2 == null)
            {
                ortalama = (not1 + not2 + per1) / 3;
            }
            else if (not1 == null && not2 == null)
            {
                ortalama = (per1 + per2) / 2;
            }
            else if (not1 == null && per1 == null)
            {
                ortalama = (not2 + per2) / 2;
            }
            else if (not1 == null && per2 == null)
            {
                ortalama = (not2 + per1) / 2;
            }
            else if (not2 == null && per1 == null)
            {
                ortalama = (not1 + per2) / 2;
            }
            else if (not2 == null && per2 == null)
            {
                ortalama = (not1 + per1) / 2;
            }
            else if (per1 == null && per2 == null)
            {
                ortalama = (not1 + not2) / 2;
            }
            else
            {
                ortalama = (not1 + not2 + per1 + per2) / 4;
            }
           

            if (ortalama >= 50)
            {
                durum = "geçti";
            }
            else
            {
                durum = "kaldı";
            }

            cmd.Parameters.AddWithValue("@ortalama", ortalama.ToString("0.00"));
            cmd.Parameters.AddWithValue("@durum", durum);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from e_okul_ogrenci_tablosu where ogrenci_no=@no", con);
            cmd.Parameters.AddWithValue("@no", maskedTextBox_ogrenci_no.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update e_okul_ogrenci_tablosu set ogrenci_isim=@isim,ogrenci_soyisim=@soyisim,ogrenci_cinsiyet=@cinsiyet,ogrenci_DT=@DT,ogrenci_sınıf=@sınıf,ogrenci_adres=@adres,ogrenci_not1=@not1,ogrenci_not2=@not2,ogrenci_per1=@per1,ogrenci_per2=@per2,ogrenci_ortalama=@ortalama,ogrenci_geçdi_kaldi=@durum where ogrenci_no=@no",con);
            cmd.Parameters.AddWithValue("@no", maskedTextBox_ogrenci_no.Text);
            cmd.Parameters.AddWithValue("@isim", textBox_ogrenci_isim.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox_ogrenci_soyisim.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox_ogrenci_cinsiyet.Text);
            cmd.Parameters.AddWithValue("@DT", maskedTextBox_ogrenci_DT.Text);
            cmd.Parameters.AddWithValue("@sınıf", textBox_ogrenci_sınıf.Text);
            cmd.Parameters.AddWithValue("@adres", textBox_ogrenci_adres.Text);
            cmd.Parameters.AddWithValue("@not1", maskedTextBox_not1.Text);
            cmd.Parameters.AddWithValue("@per1", maskedTextBox_per1.Text);
            cmd.Parameters.AddWithValue("@not2", maskedTextBox_not2.Text);
            cmd.Parameters.AddWithValue("@per2", maskedTextBox_per2.Text);

            int not1 = int.Parse(maskedTextBox_not1.Text);
            int not2 = int.Parse(maskedTextBox_not2.Text);
            int per1 = int.Parse(maskedTextBox_per1.Text);
            int per2 = int.Parse(maskedTextBox_per2.Text);
            float ortalama = (not1 + not2 + per1 + per2) / 4; ;
            string durum;

            if (not1 == null)
            {
                ortalama = (not2 + per1 + per2) / 3;
            }
            else if (not2 == null)
            {
                ortalama = (not1 + per1 + per2) / 3;
            }
            else if (per1 == null)
            {
                ortalama = (not1 + not2 + per2) / 3;
            }
            else if (per2 == null)
            {
                ortalama = (not1 + not2 + per1) / 3;
            }
            else if (not1 == null && not2 == null)
            {
                ortalama = (per1 + per2) / 2;
            }
            else if (not1 == null && per1 == null)
            {
                ortalama = (not2 + per2) / 2;
            }
            else if (not1 == null && per2 == null)
            {
                ortalama = (not2 + per1) / 2;
            }
            else if (not2 == null && per1 == null)
            {
                ortalama = (not1 + per2) / 2;
            }
            else if (not2 == null && per2 == null)
            {
                ortalama = (not1 + per1) / 2;
            }
            else if (per1 == null && per2 == null)
            {
                ortalama = (not1 + not2) / 2;
            }
            else 
            {
                ortalama = (not1 + not2 + per1 + per2) / 4;
            }


            if(ortalama >= 50)
            {
                durum = "geçdi";
            }
            else
            {
                durum = "kaldi";
            }
            cmd.Parameters.AddWithValue("@ortalama", ortalama.ToString("0.00"));
            cmd.Parameters.AddWithValue("@durum", durum);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            maskedTextBox_ogrenci_no.Text = "";
            textBox_ogrenci_isim.Text = "";
            textBox_ogrenci_soyisim.Text = "";
            comboBox_ogrenci_cinsiyet.Text = "";
            maskedTextBox_ogrenci_DT.Text = "";
            textBox_ogrenci_sınıf.Text = "";
            textBox_ogrenci_adres.Text = "";
            maskedTextBox_not1.Text = "";
            maskedTextBox_not2.Text = "";
            maskedTextBox_per1.Text = "";
            maskedTextBox_per2.Text = "";
        }
        public int secim;
        
        private  void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secim = dataGridView.SelectedCells[0].RowIndex;
            maskedTextBox_ogrenci_no.Text = dataGridView.Rows[secim].Cells[0].Value.ToString();
            textBox_ogrenci_isim.Text = dataGridView.Rows[secim].Cells[1].Value.ToString();
            textBox_ogrenci_soyisim.Text = dataGridView.Rows[secim].Cells[2].Value.ToString();
            comboBox_ogrenci_cinsiyet.Text = dataGridView.Rows[secim].Cells[3].Value.ToString();
            maskedTextBox_ogrenci_DT.Text = dataGridView.Rows[secim].Cells[4].Value.ToString();
            textBox_ogrenci_sınıf.Text = dataGridView.Rows[secim].Cells[5].Value.ToString();
            textBox_ogrenci_adres.Text = dataGridView.Rows[secim].Cells[6].Value.ToString();
            maskedTextBox_not1.Text = dataGridView.Rows[secim].Cells[7].Value.ToString();
            maskedTextBox_not2.Text = dataGridView.Rows[secim].Cells[8].Value.ToString();
            maskedTextBox_per1.Text = dataGridView.Rows[secim].Cells[9].Value.ToString();
            maskedTextBox_per2.Text = dataGridView.Rows[secim].Cells[10].Value.ToString();


        }
    }
}
