using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SLIIT_ITPM
{
    public partial class Subject : UserControl    
    {
        string connectionString = @"Data Source=LAPTOP-V4C47V9L;Initial Catalog=ITP_SLIIT;Integrated Security=True;";
        public Subject()
        {
            InitializeComponent();
        }

        private void btn_sub_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Subject_add", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Subject_name", txt_sub_subject_name.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Subject_code", txt_sub_subject_code.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Offered_year", txt_sub_offered_year.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Offered_semester", txt_sub_offered_semester.Text.Trim());
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added....!!!");
                txt_sub_subject_name.Text = "";
                txt_sub_subject_code.Text = "";
                txt_sub_offered_semester.Text = "";
                txt_sub_offered_year.Text = "";
                disp_data();
            }
        }

        public void disp_data()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Subject_name,Subject_code,Offered_year,Offered_semester from Subject";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_sub_data.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btn_sub_update_Click(object sender, EventArgs e)
        {
            if (rd_btn_code.Checked)
            {
                using (System.Data.SqlClient.SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Subject set Subject_name = '" + txt_sub_subject_name.Text
                        + "',Subject_code = '" + txt_sub_subject_code.Text + "',Offered_year = '" + txt_sub_offered_year.Text + "',Offered_semester = '"
                        + txt_sub_offered_semester.Text + "' where Subject_code = '" + txt_sub_search.Text + "'";
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Record update successfully..!!");
                    txt_sub_subject_name.Text = "";
                    txt_sub_subject_code.Text = "";
                    txt_sub_offered_semester.Text = "";
                    txt_sub_offered_year.Text = "";
                    disp_data();

                }
            }else if(rd_btn_name.Checked)
            {
                using (System.Data.SqlClient.SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Subject set Subject_name = '" + txt_sub_subject_name.Text
                        + "',Subject_code = '" + txt_sub_subject_code.Text + "',Offered_year = '" + txt_sub_offered_year.Text + "',Offered_semester = '"
                        + txt_sub_offered_semester.Text + "' where Subject_name = '" + txt_sub_search.Text + "'";
                    cmd.ExecuteNonQuery();
                    disp_data();
                    sqlcon.Close();
                    MessageBox.Show("Record update successfully..!!");
                    txt_sub_subject_name.Text = "";
                    txt_sub_subject_code.Text = "";
                    txt_sub_offered_semester.Text = "";
                    txt_sub_offered_year.Text = "";

                }
            }
            
        }

        private void btn_sub_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from  Subject where Subject_code ='" + txt_sub_search.Text + "' or Subject_name ='" + txt_sub_search.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                disp_data();

                MessageBox.Show("record deleted successfully...!!!");

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(rd_btn_name.Checked)
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Subject_name,Subject_code,Offered_year,Offered_semester from  Subject where Subject_name ='" + txt_sub_search.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dt_sub_data.DataSource = dt;
                    sqlcon.Close();
                }
            }else if(rd_btn_code.Checked)
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Subject_name,Subject_code,Offered_year,Offered_semester from  Subject where Subject_code ='" + txt_sub_search.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dt_sub_data.DataSource = dt;
                    sqlcon.Close();
                }
            }
        }
    }
}
