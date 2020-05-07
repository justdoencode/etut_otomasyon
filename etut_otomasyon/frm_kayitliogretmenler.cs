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
    public partial class frm_kayitliogretmenler : Form
    {
        public frm_kayitliogretmenler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select ogretmen_no,ogretmen_ad,ogretmen_soyad,tbl_dersler.ders_ad,ogretmen_parola from tbl_ogretmenler inner join tbl_dersler on(tbl_dersler.ders_no = ogretmen_brans)", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_dersler", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmb_brans.DataSource = dt2;
            cmb_brans.DisplayMember = "ders_ad";
            cmb_brans.ValueMember = "ders_no";
        }
        private void frm_kayitliogretmenler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            msk_ogretmenno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ogretmenad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ogretmensoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ogretmenparola.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update tbl_ogretmenler set ogretmen_ad=@ad,ogretmen_soyad=@soyad,ogretmen_parola=@parola,ogretmen_brans=@brans where ogretmen_no=@no", baglanti);
            cmd.Parameters.AddWithValue("@ad", txt_ogretmenad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_ogretmensoyad.Text);
            cmd.Parameters.AddWithValue("@brans", cmb_brans.SelectedValue);
            cmd.Parameters.AddWithValue("@parola", txt_ogretmenparola.Text);
            cmd.Parameters.AddWithValue("@no", msk_ogretmenno.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Güncellendi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_ogretmenler where ogretmen_no=" + msk_ogretmenno.Text, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğretmen Sistemden Silindi","Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            listele();
        }
    }
}
