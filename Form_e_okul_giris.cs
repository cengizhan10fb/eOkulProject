using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_okul_veri_sistemi_uygulaması
{
    public partial class Form_e_okul_giris : Form
    {
        public Form_e_okul_giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ogretmen_giris form_Ogretmen_Giris = new Form_ogretmen_giris();
            
            form_Ogretmen_Giris.Show();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ogrenci_giris form_Ogrenci_Giris = new Form_ogrenci_giris();
            
            form_Ogrenci_Giris.Show();
        }
    }
};
