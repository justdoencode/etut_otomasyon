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
    public partial class frm_ogretmen : Form
    {
        public frm_ogretmen()
        {
            InitializeComponent();
        }
        public string ogretmenno;
        public string ogretmenad;
        void onaysızlistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select kurs_id,(ogrenci_ad+' '+ogrenci_soyad) as 'Öğrenci',tarih,saat from tbl_kurslar inner join tbl_ogrenciler on (ogrenci_no=ogrenci) where onay_durumu='false' and ogretmen=" + ogretmenno, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        void onaylıdersler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select kurs_id,(ogrenci_ad+' '+ogrenci_soyad) as 'Öğrenci',tarih,saat from tbl_kurslar inner join tbl_ogrenciler on (ogrenci_no=ogrenci) where onay_durumu='true' and ogretmen=" + ogretmenno, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        private void frm_ogretmen_Load(object sender, EventArgs e)
        {
            lbl_ad.Text=ogretmenad;
            onaysızlistele();
            onaylıdersler();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kursid.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update tbl_kurslar set onay_durumu='True' where kurs_id=@id", baglanti);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_kursid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kurs Onaylandı","Onay",MessageBoxButtons.OK,MessageBoxIcon.Information);
            onaysızlistele();
            onaylıdersler();
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_onaylikursid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            msk_tarih.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            msk_saat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update tbl_kurslar set onay_durumu='false' where kurs_id=" + txt_onaylikursid.Text, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ders İptal Edildi","İptal",MessageBoxButtons.OK,MessageBoxIcon.Information);
            onaylıdersler();
            onaysızlistele();
            baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update tbl_kurslar set tarih=@tarih,saat=@saat where kurs_id=@id", baglanti);
            cmd.Parameters.AddWithValue("@tarih", msk_tarih.Text);
            cmd.Parameters.AddWithValue("@saat", msk_saat.Text);
            cmd.Parameters.AddWithValue("@id", txt_onaylikursid.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kurs Güncellendi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            onaylıdersler();
            onaysızlistele();
        }

        private void btn_bilgiguncelle_Click(object sender, EventArgs e)
        {
            frm_ogretmenbilgiguncelle frmogretmenbilgiguncelle = new frm_ogretmenbilgiguncelle();
            frmogretmenbilgiguncelle.no = ogretmenno;
            frmogretmenbilgiguncelle.Show();
        }
    }
}
