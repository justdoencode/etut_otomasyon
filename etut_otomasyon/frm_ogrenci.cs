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
    public partial class frm_ogrenci : Form
    {
        public frm_ogrenci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        public string ad;
        public string no;
        void listele()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select kurs_id,(ogretmen_ad+' '+ogretmen_soyad) as 'Öğretmen',tarih,saat from tbl_kurslar inner join tbl_ogretmenler on (ogretmen_no=ogretmen) where onay_durumu='true' and ogrenci=" + no, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        private void frm_ogrenci_Load(object sender, EventArgs e)
        {
            lbl_ad.Text = ad;
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_ders.ValueMember = "ders_no";
            cmb_ders.DisplayMember = "ders_ad";
            cmb_ders.DataSource = dt;

            listele();
        }

        private void btn_talepet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_kurslar (ogrenci,ogretmen,tarih,saat) values (@ogrenci,@ogretmen,@tarih,@saat)", baglanti);
            cmd.Parameters.AddWithValue("@ogrenci", no);
            cmd.Parameters.AddWithValue("@ogretmen", cmb_ogretmen.SelectedValue);
            cmd.Parameters.AddWithValue("@tarih", msk_tarih.Text);
            cmd.Parameters.AddWithValue("@saat", msk_saat.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kurs Başvurusu Yapıldı. Öğretmeniniz tarafından onaylandığında mevcut kurslarım kutusuna eklenecektir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
        }


        private void cmb_ders_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ogretmen.Text = "";
            SqlDataAdapter da = new SqlDataAdapter("select ogretmen_no,(ogretmen_ad+' '+ogretmen_soyad) as ogretmenad from tbl_ogretmenler where ogretmen_brans="+cmb_ders.SelectedValue, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_ogretmen.ValueMember = "ogretmen_no";
            cmb_ogretmen.DisplayMember = "ogretmenad";
            cmb_ogretmen.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kursid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_kurslar where kurs_id=" + txt_kursid.Text, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kursunuz İptal Edilmiştir","İptal",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            listele();
        }
    }
}
