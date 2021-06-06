using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIIT_ITPM
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-V4C47V9L;Initial Catalog=ITP_SLIIT;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             student1.Hide();
            subject1.Hide();
            location1.Hide();
             disp_data();
            session1.Hide();
            timetable1.Hide();
            static1.Hide();
        }

        private void student1_Load(object sender, EventArgs e)
        {

        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            student1.Show();
            subject1.Hide();
            location1.Hide();
            session1.Hide();
            timetable1.Hide();
            static1.Hide();
        }

        private void btn_lecture_Click(object sender, EventArgs e)
        {
            student1.Hide();
            subject1.Hide();
            location1.Hide();
            session1.Hide();
            timetable1.Hide();
            static1.Hide();
        }

        private void btn_lec_search_Click(object sender, EventArgs e)
        {
            if (rd_btn_id.Checked)
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Lecture_id,Lecture_name,Faculty,Department,Center,[level],Rank from  Lecture where Lecture_id ='" + txt_lec_search.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dt_lecture_data.DataSource = dt;           
                    sqlcon.Close();
                }
            }
            else if (rd_btn_name.Checked)
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Lecture_id,Lecture_name,Faculty,Department,Center,[level],Rank from  Lecture where Lecture_name ='" + txt_lec_search.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dt_lecture_data.DataSource = dt;
                    sqlcon.Close();
                }
            }
            else if (txt_lec_search.Text == "" && rd_btn_id.Checked || rd_btn_name.Checked)
            {
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
                cmd.CommandText = "select Lecture_id,Lecture_name,Faculty,Department,Center,[level],Rank from Lecture";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_lecture_data.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_rank.Text == "")
            {
                MessageBox.Show("Please Genarate Rank..!!!!");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("Lecture_data_add", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@Lecture_id", txt_lec_id.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Lecture_name", txt_lec_name.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Faculty", txt_faculty.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Department", txt_department.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Center", txt_center.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@level", txt_level.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Rank", txt_rank.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added....!!!");
                    txt_lec_name.Text = "";
                    txt_lec_id.Text = "";
                    txt_faculty.Text = "";
                    txt_department.Text = "";
                    txt_center.Text = "";
                    txt_level.Text = "";
                    txt_rank.Text = "";
                    disp_data();

                }

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (rd_btn_id.Checked)
            {
                using (System.Data.SqlClient.SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Lecture set Lecture_id = '" + txt_lec_id.Text
                        + "',Lecture_name = '" + txt_lec_name.Text + "',Faculty = '" + txt_faculty.Text + "',Department = '"
                        + txt_department.Text + "' , Center = '" + txt_center.Text + "', [level] = '" + txt_level.Text
                        + "', Rank = '" + txt_rank.Text + "'where Lecture_id = '" + txt_lec_search.Text + "'";
                    cmd.ExecuteNonQuery();
                    disp_data();
                    sqlcon.Close();
                    MessageBox.Show("Record update successfully..!!");
                    txt_lec_name.Text = "";
                    txt_lec_id.Text = "";
                    txt_faculty.Text = "";
                    txt_department.Text = "";
                    txt_center.Text = "";
                    txt_level.Text = "";
                    txt_rank.Text = "";
                    disp_data();

                }
            }
            else if (rd_btn_name.Checked)
            {
                using (System.Data.SqlClient.SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Lecture set Lecture_id = '" + txt_lec_id.Text
                        + "',Lecture_name = '" + txt_lec_name.Text + "',Faculty = '" + txt_faculty.Text + "',Department = '"
                        + txt_department.Text + "' , Center = '" + txt_center.Text + "', [level] = '" + txt_level.Text
                        + "', Rank = '" + txt_rank.Text + "'where Lecture_name = '" + txt_lec_search.Text + "'";
                    cmd.ExecuteNonQuery();
                    disp_data();
                    sqlcon.Close();
                    MessageBox.Show("Record update successfully..!!");
                    txt_lec_name.Text = "";
                    txt_lec_id.Text = "";
                    txt_faculty.Text = "";
                    txt_department.Text = "";
                    txt_center.Text = "";
                    txt_level.Text = "";
                    txt_rank.Text = "";
                    disp_data();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from  Lecture where Lecture_id ='" + txt_lec_search.Text + "' or Lecture_name ='" + txt_lec_search.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                disp_data();

                MessageBox.Show("record deleted successfully...!!!");

            }
        }

        
        private void btn_rank_Click(object sender, EventArgs e)
        {
            String _id = txt_lec_id.Text;
            String _level = txt_level.Text;

            txt_rank.Text = _id + _level;
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            subject1.Show();
            location1.Hide();
            session1.Hide();
            timetable1.Hide();
            static1.Hide();

        }

        private void subject1_Load(object sender, EventArgs e)
        {

        }

        private void btn_location_Click(object sender, EventArgs e)
        {
            location1.Show();
            session1.Hide();
            subject1.Hide();
            timetable1.Hide();
            static1.Hide();
        }

        private void btn_session_Click(object sender, EventArgs e)
        {
            session1.Show();
            subject1.Hide();
            location1.Hide();
            student1.Hide();
            timetable1.Hide();
            static1.Hide();
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
            session1.Hide();
            subject1.Hide();
            location1.Hide();
            student1.Hide();
            timetable1.Show();
            static1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_static_Click(object sender, EventArgs e)
        {
            session1.Hide();
            subject1.Hide();
            location1.Hide();
            student1.Hide();
            timetable1.Hide();
            static1.Show();
        }
    }

}

