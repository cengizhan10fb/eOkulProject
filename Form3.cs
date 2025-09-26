using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace e_okul_veri_sistemi_uygulaması
{
    public partial class Form_ogretmen_giris : Form
    {
        public Form_ogretmen_giris()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-8S3J1T5\\SQLEXPRESS;Initial Catalog=e_okul_veri_sistemi;Integrated Security=True;Encrypt=False";

        SqlConnection con = new SqlConnection(constring);

        private void button_ogretmen_giris_kontrol_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from e_okul_ogretmen_tablosu where ogretmen_isim='"+textBox_ogretmen_isim.Text+"'",con);
            
            if(cmd.ExecuteScalar().ToString() == "1") {

                SqlCommand sifre = new SqlCommand("select ogretmen_sifre from e_okul_ogretmen_tablosu where ogretmen_isim='"+textBox_ogretmen_isim.Text+"'",con);
                if (textBox_ogretmen_sifre.Text == sifre.ExecuteScalar().ToString())
                {
                    Form_ogretmen_giris_sistemi form_Ogretmen_Giris_Sistemi = new Form_ogretmen_giris_sistemi();
                    form_Ogretmen_Giris_Sistemi.Show();
                }
                else
                {
                    MessageBox.Show("hatalı bir şifre girdiniz");
                }
            }
            else
            {
                MessageBox.Show("böyle bir kullanıcı bulunamadı.");
            }
            con.Close();
        }
    }
}
