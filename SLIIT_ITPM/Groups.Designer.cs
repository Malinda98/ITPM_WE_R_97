namespace SLIIT_ITPM
{
    partial class Groups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dt_timetable_data = new System.Windows.Forms.DataGridView();
            this.btn_location_search = new System.Windows.Forms.Button();
            this.txt_timetable_group = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dt_timetable_data)).BeginInit();
            this.SuspendLayout();
            // 
            // _dt_timetable_data
            // 
            this._dt_timetable_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._dt_timetable_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._dt_timetable_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dt_timetable_data.DefaultCellStyle = dataGridViewCellStyle1;
            this._dt_timetable_data.Location = new System.Drawing.Point(76, 89);
            this._dt_timetable_data.Name = "_dt_timetable_data";
            this._dt_timetable_data.RowTemplate.Height = 24;
            this._dt_timetable_data.Size = new System.Drawing.Size(859, 377);
            this._dt_timetable_data.TabIndex = 8;
            // 
            // btn_location_search
            // 
            this.btn_location_search.Location = new System.Drawing.Point(891, 39);
            this.btn_location_search.Name = "btn_location_search";
            this.btn_location_search.Size = new System.Drawing.Size(75, 23);
            this.btn_location_search.TabIndex = 9;
            this.btn_location_search.Text = "Search";
            this.btn_location_search.UseVisualStyleBackColor = true;
            this.btn_location_search.Click += new System.EventHandler(this.btn_location_search_Click);
            // 
            // txt_timetable_group
            // 
            this.txt_timetable_group.Location = new System.Drawing.Point(690, 39);
            this.txt_timetable_group.Name = "txt_timetable_group";
            this.txt_timetable_group.Size = new System.Drawing.Size(182, 22);
            this.txt_timetable_group.TabIndex = 10;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_timetable_group);
            this.Controls.Add(this.btn_location_search);
            this.Controls.Add(this._dt_timetable_data);
            this.Name = "Groups";
            this.Size = new System.Drawing.Size(1046, 589);
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dt_timetable_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView _dt_timetable_data;
        private System.Windows.Forms.Button btn_location_search;
        private System.Windows.Forms.TextBox txt_timetable_group;
    }
}
