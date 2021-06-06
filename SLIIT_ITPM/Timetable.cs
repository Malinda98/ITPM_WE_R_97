using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Data.SqlClient;

namespace SLIIT_ITPM
{
    public partial class Timetable : UserControl
    {
        string connectionString = @"Data Source=LAPTOP-V4C47V9L;Initial Catalog=ITP_SLIIT;Integrated Security=True;";

        public Timetable()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           

        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            _display();
        }

        public void _display()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  * FROM ( SELECT Date,Start_Time ,concat(Lecture_name,',',Subject_Name,',',Subject_Code,',',Room_Name) as con FROM tbl_session_data pp ) d PIVOT ( max(con) FOR Date IN ([Monday], [Tuesday],[Wednesday],[Thursday],[Friday],[Saturday],[Sunday]) ) as p ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_lecture_data.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void btn_lec_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  * FROM ( SELECT Date,Start_Time ,concat(Lecture_name,',',Subject_Name,',',Subject_Code,',',Room_Name) as con FROM tbl_session_data pp where pp.Lecture_Name = '"+txt_lec_name.Text+"') d PIVOT ( max(con) FOR Date IN ([Monday], [Tuesday],[Wednesday],[Thursday],[Friday],[Saturday],[Sunday]) ) as p ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_lecture_data.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void btn_timetable_Group_Click(object sender, EventArgs e)
        {
            groups1.Show();
            location_timetable1.Hide();
        }

        private void btn_timetable_Lecture_Click(object sender, EventArgs e)
        {
            groups1.Hide();
            location_timetable1.Hide();
        }

        private void btn_timetable_Room_Click(object sender, EventArgs e)
        {
            location_timetable1.Show();
            groups1.Hide();
        }
    }
}
