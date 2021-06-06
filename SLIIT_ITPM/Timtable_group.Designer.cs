namespace LibraryManagementSystem
{
    partial class Timtable_group
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
            this._dt_timetable_data = new System.Windows.Forms.DataGridView();
            this.cmb_data = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dt_timetable_data)).BeginInit();
            this.SuspendLayout();
            // 
            // _dt_timetable_data
            // 
            this._dt_timetable_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._dt_timetable_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._dt_timetable_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dt_timetable_data.DefaultCellStyle = dataGridViewCellStyle2;
            this._dt_timetable_data.Location = new System.Drawing.Point(79, 176);
            this._dt_timetable_data.Name = "_dt_timetable_data";
            this._dt_timetable_data.RowTemplate.Height = 24;
            this._dt_timetable_data.Size = new System.Drawing.Size(859, 377);
            this._dt_timetable_data.TabIndex = 8;
            // 
            // cmb_data
            // 
            this.cmb_data.FormattingEnabled = true;
            this.cmb_data.Location = new System.Drawing.Point(407, 110);
            this.cmb_data.Name = "cmb_data";
            this.cmb_data.Size = new System.Drawing.Size(213, 24);
            this.cmb_data.TabIndex = 14;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(643, 110);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 24);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // Timtable_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_data);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this._dt_timetable_data);
            this.Name = "Timtable_group";
            this.Size = new System.Drawing.Size(1046, 589);
            ((System.ComponentModel.ISupportInitialize)(this._dt_timetable_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dt_timetable_data;
        private System.Windows.Forms.ComboBox cmb_data;
        private System.Windows.Forms.Button btn_search;
    }
}
