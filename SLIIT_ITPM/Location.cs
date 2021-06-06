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
    public partial class Location : UserControl
    {
        string connectionString = @"Data Source=LAPTOP-V4C47V9L;Initial Catalog=ITP_SLIIT;Integrated Security=True;";
        public Location()
        {
            InitializeComponent();
        }

        private void btn_add_location_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Location_data_add", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Building_name", txt_building_name.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Room_name", txt_room_name.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Room_type", txt_room_type.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Capacity", txt_capacity.Text.Trim());
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added....!!!");
                txt_building_name.Text = "";
                txt_room_name.Text = "";
                txt_room_type.Text = "";
                txt_capacity.Text = "";
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
                cmd.CommandText = "select Building_name,Room_name,Room_type,Capacity from Location_data";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dt_location_data.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void btn_update_location_Click(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  Location_data set Building_name = '" + txt_building_name.Text
                    + "',Room_name = '" + txt_room_name.Text + "',Room_type = '" + txt_room_type.Text + "',Capacity = '"
                    + txt_capacity.Text + "' where Building_name = '" + txt_location_search.Text + "' and Room_name = '" + txt_location_search.Text + "'";
                cmd.ExecuteNonQuery();
                disp_data();
                sqlcon.Close();
                MessageBox.Show("Record update successfully..!!");
                txt_building_name.Text = "";
                txt_room_name.Text = "";
                txt_room_type.Text = "";
                txt_capacity.Text = "";
                disp_data();

            }
        }

        private void btn_location_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from  Location_data where Building_name = '" + txt_location_search.Text + "' and Room_name = '" + txt_location_search.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                disp_data();

                MessageBox.Show("record deleted successfully...!!!");

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(txt_location_search.Text))
            {
                disp_data();
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select  Building_name,Room_name,Room_type,Capacity from  Location_data where Building_name ='" + txt_location_search.Text + "' or Room_name = '" + txt_location_search + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dt_location_data.DataSource = dt;
                    sqlcon.Close();
                }
            }
            
        }

        private void Location_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
