namespace SLIIT_ITPM
{
    partial class Location
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
            this.txt_location_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dt_location_data = new System.Windows.Forms.DataGridView();
            this.txt_building_name = new System.Windows.Forms.TextBox();
            this.btn_add_location = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_room_name = new System.Windows.Forms.TextBox();
            this.txt_room_type = new System.Windows.Forms.TextBox();
            this.txt_capacity = new System.Windows.Forms.TextBox();
            this.btn_update_location = new System.Windows.Forms.Button();
            this.btn_location_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_location_data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_location_search
            // 
            this.txt_location_search.Location = new System.Drawing.Point(342, 67);
            this.txt_location_search.Name = "txt_location_search";
            this.txt_location_search.Size = new System.Drawing.Size(155, 22);
            this.txt_location_search.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Building Name :";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(532, 66);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dt_location_data
            // 
            this.dt_location_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_location_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_location_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_location_data.Location = new System.Drawing.Point(23, 109);
            this.dt_location_data.Name = "dt_location_data";
            this.dt_location_data.RowTemplate.Height = 24;
            this.dt_location_data.Size = new System.Drawing.Size(633, 316);
            this.dt_location_data.TabIndex = 3;
            // 
            // txt_building_name
            // 
            this.txt_building_name.Location = new System.Drawing.Point(775, 159);
            this.txt_building_name.Name = "txt_building_name";
            this.txt_building_name.Size = new System.Drawing.Size(212, 22);
            this.txt_building_name.TabIndex = 4;
            // 
            // btn_add_location
            // 
            this.btn_add_location.Location = new System.Drawing.Point(694, 392);
            this.btn_add_location.Name = "btn_add_location";
            this.btn_add_location.Size = new System.Drawing.Size(75, 23);
            this.btn_add_location.TabIndex = 5;
            this.btn_add_location.Text = "Add";
            this.btn_add_location.UseVisualStyleBackColor = true;
            this.btn_add_location.Click += new System.EventHandler(this.btn_add_location_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capacity :";
            // 
            // txt_room_name
            // 
            this.txt_room_name.Location = new System.Drawing.Point(775, 211);
            this.txt_room_name.Name = "txt_room_name";
            this.txt_room_name.Size = new System.Drawing.Size(212, 22);
            this.txt_room_name.TabIndex = 9;
            // 
            // txt_room_type
            // 
            this.txt_room_type.Location = new System.Drawing.Point(775, 260);
            this.txt_room_type.Name = "txt_room_type";
            this.txt_room_type.Size = new System.Drawing.Size(212, 22);
            this.txt_room_type.TabIndex = 10;
            // 
            // txt_capacity
            // 
            this.txt_capacity.Location = new System.Drawing.Point(775, 304);
            this.txt_capacity.Name = "txt_capacity";
            this.txt_capacity.Size = new System.Drawing.Size(212, 22);
            this.txt_capacity.TabIndex = 11;
            // 
            // btn_update_location
            // 
            this.btn_update_location.Location = new System.Drawing.Point(807, 392);
            this.btn_update_location.Name = "btn_update_location";
            this.btn_update_location.Size = new System.Drawing.Size(75, 23);
            this.btn_update_location.TabIndex = 12;
            this.btn_update_location.Text = "Update";
            this.btn_update_location.UseVisualStyleBackColor = true;
            this.btn_update_location.Click += new System.EventHandler(this.btn_update_location_Click);
            // 
            // btn_location_delete
            // 
            this.btn_location_delete.Location = new System.Drawing.Point(912, 392);
            this.btn_location_delete.Name = "btn_location_delete";
            this.btn_location_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_location_delete.TabIndex = 13;
            this.btn_location_delete.Text = "Delete";
            this.btn_location_delete.UseVisualStyleBackColor = true;
            this.btn_location_delete.Click += new System.EventHandler(this.btn_location_delete_Click);
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_location_delete);
            this.Controls.Add(this.btn_update_location);
            this.Controls.Add(this.txt_capacity);
            this.Controls.Add(this.txt_room_type);
            this.Controls.Add(this.txt_room_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add_location);
            this.Controls.Add(this.txt_building_name);
            this.Controls.Add(this.dt_location_data);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_location_search);
            this.Name = "Location";
            this.Size = new System.Drawing.Size(1046, 642);
            this.Load += new System.EventHandler(this.Location_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_location_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_location_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dt_location_data;
        private System.Windows.Forms.TextBox txt_building_name;
        private System.Windows.Forms.Button btn_add_location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_room_name;
        private System.Windows.Forms.TextBox txt_room_type;
        private System.Windows.Forms.TextBox txt_capacity;
        private System.Windows.Forms.Button btn_update_location;
        private System.Windows.Forms.Button btn_location_delete;
    }
}
