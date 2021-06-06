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
    public partial class Session : UserControl
    {
        string connectionString = @"Data Source=LAPTOP-V4C47V9L;Initial Catalog=ITP_SLIIT;Integrated Security=True;";
        String _tag;
        public Session()
        {
            InitializeComponent();
        }

        private void btn_session_add_Click(object sender, EventArgs e)
        {

            
            if (rd_session_lec.Checked)
            {
                _tag = "Lecture";
            }else if (rd_session_lab.Checked)
            {
                _tag = "Lab";
            }else if (rd_session_Tute.Checked)
            {
                _tag = "Tute";
            }
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("tbl_session_data_add", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Lecture_Name", txt_session_lecture_name.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Faculty", txt_session_faculty.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Building_Name", txt_session_building_name.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Room_Name", txt_session_room_name.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Room_Type", txt_session_room_type.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Academic_Year", txt_session_academic_year.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Academic_Semester", txt_session_academic_semester.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Group_No", txt_session_group_no.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Sub_Group_No", txt_session_sub_group_no.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Subject_Name", txt_session_subject_name.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Subject_Code", txt_session_subject_code.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Tag",_tag);
                sqlcmd.Parameters.AddWithValue("@Start_Time", txt_start.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@End_Time", txt_end.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Date", txt_session_date.Text.Trim());
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added....!!!");
                txt_session_lecture_name.Text = "";
                txt_session_faculty.Text = "";
                txt_session_building_name.Text = "";
                txt_session_room_name.Text = "";
                txt_session_room_type.Text = "";
                txt_session_academic_year.Text = "";
                txt_session_academic_semester.Text = "";
                txt_session_group_no.Text = "";
                txt_session_sub_group_no.Text = "";
                txt_session_subject_name.Text = "";
                txt_session_subject_code.Text = "";
                disp_data();

                var _Query = ("Select Lecture_Name from Lecture where Lecture_Name =");
                if(_Query == txt_session_lecture_name.Text )
                {
                    MessageBox.Show("Valid User");
                }
            }
        }

        private void Session_Load(object sender, EventArgs e)
        {
            disp_data();
            
        }
        public void disp_data()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Lecture_Name,Faculty,Building_Name,Room_Name,Room_Type,Academic_Year,Academic_Semester,Group_No,Sub_Group_No,Subject_Name,Subject_Code,Tag,Start_Time,End_Time,Date from tbl_session_data";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_seesion_data.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void rd_session_lec_CheckedChanged(object sender, EventArgs e)
        {
            Tag = "Lecture";
        }

        private void rd_session_Tute_CheckedChanged(object sender, EventArgs e)
        {
            Tag = "Tute";
        }

        private void rd_session_lab_CheckedChanged(object sender, EventArgs e)
        {
            Tag = "Lab";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btn_session_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from  tbl_session_data where Lecture_Name ='" + txt_session_search.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                disp_data();

                MessageBox.Show("record deleted successfully...!!!");

            }
        }

        private void btn_session_update_Click(object sender, EventArgs e)
        {
            if (rd_session_lec.Checked)
            {
                _tag = "Lecture";
            }
            else if (rd_session_lab.Checked)
            {
                _tag = "Lab";
            }
            else if (rd_session_Tute.Checked)
            {
                _tag = "Tute";
            }
            using (System.Data.SqlClient.SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  tbl_session_data set Lecture_Name = '" + txt_session_lecture_name.Text
                    + "',Faculty = '" + txt_session_faculty.Text + "', Building_Name = '"
                    + txt_session_building_name.Text + "' , Room_Name = '" + txt_session_room_name.Text + "', Room_Type = '" + txt_session_room_type.Text
                    + "', Academic_Year = '" + txt_session_academic_year.Text + "', Academic_Semester = '" + txt_session_academic_semester.Text
                    + "', Group_No = '" + txt_session_group_no.Text
                    + "', Sub_Group_No = '" + txt_session_sub_group_no.Text
                    + "', Subject_Name = '" + txt_session_subject_name.Text
                    + "', Subject_Code = '" + txt_session_subject_code.Text
                    + "', Tag = '" + _tag +
                    "', Start_Time = '" + txt_start.Text
                    + "', End_Time = '" + txt_end.Text
                    + "', Date = '" + txt_session_date.Text
                    + "' where Lecture_Name = '" + txt_session_lecture_name.Text + "'";
                cmd.ExecuteNonQuery();
                disp_data();
                sqlcon.Close();
                MessageBox.Show("Record update successfully..!!");
                txt_session_lecture_name.Text = "";
                txt_session_faculty.Text = "";
                txt_session_building_name.Text = "";
                txt_session_room_name.Text = "";
                txt_session_room_type.Text = "";
                txt_session_academic_year.Text = "";
                txt_session_academic_semester.Text = "";
                txt_session_group_no.Text = "";
                txt_session_sub_group_no.Text = "";
                txt_session_subject_name.Text = "";
                txt_session_subject_code.Text = "";

            }
        }

        public bool _validate()
        {

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Lecture where Lecture_Name = '" + txt_session_lecture_name.Text + "'";
                cmd.ExecuteNonQuery();
                return true;

            }

        }

        private void btn_session_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from tbl_session_data where Lecture_Name = '" + txt_session_lecture_name.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_seesion_data.DataSource = dt;
                sqlcon.Close();


            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
