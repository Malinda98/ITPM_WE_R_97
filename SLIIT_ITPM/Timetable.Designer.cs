namespace SLIIT_ITPM
{
    partial class Timetable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_timetable_Lecture = new System.Windows.Forms.Button();
            this.btn_timetable_Group = new System.Windows.Forms.Button();
            this.btn_timetable_Room = new System.Windows.Forms.Button();
            this.txt_lec_name = new System.Windows.Forms.TextBox();
            this.btn_lec_search = new System.Windows.Forms.Button();
            this.dt_lecture_data = new System.Windows.Forms.DataGridView();
            this.panel_timetable = new System.Windows.Forms.Panel();
            this.groups1 = new SLIIT_ITPM.Groups();
            this.location_timetable1 = new SLIIT_ITPM.location_timetable();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lecture_data)).BeginInit();
            this.panel_timetable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_timetable_Lecture
            // 
            this.btn_timetable_Lecture.Location = new System.Drawing.Point(382, 35);
            this.btn_timetable_Lecture.Name = "btn_timetable_Lecture";
            this.btn_timetable_Lecture.Size = new System.Drawing.Size(75, 23);
            this.btn_timetable_Lecture.TabIndex = 1;
            this.btn_timetable_Lecture.Text = "Lecture";
            this.btn_timetable_Lecture.UseVisualStyleBackColor = true;
            this.btn_timetable_Lecture.Click += new System.EventHandler(this.btn_timetable_Lecture_Click);
            // 
            // btn_timetable_Group
            // 
            this.btn_timetable_Group.Location = new System.Drawing.Point(476, 35);
            this.btn_timetable_Group.Name = "btn_timetable_Group";
            this.btn_timetable_Group.Size = new System.Drawing.Size(75, 23);
            this.btn_timetable_Group.TabIndex = 2;
            this.btn_timetable_Group.Text = "Group";
            this.btn_timetable_Group.UseVisualStyleBackColor = true;
            this.btn_timetable_Group.Click += new System.EventHandler(this.btn_timetable_Group_Click);
            // 
            // btn_timetable_Room
            // 
            this.btn_timetable_Room.Location = new System.Drawing.Point(567, 35);
            this.btn_timetable_Room.Name = "btn_timetable_Room";
            this.btn_timetable_Room.Size = new System.Drawing.Size(75, 23);
            this.btn_timetable_Room.TabIndex = 3;
            this.btn_timetable_Room.Text = "Room";
            this.btn_timetable_Room.UseVisualStyleBackColor = true;
            this.btn_timetable_Room.Click += new System.EventHandler(this.btn_timetable_Room_Click);
            // 
            // txt_lec_name
            // 
            this.txt_lec_name.Location = new System.Drawing.Point(690, 39);
            this.txt_lec_name.Name = "txt_lec_name";
            this.txt_lec_name.Size = new System.Drawing.Size(185, 22);
            this.txt_lec_name.TabIndex = 2;
            // 
            // btn_lec_search
            // 
            this.btn_lec_search.Location = new System.Drawing.Point(891, 39);
            this.btn_lec_search.Name = "btn_lec_search";
            this.btn_lec_search.Size = new System.Drawing.Size(75, 23);
            this.btn_lec_search.TabIndex = 3;
            this.btn_lec_search.Text = "Search";
            this.btn_lec_search.UseVisualStyleBackColor = true;
            this.btn_lec_search.Click += new System.EventHandler(this.btn_lec_search_Click);
            // 
            // dt_lecture_data
            // 
            this.dt_lecture_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_lecture_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_lecture_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_lecture_data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_lecture_data.Location = new System.Drawing.Point(76, 89);
            this.dt_lecture_data.Name = "dt_lecture_data";
            this.dt_lecture_data.RowTemplate.Height = 24;
            this.dt_lecture_data.Size = new System.Drawing.Size(859, 377);
            this.dt_lecture_data.TabIndex = 9;
            // 
            // panel_timetable
            // 
            this.panel_timetable.Controls.Add(this.location_timetable1);
            this.panel_timetable.Controls.Add(this.groups1);
            this.panel_timetable.Controls.Add(this.dt_lecture_data);
            this.panel_timetable.Controls.Add(this.btn_lec_search);
            this.panel_timetable.Controls.Add(this.txt_lec_name);
            this.panel_timetable.Location = new System.Drawing.Point(0, 64);
            this.panel_timetable.Name = "panel_timetable";
            this.panel_timetable.Size = new System.Drawing.Size(1043, 575);
            this.panel_timetable.TabIndex = 4;
            // 
            // groups1
            // 
            this.groups1.Location = new System.Drawing.Point(0, 3);
            this.groups1.Name = "groups1";
            this.groups1.Size = new System.Drawing.Size(1046, 575);
            this.groups1.TabIndex = 10;
            // 
            // location_timetable1
            // 
            this.location_timetable1.Location = new System.Drawing.Point(0, 0);
            this.location_timetable1.Name = "location_timetable1";
            this.location_timetable1.Size = new System.Drawing.Size(1046, 578);
            this.location_timetable1.TabIndex = 11;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_timetable);
            this.Controls.Add(this.btn_timetable_Room);
            this.Controls.Add(this.btn_timetable_Group);
            this.Controls.Add(this.btn_timetable_Lecture);
            this.Name = "Timetable";
            this.Size = new System.Drawing.Size(1046, 642);
            this.Load += new System.EventHandler(this.Timetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_lecture_data)).EndInit();
            this.panel_timetable.ResumeLayout(false);
            this.panel_timetable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_timetable_Lecture;
        private System.Windows.Forms.Button btn_timetable_Group;
        private System.Windows.Forms.Button btn_timetable_Room;
        private System.Windows.Forms.TextBox txt_lec_name;
        private System.Windows.Forms.Button btn_lec_search;
        private System.Windows.Forms.DataGridView dt_lecture_data;
        private System.Windows.Forms.Panel panel_timetable;
        private location_timetable location_timetable1;
        private Groups groups1;
    }
}
