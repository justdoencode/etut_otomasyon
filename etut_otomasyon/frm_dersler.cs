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
    public partial class frm_dersler : Form
    {
        public frm_dersler()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        private void frm_dersekle_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_dersler (ders_no,ders_ad) values (@no,@ad)", baglanti);
                cmd.Parameters.AddWithValue("@no", msk_dersno.Text);
                cmd.Parameters.AddWithValue("@ad", txt_dersad.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Ders Eklendi", "Ders Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Ders Numarası Ve Adını Benzersiz Ve Geçerli Karakterlerle Oluşturunuz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            msk_dersno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_dersad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("delete from tbl_dersler where ders_no=@no", baglanti);
            cmd2.Parameters.AddWithValue("@no", msk_dersno.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Ders Silindi","Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            baglanti.Close();
        }
    }
}
