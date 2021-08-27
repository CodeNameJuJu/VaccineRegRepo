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
using System.Configuration;

namespace Vaccine_Regestration
{
    public partial class Registration : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;

        private static string myConnString = ConfigurationManager.ConnectionStrings["ConnectStrng"].ConnectionString;
        SqlConnection cn = new SqlConnection(myConnString);
        
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cn.Open();
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * From [dbo].[Details] where [ID]='" + idtxt.Text + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
            }
            else
            {


                dr.Close();

                cmd = new SqlCommand("INSERT INTO [dbo].[Details] values(@ID, @Surname, @Firstname, @Gender, @Province)", cn);
                cmd.Parameters.AddWithValue("@ID", idtxt.Text);
                cmd.Parameters.AddWithValue("@Surname", surtxt.Text);
                cmd.Parameters.AddWithValue("@Firstname", firsttxt.Text);
                cmd.Parameters.AddWithValue("@Gender", genderCombo.SelectedItem);
                cmd.Parameters.AddWithValue("@Province", ProvinceCombo.SelectedItem);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thank you");

            }
        }
    }
}
