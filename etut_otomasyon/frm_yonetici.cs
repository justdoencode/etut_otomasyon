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
    public partial class frm_yonetici : Form
    {
        public frm_yonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        public string yoneticino;
        private void btn_ogrencikaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_ogrenciler (ogrenci_no,ogrenci_ad,ogrenci_soyad,ogrenci_parola) values (@no,@ad,@soyad,@parola)", baglanti);
            cmd.Parameters.AddWithValue("@no", msk_ogrencino.Text);
            cmd.Parameters.AddWithValue("@ad", txt_ogrenciad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_ogrencisoyad.Text);
            cmd.Parameters.AddWithValue("@parola", txt_ogrenciparola.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yeni Öğrenci Kaydı Başarıyla Gerçekleştirildi","Yeni Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
        }
        private void btn_dersler_Click_1(object sender, EventArgs e)
        {
            frm_dersler frmdersler = new frm_dersler();
            frmdersler.Show();
        }

        private void frm_yonetici_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select (yonetici_ad+' '+yonetici_soyad) from tbl_yoneticiler where yonetici_no=@no", baglanti);
            cmd.Parameters.AddWithValue("@no", yoneticino);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_ad.Text = dr[0].ToString();
            }
            baglanti.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_brans.DataSource = dt;
            cmb_brans.DisplayMember = "ders_ad";
            cmb_brans.ValueMember = "ders_no";
        }

        private void btn_bilgiguncelle_Click(object sender, EventArgs e)
        {
            frm_yoneticibilgiguncelle frmguncelle = new frm_yoneticibilgiguncelle();
            frmguncelle.no = yoneticino;
            frmguncelle.Show();
        }

        private void btn_ogrenciler_Click(object sender, EventArgs e)
        {
            frm_kayitliogrenciler frmkayitliogrenciler = new frm_kayitliogrenciler();
            frmkayitliogrenciler.Show();
        }

        private void btn_ogretmenler_Click(object sender, EventArgs e)
        {
            frm_kayitliogretmenler frmkayitliogretmenler = new frm_kayitliogretmenler();
            frmkayitliogretmenler.Show();
        }

        private void btn_ogretmenekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_ogretmenler (ogretmen_no,ogretmen_ad,ogretmen_soyad,ogretmen_brans,ogretmen_parola) values (@no,@ad,@soyad,@brans,@parola)", baglanti);
            cmd.Parameters.AddWithValue("@no", msk_ogretmenno.Text);
            cmd.Parameters.AddWithValue("@ad", txt_ogretmenad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_ogretmensoyad.Text);
            cmd.Parameters.AddWithValue("@brans",cmb_brans.SelectedValue);
            cmd.Parameters.AddWithValue("@parola",txt_ogretmenparola.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğretmen Kaydı Başarıyla Gerçekleştirildi","Yeni Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_kurslar_Click(object sender, EventArgs e)
        {
            frm_yoneticikayitlikurslar frmkayitlikurslar = new frm_yoneticikayitlikurslar();
            frmkayitlikurslar.Show();
        }
    }
}
