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
    public partial class frm_ogretmenbilgiguncelle : Form
    {
        public frm_ogretmenbilgiguncelle()
        {
            InitializeComponent();
        }
        public string no;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_etuttakip;Integrated Security=True");
        void listele() 
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_ogretmenler where ogretmen_no=" + no, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                msk_ogretmenno.Text = dr[0].ToString();
                txt_ogretmenad.Text = dr[1].ToString();
                txt_ogretmensoyad.Text = dr[2].ToString();
                txt_ogretmenparola.Text = dr[4].ToString();
            }
            baglanti.Close();
        }
        private void frm_ogretmenbilgiguncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update tbl_ogretmenler set ogretmen_ad=@ad,ogretmen_soyad=@soyad,ogretmen_parola=@parola where ogretmen_no=@no", baglanti);
            cmd.Parameters.AddWithValue("@ad", txt_ogretmenad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_ogretmensoyad.Text);
            cmd.Parameters.AddWithValue("@parola", txt_ogretmenparola.Text);
            cmd.Parameters.AddWithValue("@no", msk_ogretmenno.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            listele();
        }
    }
}
