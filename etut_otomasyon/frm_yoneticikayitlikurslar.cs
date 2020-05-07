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
    public partial class frm_yoneticikayitlikurslar : Form
    {
        public frm_yoneticikayitlikurslar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select kurs_id,(ogrenci_ad+' '+ogrenci_soyad) as 'Öğrenci',(ogretmen_ad+' '+ogretmen_soyad) as 'Öğretmen',tarih,saat,onay_durumu from tbl_kurslar inner join tbl_ogrenciler on (ogrenci_no=ogrenci) inner join tbl_ogretmenler on (ogretmen_no=ogretmen)", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void frm_yoneticikayitlikurslar_Load(object sender, EventArgs e)
        {
            listele();

            SqlDataAdapter da2 = new SqlDataAdapter("select (ogretmen_ad+' '+ogretmen_soyad) as ogretmenad,ogretmen_no from tbl_ogretmenler", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmb_ogretmen.ValueMember = "ogretmen_no";
            cmb_ogretmen.DisplayMember = "ogretmenad";
            cmb_ogretmen.DataSource = dt2;

            SqlDataAdapter da3 = new SqlDataAdapter("select (ogrenci_ad+' '+ogrenci_soyad) as ogrenciad,ogrenci_no from tbl_ogrenciler",baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cmb_ogrenci.ValueMember = "ogrenci_no";
            cmb_ogrenci.DisplayMember = "ogrenciad";
            cmb_ogrenci.DataSource = dt3;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kursid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_ogrenci.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_ogretmen.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            msk_tarih.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            msk_saat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string durum = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (durum == "true")
            {
                chk_durum.Checked = true;
            }
            else if (durum == "false")
            {
                chk_durum.Checked = false;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update tbl_kurslar set ogrenci=@ogrenci,ogretmen=@ogretmen,tarih=@tarih,saat=@saat,onay_durumu=@onaydurumu where kurs_id=@id", baglanti);
            cmd.Parameters.AddWithValue("@ogrenci", cmb_ogrenci.SelectedValue);
            cmd.Parameters.AddWithValue("@ogretmen", cmb_ogretmen.SelectedValue);
            cmd.Parameters.AddWithValue("@tarih", msk_tarih.Text);
            cmd.Parameters.AddWithValue("@saat", msk_saat.Text);
            string durum;
            if (chk_durum.Checked)
            {
                durum = "true";
            }
            else
            {
                durum = "false";
            }
            cmd.Parameters.AddWithValue("@onaydurumu", durum);
            cmd.Parameters.AddWithValue("@id", txt_kursid.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kurs Güncellemesi Başarıyla Gerçekleştirildi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            baglanti.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_kurslar where kurs_id=" + txt_kursid.Text, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kurs Silindi","Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            listele();
        }
    }
}
