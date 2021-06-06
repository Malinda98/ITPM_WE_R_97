namespace SLIIT_ITPM
{
    partial class Subject
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
            this.txt_sub_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dt_sub_data = new System.Windows.Forms.DataGridView();
            this.txt_sub_subject_name = new System.Windows.Forms.TextBox();
            this.txt_sub_subject_code = new System.Windows.Forms.TextBox();
            this.txt_sub_offered_year = new System.Windows.Forms.TextBox();
            this.txt_sub_offered_semester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sub_add = new System.Windows.Forms.Button();
            this.btn_sub_update = new System.Windows.Forms.Button();
            this.btn_sub_delete = new System.Windows.Forms.Button();
            this.rd_btn_code = new System.Windows.Forms.RadioButton();
            this.rd_btn_name = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sub_data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sub_search
            // 
            this.txt_sub_search.Location = new System.Drawing.Point(287, 87);
            this.txt_sub_search.Name = "txt_sub_search";
            this.txt_sub_search.Size = new System.Drawing.Size(181, 22);
            this.txt_sub_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(734, 87);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dt_sub_data
            // 
            this.dt_sub_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_sub_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_sub_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_sub_data.Location = new System.Drawing.Point(216, 142);
            this.dt_sub_data.Name = "dt_sub_data";
            this.dt_sub_data.RowTemplate.Height = 24;
            this.dt_sub_data.Size = new System.Drawing.Size(593, 241);
            this.dt_sub_data.TabIndex = 2;
            // 
            // txt_sub_subject_name
            // 
            this.txt_sub_subject_name.Location = new System.Drawing.Point(287, 418);
            this.txt_sub_subject_name.Name = "txt_sub_subject_name";
            this.txt_sub_subject_name.Size = new System.Drawing.Size(181, 22);
            this.txt_sub_subject_name.TabIndex = 3;
            // 
            // txt_sub_subject_code
            // 
            this.txt_sub_subject_code.Location = new System.Drawing.Point(287, 483);
            this.txt_sub_subject_code.Name = "txt_sub_subject_code";
            this.txt_sub_subject_code.Size = new System.Drawing.Size(181, 22);
            this.txt_sub_subject_code.TabIndex = 4;
            // 
            // txt_sub_offered_year
            // 
            this.txt_sub_offered_year.Location = new System.Drawing.Point(612, 420);
            this.txt_sub_offered_year.Name = "txt_sub_offered_year";
            this.txt_sub_offered_year.Size = new System.Drawing.Size(181, 22);
            this.txt_sub_offered_year.TabIndex = 5;
            // 
            // txt_sub_offered_semester
            // 
            this.txt_sub_offered_semester.Location = new System.Drawing.Point(612, 481);
            this.txt_sub_offered_semester.Name = "txt_sub_offered_semester";
            this.txt_sub_offered_semester.Size = new System.Drawing.Size(181, 22);
            this.txt_sub_offered_semester.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subject Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Offered Year :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Offered Semester :";
            // 
            // btn_sub_add
            // 
            this.btn_sub_add.Location = new System.Drawing.Point(367, 555);
            this.btn_sub_add.Name = "btn_sub_add";
            this.btn_sub_add.Size = new System.Drawing.Size(75, 23);
            this.btn_sub_add.TabIndex = 11;
            this.btn_sub_add.Text = "Add";
            this.btn_sub_add.UseVisualStyleBackColor = true;
            this.btn_sub_add.Click += new System.EventHandler(this.btn_sub_add_Click);
            // 
            // btn_sub_update
            // 
            this.btn_sub_update.Location = new System.Drawing.Point(502, 555);
            this.btn_sub_update.Name = "btn_sub_update";
            this.btn_sub_update.Size = new System.Drawing.Size(75, 23);
            this.btn_sub_update.TabIndex = 12;
            this.btn_sub_update.Text = "Update";
            this.btn_sub_update.UseVisualStyleBackColor = true;
            this.btn_sub_update.Click += new System.EventHandler(this.btn_sub_update_Click);
            // 
            // btn_sub_delete
            // 
            this.btn_sub_delete.Location = new System.Drawing.Point(629, 555);
            this.btn_sub_delete.Name = "btn_sub_delete";
            this.btn_sub_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_sub_delete.TabIndex = 13;
            this.btn_sub_delete.Text = "Delete";
            this.btn_sub_delete.UseVisualStyleBackColor = true;
            this.btn_sub_delete.Click += new System.EventHandler(this.btn_sub_delete_Click);
            // 
            // rd_btn_code
            // 
            this.rd_btn_code.AutoSize = true;
            this.rd_btn_code.Location = new System.Drawing.Point(496, 87);
            this.rd_btn_code.Name = "rd_btn_code";
            this.rd_btn_code.Size = new System.Drawing.Size(113, 21);
            this.rd_btn_code.TabIndex = 14;
            this.rd_btn_code.TabStop = true;
            this.rd_btn_code.Text = "Subject Code";
            this.rd_btn_code.UseVisualStyleBackColor = true;
            // 
            // rd_btn_name
            // 
            this.rd_btn_name.AutoSize = true;
            this.rd_btn_name.Location = new System.Drawing.Point(612, 89);
            this.rd_btn_name.Name = "rd_btn_name";
            this.rd_btn_name.Size = new System.Drawing.Size(117, 21);
            this.rd_btn_name.TabIndex = 15;
            this.rd_btn_name.TabStop = true;
            this.rd_btn_name.Text = "Subject Name";
            this.rd_btn_name.UseVisualStyleBackColor = true;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rd_btn_name);
            this.Controls.Add(this.rd_btn_code);
            this.Controls.Add(this.btn_sub_delete);
            this.Controls.Add(this.btn_sub_update);
            this.Controls.Add(this.btn_sub_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sub_offered_semester);
            this.Controls.Add(this.txt_sub_offered_year);
            this.Controls.Add(this.txt_sub_subject_code);
            this.Controls.Add(this.txt_sub_subject_name);
            this.Controls.Add(this.dt_sub_data);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_sub_search);
            this.Name = "Subject";
            this.Size = new System.Drawing.Size(1046, 642);
            this.Load += new System.EventHandler(this.Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_sub_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sub_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dt_sub_data;
        private System.Windows.Forms.TextBox txt_sub_subject_name;
        private System.Windows.Forms.TextBox txt_sub_subject_code;
        private System.Windows.Forms.TextBox txt_sub_offered_year;
        private System.Windows.Forms.TextBox txt_sub_offered_semester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sub_add;
        private System.Windows.Forms.Button btn_sub_update;
        private System.Windows.Forms.Button btn_sub_delete;
        private System.Windows.Forms.RadioButton rd_btn_code;
        private System.Windows.Forms.RadioButton rd_btn_name;
    }
}
