namespace SLIIT_ITPM
{
    partial class Student
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
            this.txt_search_academic_year = new System.Windows.Forms.TextBox();
            this.btn_stud_search = new System.Windows.Forms.Button();
            this.dt_stud_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_stud_academic_year = new System.Windows.Forms.TextBox();
            this.txt_stud_programe = new System.Windows.Forms.TextBox();
            this.txt_stud_group_no = new System.Windows.Forms.TextBox();
            this.txt_stud_sub_group_id = new System.Windows.Forms.TextBox();
            this.txt_stud_sub_group_no = new System.Windows.Forms.TextBox();
            this.txt_stud_group_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_search_programe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_search_group_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_search_sub_group_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_stud_add = new System.Windows.Forms.Button();
            this.btn_stud_update = new System.Windows.Forms.Button();
            this.btn_stud_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_stud_data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search_academic_year
            // 
            this.txt_search_academic_year.Location = new System.Drawing.Point(240, 45);
            this.txt_search_academic_year.Name = "txt_search_academic_year";
            this.txt_search_academic_year.Size = new System.Drawing.Size(143, 22);
            this.txt_search_academic_year.TabIndex = 0;
            // 
            // btn_stud_search
            // 
            this.btn_stud_search.Location = new System.Drawing.Point(929, 43);
            this.btn_stud_search.Name = "btn_stud_search";
            this.btn_stud_search.Size = new System.Drawing.Size(76, 23);
            this.btn_stud_search.TabIndex = 1;
            this.btn_stud_search.Text = "Search";
            this.btn_stud_search.UseVisualStyleBackColor = true;
            this.btn_stud_search.Click += new System.EventHandler(this.btn_stud_search_Click);
            // 
            // dt_stud_data
            // 
            this.dt_stud_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_stud_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_stud_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_stud_data.Location = new System.Drawing.Point(78, 87);
            this.dt_stud_data.Name = "dt_stud_data";
            this.dt_stud_data.RowTemplate.Height = 24;
            this.dt_stud_data.Size = new System.Drawing.Size(927, 323);
            this.dt_stud_data.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Academic Year :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Programe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Group Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sub Group Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Group ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(688, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sub Group ID :";
            // 
            // txt_stud_academic_year
            // 
            this.txt_stud_academic_year.Location = new System.Drawing.Point(422, 435);
            this.txt_stud_academic_year.Name = "txt_stud_academic_year";
            this.txt_stud_academic_year.Size = new System.Drawing.Size(210, 22);
            this.txt_stud_academic_year.TabIndex = 9;
            // 
            // txt_stud_programe
            // 
            this.txt_stud_programe.Location = new System.Drawing.Point(422, 481);
            this.txt_stud_programe.Name = "txt_stud_programe";
            this.txt_stud_programe.Size = new System.Drawing.Size(210, 22);
            this.txt_stud_programe.TabIndex = 10;
            // 
            // txt_stud_group_no
            // 
            this.txt_stud_group_no.Location = new System.Drawing.Point(422, 526);
            this.txt_stud_group_no.Name = "txt_stud_group_no";
            this.txt_stud_group_no.Size = new System.Drawing.Size(210, 22);
            this.txt_stud_group_no.TabIndex = 11;
            // 
            // txt_stud_sub_group_id
            // 
            this.txt_stud_sub_group_id.Location = new System.Drawing.Point(795, 526);
            this.txt_stud_sub_group_id.Name = "txt_stud_sub_group_id";
            this.txt_stud_sub_group_id.Size = new System.Drawing.Size(210, 22);
            this.txt_stud_sub_group_id.TabIndex = 12;
            // 
            // txt_stud_sub_group_no
            // 
            this.txt_stud_sub_group_no.Location = new System.Drawing.Point(795, 435);
            this.txt_stud_sub_group_no.Name = "txt_stud_sub_group_no";
            this.txt_stud_sub_group_no.Size = new System.Drawing.Size(210, 22);
            this.txt_stud_sub_group_no.TabIndex = 12;
            // 
            // txt_stud_group_id
            // 
            this.txt_stud_group_id.Location = new System.Drawing.Point(795, 481);
            this.txt_stud_group_id.Name = "txt_stud_group_id";
            this.txt_stud_group_id.Size = new System.Drawing.Size(210, 22);
            this.txt_stud_group_id.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Year";
            // 
            // txt_search_programe
            // 
            this.txt_search_programe.Location = new System.Drawing.Point(399, 45);
            this.txt_search_programe.Name = "txt_search_programe";
            this.txt_search_programe.Size = new System.Drawing.Size(153, 22);
            this.txt_search_programe.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Programe";
            // 
            // txt_search_group_number
            // 
            this.txt_search_group_number.Location = new System.Drawing.Point(568, 44);
            this.txt_search_group_number.Name = "txt_search_group_number";
            this.txt_search_group_number.Size = new System.Drawing.Size(153, 22);
            this.txt_search_group_number.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Group Number";
            // 
            // txt_search_sub_group_number
            // 
            this.txt_search_sub_group_number.Location = new System.Drawing.Point(742, 45);
            this.txt_search_sub_group_number.Name = "txt_search_sub_group_number";
            this.txt_search_sub_group_number.Size = new System.Drawing.Size(153, 22);
            this.txt_search_sub_group_number.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sub Group Number ";
            // 
            // btn_stud_add
            // 
            this.btn_stud_add.Location = new System.Drawing.Point(508, 589);
            this.btn_stud_add.Name = "btn_stud_add";
            this.btn_stud_add.Size = new System.Drawing.Size(76, 23);
            this.btn_stud_add.TabIndex = 21;
            this.btn_stud_add.Text = "Add ";
            this.btn_stud_add.UseVisualStyleBackColor = true;
            this.btn_stud_add.Click += new System.EventHandler(this.btn_stud_add_Click);
            // 
            // btn_stud_update
            // 
            this.btn_stud_update.Location = new System.Drawing.Point(621, 589);
            this.btn_stud_update.Name = "btn_stud_update";
            this.btn_stud_update.Size = new System.Drawing.Size(76, 23);
            this.btn_stud_update.TabIndex = 22;
            this.btn_stud_update.Text = "Update";
            this.btn_stud_update.UseVisualStyleBackColor = true;
            this.btn_stud_update.Click += new System.EventHandler(this.btn_stud_update_Click);
            // 
            // btn_stud_delete
            // 
            this.btn_stud_delete.Location = new System.Drawing.Point(737, 589);
            this.btn_stud_delete.Name = "btn_stud_delete";
            this.btn_stud_delete.Size = new System.Drawing.Size(76, 23);
            this.btn_stud_delete.TabIndex = 23;
            this.btn_stud_delete.Text = "Delete";
            this.btn_stud_delete.UseVisualStyleBackColor = true;
            this.btn_stud_delete.Click += new System.EventHandler(this.btn_stud_delete_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_stud_delete);
            this.Controls.Add(this.btn_stud_update);
            this.Controls.Add(this.btn_stud_add);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_search_sub_group_number);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_search_group_number);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_search_programe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_stud_group_id);
            this.Controls.Add(this.txt_stud_sub_group_no);
            this.Controls.Add(this.txt_stud_sub_group_id);
            this.Controls.Add(this.txt_stud_group_no);
            this.Controls.Add(this.txt_stud_programe);
            this.Controls.Add(this.txt_stud_academic_year);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_stud_data);
            this.Controls.Add(this.btn_stud_search);
            this.Controls.Add(this.txt_search_academic_year);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(1046, 642);
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_stud_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search_academic_year;
        private System.Windows.Forms.Button btn_stud_search;
        private System.Windows.Forms.DataGridView dt_stud_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_stud_academic_year;
        private System.Windows.Forms.TextBox txt_stud_programe;
        private System.Windows.Forms.TextBox txt_stud_group_no;
        private System.Windows.Forms.TextBox txt_stud_sub_group_id;
        private System.Windows.Forms.TextBox txt_stud_sub_group_no;
        private System.Windows.Forms.TextBox txt_stud_group_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_search_programe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_search_group_number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_search_sub_group_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_stud_add;
        private System.Windows.Forms.Button btn_stud_update;
        private System.Windows.Forms.Button btn_stud_delete;
    }
}
