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
    public partial class frm_kayitliogrenciler : Form
    {
        public frm_kayitliogrenciler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ogrenciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_kayitliogrenciler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            msk_ogrencino.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ogrenciad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ogrencisoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ogrenciparola.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update tbl_ogrenciler set ogrenci_ad=@ad,ogrenci_soyad=@soyad,ogrenci_parola=@parola where ogrenci_no=@no", baglanti);
            cmd.Parameters.AddWithValue("@ad", txt_ogrenciad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_ogrencisoyad.Text);
            cmd.Parameters.AddWithValue("@parola", txt_ogrenciparola.Text);
            cmd.Parameters.AddWithValue("@no", msk_ogrencino.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_ogrenciler where ogrenci_no=@no", baglanti);
            cmd.Parameters.AddWithValue("@no", msk_ogrencino.Text.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Silindi","Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            baglanti.Close();
        }
    }
}
