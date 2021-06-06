namespace SLIIT_ITPM
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_timetable = new System.Windows.Forms.Button();
            this.btn_session = new System.Windows.Forms.Button();
            this.btn_location = new System.Windows.Forms.Button();
            this.btn_subject = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.btn_lecture = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iTP_SLIITDataSet = new SLIIT_ITPM.ITP_SLIITDataSet();
            this.iTPSLIITDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.timetable1 = new SLIIT_ITPM.Timetable();
            this.session1 = new SLIIT_ITPM.Session();
            this.location1 = new SLIIT_ITPM.Location();
            this.subject1 = new SLIIT_ITPM.Subject();
            this.student1 = new SLIIT_ITPM.Student();
            this.btn_rank = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_rank = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_level = new System.Windows.Forms.TextBox();
            this.txt_center = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_faculty = new System.Windows.Forms.TextBox();
            this.txt_lec_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lec_id = new System.Windows.Forms.TextBox();
            this.dt_lecture_data = new System.Windows.Forms.DataGridView();
            this.btn_lec_search = new System.Windows.Forms.Button();
            this.rd_btn_name = new System.Windows.Forms.RadioButton();
            this.rd_btn_id = new System.Windows.Forms.RadioButton();
            this.txt_lec_search = new System.Windows.Forms.TextBox();
            this.static1 = new SLIIT_ITPM.Static();
            this.btn_static = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTP_SLIITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPSLIITDataSetBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lecture_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btn_static);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_timetable);
            this.panel1.Controls.Add(this.btn_session);
            this.panel1.Controls.Add(this.btn_location);
            this.panel1.Controls.Add(this.btn_subject);
            this.panel1.Controls.Add(this.btn_student);
            this.panel1.Controls.Add(this.panel_container);
            this.panel1.Controls.Add(this.btn_lecture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 607);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 81);
            this.panel4.TabIndex = 8;
            // 
            // btn_timetable
            // 
            this.btn_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timetable.Location = new System.Drawing.Point(19, 458);
            this.btn_timetable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_timetable.Name = "btn_timetable";
            this.btn_timetable.Size = new System.Drawing.Size(131, 46);
            this.btn_timetable.TabIndex = 7;
            this.btn_timetable.Text = "Time Table";
            this.btn_timetable.UseVisualStyleBackColor = true;
            this.btn_timetable.Click += new System.EventHandler(this.btn_timetable_Click);
            // 
            // btn_session
            // 
            this.btn_session.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_session.Location = new System.Drawing.Point(19, 400);
            this.btn_session.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_session.Name = "btn_session";
            this.btn_session.Size = new System.Drawing.Size(131, 46);
            this.btn_session.TabIndex = 6;
            this.btn_session.Text = "Session";
            this.btn_session.UseVisualStyleBackColor = true;
            this.btn_session.Click += new System.EventHandler(this.btn_session_Click);
            // 
            // btn_location
            // 
            this.btn_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_location.Location = new System.Drawing.Point(19, 338);
            this.btn_location.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_location.Name = "btn_location";
            this.btn_location.Size = new System.Drawing.Size(131, 46);
            this.btn_location.TabIndex = 5;
            this.btn_location.Text = "Location";
            this.btn_location.UseVisualStyleBackColor = true;
            this.btn_location.Click += new System.EventHandler(this.btn_location_Click);
            // 
            // btn_subject
            // 
            this.btn_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subject.Location = new System.Drawing.Point(19, 274);
            this.btn_subject.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_subject.Name = "btn_subject";
            this.btn_subject.Size = new System.Drawing.Size(131, 46);
            this.btn_subject.TabIndex = 4;
            this.btn_subject.Text = "Subject";
            this.btn_subject.UseVisualStyleBackColor = true;
            this.btn_subject.Click += new System.EventHandler(this.btn_subject_Click);
            // 
            // btn_student
            // 
            this.btn_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.Location = new System.Drawing.Point(19, 215);
            this.btn_student.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(131, 46);
            this.btn_student.TabIndex = 3;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // panel_container
            // 
            this.panel_container.Location = new System.Drawing.Point(175, 81);
            this.panel_container.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(787, 513);
            this.panel_container.TabIndex = 2;
            // 
            // btn_lecture
            // 
            this.btn_lecture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_lecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lecture.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_lecture.Location = new System.Drawing.Point(19, 156);
            this.btn_lecture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_lecture.Name = "btn_lecture";
            this.btn_lecture.Size = new System.Drawing.Size(131, 46);
            this.btn_lecture.TabIndex = 0;
            this.btn_lecture.Text = "Lecture";
            this.btn_lecture.UseVisualStyleBackColor = false;
            this.btn_lecture.Click += new System.EventHandler(this.btn_lecture_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 81);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // iTP_SLIITDataSet
            // 
            this.iTP_SLIITDataSet.DataSetName = "ITP_SLIITDataSet";
            this.iTP_SLIITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTPSLIITDataSetBindingSource
            // 
            this.iTPSLIITDataSetBindingSource.DataSource = this.iTP_SLIITDataSet;
            this.iTPSLIITDataSetBindingSource.Position = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.static1);
            this.panel3.Controls.Add(this.timetable1);
            this.panel3.Controls.Add(this.session1);
            this.panel3.Controls.Add(this.location1);
            this.panel3.Controls.Add(this.subject1);
            this.panel3.Controls.Add(this.student1);
            this.panel3.Controls.Add(this.btn_rank);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_rank);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.txt_level);
            this.panel3.Controls.Add(this.txt_center);
            this.panel3.Controls.Add(this.txt_department);
            this.panel3.Controls.Add(this.txt_faculty);
            this.panel3.Controls.Add(this.txt_lec_name);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_lec_id);
            this.panel3.Controls.Add(this.dt_lecture_data);
            this.panel3.Controls.Add(this.btn_lec_search);
            this.panel3.Controls.Add(this.rd_btn_name);
            this.panel3.Controls.Add(this.rd_btn_id);
            this.panel3.Controls.Add(this.txt_lec_search);
            this.panel3.Location = new System.Drawing.Point(176, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 517);
            this.panel3.TabIndex = 2;
            // 
            // timetable1
            // 
            this.timetable1.Location = new System.Drawing.Point(-2, -4);
            this.timetable1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.timetable1.Name = "timetable1";
            this.timetable1.Size = new System.Drawing.Size(785, 521);
            this.timetable1.TabIndex = 27;
            // 
            // session1
            // 
            this.session1.Location = new System.Drawing.Point(0, 0);
            this.session1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.session1.Name = "session1";
            this.session1.Size = new System.Drawing.Size(785, 521);
            this.session1.TabIndex = 26;
            // 
            // location1
            // 
            this.location1.AutoSize = true;
            this.location1.Location = new System.Drawing.Point(0, 0);
            this.location1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.location1.Name = "location1";
            this.location1.Size = new System.Drawing.Size(835, 521);
            this.location1.TabIndex = 25;
            // 
            // subject1
            // 
            this.subject1.Location = new System.Drawing.Point(0, 0);
            this.subject1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(785, 521);
            this.subject1.TabIndex = 24;
            this.subject1.Load += new System.EventHandler(this.subject1_Load);
            // 
            // student1
            // 
            this.student1.Location = new System.Drawing.Point(0, 0);
            this.student1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(785, 521);
            this.student1.TabIndex = 23;
            // 
            // btn_rank
            // 
            this.btn_rank.Location = new System.Drawing.Point(676, 338);
            this.btn_rank.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_rank.Name = "btn_rank";
            this.btn_rank.Size = new System.Drawing.Size(56, 19);
            this.btn_rank.TabIndex = 22;
            this.btn_rank.Text = "Genarate";
            this.btn_rank.UseVisualStyleBackColor = true;
            this.btn_rank.Click += new System.EventHandler(this.btn_rank_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Rank :";
            // 
            // txt_rank
            // 
            this.txt_rank.Location = new System.Drawing.Point(676, 311);
            this.txt_rank.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_rank.Name = "txt_rank";
            this.txt_rank.Size = new System.Drawing.Size(76, 20);
            this.txt_rank.TabIndex = 20;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(437, 442);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 19);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete Lecture";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(325, 442);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 19);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update Lecture";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(223, 442);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 19);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add Lecture";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(414, 370);
            this.txt_level.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(193, 20);
            this.txt_level.TabIndex = 16;
            // 
            // txt_center
            // 
            this.txt_center.Location = new System.Drawing.Point(414, 339);
            this.txt_center.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_center.Name = "txt_center";
            this.txt_center.Size = new System.Drawing.Size(193, 20);
            this.txt_center.TabIndex = 15;
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(414, 311);
            this.txt_department.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(193, 20);
            this.txt_department.TabIndex = 14;
            // 
            // txt_faculty
            // 
            this.txt_faculty.Location = new System.Drawing.Point(129, 373);
            this.txt_faculty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_faculty.Name = "txt_faculty";
            this.txt_faculty.Size = new System.Drawing.Size(193, 20);
            this.txt_faculty.TabIndex = 13;
            // 
            // txt_lec_name
            // 
            this.txt_lec_name.Location = new System.Drawing.Point(129, 339);
            this.txt_lec_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_lec_name.Name = "txt_lec_name";
            this.txt_lec_name.Size = new System.Drawing.Size(193, 20);
            this.txt_lec_name.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Level :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 339);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Center :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Department :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Faculty :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lecture Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lecture ID :";
            // 
            // txt_lec_id
            // 
            this.txt_lec_id.Location = new System.Drawing.Point(129, 311);
            this.txt_lec_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_lec_id.Name = "txt_lec_id";
            this.txt_lec_id.Size = new System.Drawing.Size(193, 20);
            this.txt_lec_id.TabIndex = 5;
            // 
            // dt_lecture_data
            // 
            this.dt_lecture_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_lecture_data.Location = new System.Drawing.Point(5, 64);
            this.dt_lecture_data.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dt_lecture_data.Name = "dt_lecture_data";
            this.dt_lecture_data.RowTemplate.Height = 24;
            this.dt_lecture_data.Size = new System.Drawing.Size(771, 224);
            this.dt_lecture_data.TabIndex = 4;
            // 
            // btn_lec_search
            // 
            this.btn_lec_search.Location = new System.Drawing.Point(697, 25);
            this.btn_lec_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_lec_search.Name = "btn_lec_search";
            this.btn_lec_search.Size = new System.Drawing.Size(56, 19);
            this.btn_lec_search.TabIndex = 3;
            this.btn_lec_search.Text = "Search";
            this.btn_lec_search.UseVisualStyleBackColor = true;
            this.btn_lec_search.Click += new System.EventHandler(this.btn_lec_search_Click);
            // 
            // rd_btn_name
            // 
            this.rd_btn_name.AutoSize = true;
            this.rd_btn_name.Location = new System.Drawing.Point(643, 26);
            this.rd_btn_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rd_btn_name.Name = "rd_btn_name";
            this.rd_btn_name.Size = new System.Drawing.Size(53, 17);
            this.rd_btn_name.TabIndex = 2;
            this.rd_btn_name.TabStop = true;
            this.rd_btn_name.Text = "Name";
            this.rd_btn_name.UseVisualStyleBackColor = true;
            // 
            // rd_btn_id
            // 
            this.rd_btn_id.AutoSize = true;
            this.rd_btn_id.Location = new System.Drawing.Point(607, 26);
            this.rd_btn_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rd_btn_id.Name = "rd_btn_id";
            this.rd_btn_id.Size = new System.Drawing.Size(36, 17);
            this.rd_btn_id.TabIndex = 1;
            this.rd_btn_id.TabStop = true;
            this.rd_btn_id.Text = "ID";
            this.rd_btn_id.UseVisualStyleBackColor = true;
            // 
            // txt_lec_search
            // 
            this.txt_lec_search.Location = new System.Drawing.Point(414, 25);
            this.txt_lec_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_lec_search.Name = "txt_lec_search";
            this.txt_lec_search.Size = new System.Drawing.Size(174, 20);
            this.txt_lec_search.TabIndex = 0;
            // 
            // static1
            // 
            this.static1.Location = new System.Drawing.Point(-1, -4);
            this.static1.Name = "static1";
            this.static1.Size = new System.Drawing.Size(784, 525);
            this.static1.TabIndex = 28;
            // 
            // btn_static
            // 
            this.btn_static.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_static.Location = new System.Drawing.Point(19, 512);
            this.btn_static.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_static.Name = "btn_static";
            this.btn_static.Size = new System.Drawing.Size(131, 46);
            this.btn_static.TabIndex = 9;
            this.btn_static.Text = "Statics";
            this.btn_static.UseVisualStyleBackColor = true;
            this.btn_static.Click += new System.EventHandler(this.btn_static_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 607);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iTP_SLIITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPSLIITDataSetBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lecture_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_lecture;
        private System.Windows.Forms.BindingSource iTPSLIITDataSetBindingSource;
        private ITP_SLIITDataSet iTP_SLIITDataSet;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dt_lecture_data;
        private System.Windows.Forms.Button btn_lec_search;
        private System.Windows.Forms.RadioButton rd_btn_name;
        private System.Windows.Forms.RadioButton rd_btn_id;
        private System.Windows.Forms.TextBox txt_lec_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_level;
        private System.Windows.Forms.TextBox txt_center;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_faculty;
        private System.Windows.Forms.TextBox txt_lec_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lec_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_rank;
        private System.Windows.Forms.Button btn_rank;
        private Student student1;
        private System.Windows.Forms.Button btn_subject;
        private Subject subject1;
        private System.Windows.Forms.Button btn_location;
        private Location location1;
        private System.Windows.Forms.Button btn_session;
        private Session session1;
        private System.Windows.Forms.Button btn_timetable;
        private Timetable timetable1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_static;
        private Static static1;
    }
}

