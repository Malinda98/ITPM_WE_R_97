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
    public partial class Student : UserControl
    {



        string connectionString = @"Data Source=LAPTOP-V4C47V9L;Initial Catalog=ITP_SLIIT;Integrated Security=True;";
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btn_stud_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Academic_year,Programe,Group_number,Sub_Group_number,Group_ID,[Sub_Group_ID] from  Student where Academic_year ='" + txt_search_academic_year.Text + "' or Programe = '"+txt_search_programe+ "' or Group_number = '"+txt_search_group_number+ "' or Sub_Group_number = '"+txt_search_sub_group_number+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_stud_data.DataSource = dt;
                sqlcon.Close();
            }
        }

        public void disp_data()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Academic_year,Programe,Group_number,Sub_Group_number,Group_ID,[Sub_Group_ID] from Student";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_stud_data.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void btn_stud_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Student_add", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Academic_year", txt_stud_academic_year.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Programe", txt_stud_programe.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Group_number", txt_stud_group_no.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Sub_Group_number", txt_stud_sub_group_no.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Group_ID", txt_stud_group_id.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Sub_Group_ID", txt_stud_sub_group_id.Text.Trim());           
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added....!!!");
                txt_stud_academic_year.Text = "";
                txt_stud_programe.Text = "";
                txt_stud_group_no.Text = "";
                txt_stud_sub_group_no.Text = "";
                txt_stud_group_id.Text = "";
                txt_stud_sub_group_id.Text = "";
                disp_data();
            }
        }

        private void btn_stud_update_Click(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  Student set Academic_year = '" + txt_stud_academic_year.Text
                    + "',Programe = '" + txt_stud_programe.Text + "',Group_number = '" + txt_stud_group_no.Text + "',Sub_Group_number = '"
                    + txt_stud_sub_group_no.Text + "' , Group_ID = '" + txt_stud_group_id.Text + "', [Sub_Group_ID] = '" + txt_stud_sub_group_id.Text
                    + "' where Academic_year = '" + txt_search_academic_year.Text + "' or Programe = '"+txt_search_programe.Text+ "' or Group_number = '"+txt_search_group_number+ "' or Sub_Group_number = '"+txt_search_sub_group_number.Text+"'";
                cmd.ExecuteNonQuery();
                disp_data();
                sqlcon.Close();
                MessageBox.Show("Record update successfully..!!");
                txt_stud_academic_year.Text = "";
                txt_stud_programe.Text = "";
                txt_stud_group_no.Text = "";
                txt_stud_sub_group_no.Text = "";
                txt_stud_group_id.Text = "";
                txt_stud_sub_group_id.Text = "";
                disp_data();

            }
        }

        private void btn_stud_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from  Student where Academic_year = '" + txt_search_academic_year.Text + "' or Programe = '" + txt_search_programe.Text + "' or Group_number = '" + txt_search_group_number + "' or Sub_Group_number = '" + txt_search_sub_group_number.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                disp_data();

                MessageBox.Show("record deleted successfully...!!!");

            }
        }
    }
}
