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
    public partial class location_timetable : UserControl
    {
        string connectionString = @"Data Source=LAPTOP-V4C47V9L;Initial Catalog=ITP_SLIIT;Integrated Security=True;";

        public location_timetable()
        {
            InitializeComponent();
        }

        private void location_timetable_Load(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT  * from ( SELECT Date,Start_Time ,concat(Lecture_name,',',Subject_Name,',',Subject_Code,',',Room_Name) as con FROM tbl_session_data pp ) d PIVOT ( max(con)  FOR Date IN ([Monday], [Tuesday],[Wednesday],[Thursday],[Friday],[Saturday],[Sunday]) ) as p   ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _dt_timetable_data.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void btn_location_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  * FROM ( SELECT Date,Start_Time ,concat(Lecture_name,',',Subject_Name,',',Subject_Code,',',Room_Name) as con FROM tbl_session_data pp where pp.Room_Name = '" + txt_timetable_location.Text + "') d PIVOT ( max(con) FOR Date IN ([Monday], [Tuesday],[Wednesday],[Thursday],[Friday],[Saturday],[Sunday]) ) as p ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _dt_timetable_data.DataSource = dt;
                sqlcon.Close();

            }
        }
    }
}
