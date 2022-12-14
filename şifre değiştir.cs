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

namespace _202503024__Mercan_Esen_
{
    public partial class şifre_değiştir : Form
    {
        public şifre_değiştir()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        public  string SqlCon = "Data Source=DESKTOP-4R0LKUQ\\SQLEXPRESS;Initial Catalog=202503024;Integrated Security=True";
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public bool eskisifrekontrol()
        {
            string sorgu =  "select sifre from tbl_login where danisman_ad=@user1 and danisman_sifre=@pass1 or musteri_ad=@user2 and musteri_sifre=@pass2";


            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user1", "@user2");
            cmd.Parameters.AddWithValue("@pass1", "@pass2");

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

            }
            else
            {
                label5.Text = "Eski Şifre Hatalı.. ";
            }

            con.Close();




            return true;
        }

        private void şifre_değiştir_Load(object sender, EventArgs e)
        {
           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
