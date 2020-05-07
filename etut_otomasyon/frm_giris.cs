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

namespace etut_otomasyon
{
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        private void btn_yoneticigirs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_yoneticiler where yonetici_no=@no and yonetici_parola=@parola", baglanti);
            cmd.Parameters.AddWithValue("@no", msk_yoneticinumarasi.Text);
            cmd.Parameters.AddWithValue("@parola", txt_yoneticiparola.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                frm_yonetici frmyonetici = new frm_yonetici();
                frmyonetici.yoneticino = msk_yoneticinumarasi.Text;
                frmyonetici.Show();
            }
            baglanti.Close();
        }

        private void btn_ogretmengiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select ogretmen_no,(ogretmen_ad+' '+ogretmen_soyad) from tbl_ogretmenler where ogretmen_no=@no and ogretmen_parola=@parola", baglanti);
            cmd.Parameters.AddWithValue("@no", msk_ogretmenno.Text);
            cmd.Parameters.AddWithValue("@parola", txt_ogretmenparola.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                frm_ogretmen frmogretmen = new frm_ogretmen();
                frmogretmen.ogretmenno = dr[0].ToString();
                frmogretmen.ogretmenad = dr[1].ToString();
                frmogretmen.Show();
            }
        }

        private void btn_ogrencigiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select ogrenci_no,(ogrenci_ad+' '+ogrenci_soyad) from tbl_ogrenciler where ogrenci_no=@no and ogrenci_parola=@parola", baglanti);
            cmd.Parameters.AddWithValue("@no", msk_ogrencino.Text);
            cmd.Parameters.AddWithValue("@parola", txt_ogrenciparola.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                frm_ogrenci frmogrenci = new frm_ogrenci();
                frmogrenci.no = dr[0].ToString();
                frmogrenci.ad = dr[1].ToString();
                frmogrenci.Show();
            }
        }
    }
}
