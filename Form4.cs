using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_okul_veri_sistemi_uygulaması
{
    public partial class Form_ogrenci_giris : Form
    {
        public Form_ogrenci_giris()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-8S3J1T5\\SQLEXPRESS;Initial Catalog=e_okul_veri_sistemi;Integrated Security=True;Encrypt=False";

        SqlConnection con = new SqlConnection(constring);


        public int txt1;
        public string txt2;
        private void button_ogrenci_giris_Click(object sender, EventArgs e)
        {
            txt1 = Convert.ToInt32(textBox1.Text);
             txt2 = (textBox2.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from e_okul_ogrenci_tablosu where ogrenci_no='"+txt1+"'",con);
            if (cmd.ExecuteScalar().ToString() == "1")
            {
                SqlCommand cmd2 = new SqlCommand("select ogrenci_isim from e_okul_ogrenci_tablosu where ogrenci_no='"+txt1+"'", con);
                if (txt2 == cmd2.ExecuteScalar().ToString())
                { 
                    Form_ogrenci_bilgi_sistemi frm = new Form_ogrenci_bilgi_sistemi();
                    frm.ogrenciNO = textBox1.Text;
                    frm.Show(); 
                }
                else
                {
                    MessageBox.Show("öğrenci ismi hatalı!");
                }
            }
            else
            {
                MessageBox.Show("böyle bir öğrenci kaydı bulunmamaktadır");
            }
            con.Close();
        }

    }
}
