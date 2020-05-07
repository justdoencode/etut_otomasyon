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
    public partial class frm_yoneticibilgiguncelle : Form
    {
        public frm_yoneticibilgiguncelle()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        public string no;
        private void frm_yoneticibilgiguncelle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_yoneticiler where yonetici_no=@no", baglanti);
            cmd.Parameters.AddWithValue("@no", no);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                msk_yoneticino.Text = dr[0].ToString();
                txt_yoneticiad.Text = dr[1].ToString();
                txt_yoneticisoyad.Text = dr[2].ToString();
                txt_yoneticiparola.Text = dr[3].ToString();
            }
            baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update tbl_yoneticiler set yonetici_ad=@ad,yonetici_soyad=@soyad,yonetici_parola=@parola where yonetici_no=@no", baglanti);
            cmd.Parameters.AddWithValue("@ad", txt_yoneticiad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_yoneticisoyad.Text);
            cmd.Parameters.AddWithValue("@parola", txt_yoneticiparola.Text);
            cmd.Parameters.AddWithValue("@no", msk_yoneticino.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Güncellendi","Güncellenme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
