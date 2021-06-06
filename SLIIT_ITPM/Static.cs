using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace SLIIT_ITPM
{
    public partial class Static : UserControl
    {
        string connectionString = @"Data Source=LAPTOP-V4C47V9L;Initial Catalog=ITP_SLIIT;Integrated Security=True;";
        public Static()
        {
            InitializeComponent();
        }

        private void Static_Load(object sender, EventArgs e)
        {
            _disp_faculty_count();
            _disp_lectures_count();
            _disp_students_count();

        }

        public void _disp_students_count()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(Student.ID) as std_count from Student";
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_students.Text = dr["std_count"].ToString();

                }

            }
        }
        public void _disp_lectures_count()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(Lecture_id) as lect_count from Lecture";
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_lectures.Text = dr["lect_count"].ToString();

                }


            }
        }
        public void _disp_faculty_count()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(Location_data.Room_name) as room_count from Location_data";
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_faculty.Text = dr["room_count"].ToString();

                }


            }
        }
    }
}
