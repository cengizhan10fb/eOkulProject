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
    public partial class Form_ogrenci_bilgi_sistemi : Form
    {
        public Form_ogrenci_bilgi_sistemi()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-8S3J1T5\\SQLEXPRESS;Initial Catalog=e_okul_veri_sistemi;Integrated Security=True;Encrypt=False";
        
        SqlConnection con = new SqlConnection(constring);
        
        Form_ogrenci_giris form_ogrenci_g = new Form_ogrenci_giris();

        public string ogrenciNO;

        private void Form_ogrenci_bilgi_sistemi_Load(object sender, EventArgs e)
        { 
            con.Open();
            label_ogrenci_no.Text = ogrenciNO.ToString();
            SqlCommand cmd = new SqlCommand("select ogrenci_isim, ogrenci_soyisim, ogrenci_cinsiyet, ogrenci_DT, ogrenci_sınıf, ogrenci_adres," +
            "ogrenci_not1, ogrenci_not2, ogrenci_per1, ogrenci_per2, ogrenci_ortalama, ogrenci_geçdi_kaldi From e_okul_ogrenci_tablosu where ogrenci_no=@p1", con);
            cmd.Parameters.AddWithValue("@p1", label_ogrenci_no.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label_ogrenci_isim.Text = dr[0].ToString();
                label_ogrenci_soyisim.Text = dr[1].ToString();
                label_ogrenci_cinsiyet.Text = dr[2].ToString();
                label_ogrenci_DT.Text = dr[3].ToString();
                label_ogrenci_sinif.Text = dr[4].ToString();
                label_ogrenci_adres.Text = dr[5].ToString();
                label_ogrenci_not1.Text = dr[6].ToString();
                label_ogrenci_not2.Text = dr[7].ToString();
                label_ogrenci_per1.Text = dr[8].ToString();
                label_ogrenci_per2.Text = dr[9].ToString();
                label_ogrenci_ortalama.Text = dr[10].ToString();
                label_ogrenci_durum.Text = dr[11].ToString();
            }
            con.Close();
        }
    }
}
