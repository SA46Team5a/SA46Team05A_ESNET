namespace SA46Team05A_Project.Forms
{
    partial class AvailabilityQueryForm
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
            this.Availibility_Query_Label = new System.Windows.Forms.Label();
            this.Facility_ComboBox = new System.Windows.Forms.ComboBox();
            this.Facility_Label = new System.Windows.Forms.Label();
            this.Today_CheckBox = new System.Windows.Forms.CheckBox();
            this.Tomorrow_CheckBox = new System.Windows.Forms.CheckBox();
            this.Availability_DataGridView = new System.Windows.Forms.DataGridView();
            this.Proceed_To_Booking_Button = new System.Windows.Forms.Button();
            this.Date_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timeslot_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booked_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Availability_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(408, 456);
            // 
            // Availibility_Query_Label
            // 
            this.Availibility_Query_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availibility_Query_Label.Location = new System.Drawing.Point(224, 16);
            this.Availibility_Query_Label.Name = "Availibility_Query_Label";
            this.Availibility_Query_Label.Size = new System.Drawing.Size(237, 43);
            this.Availibility_Query_Label.TabIndex = 2;
            this.Availibility_Query_Label.Text = "Availability Query";
            this.Availibility_Query_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Facility_ComboBox
            // 
            this.Facility_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Facility_ComboBox.FormattingEnabled = true;
            this.Facility_ComboBox.Location = new System.Drawing.Point(320, 96);
            this.Facility_ComboBox.Name = "Facility_ComboBox";
            this.Facility_ComboBox.Size = new System.Drawing.Size(152, 24);
            this.Facility_ComboBox.TabIndex = 3;
            this.Facility_ComboBox.SelectedValueChanged += new System.EventHandler(this.Control_Changed);
            // 
            // Facility_Label
            // 
            this.Facility_Label.AutoSize = true;
            this.Facility_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Facility_Label.Location = new System.Drawing.Point(216, 98);
            this.Facility_Label.Name = "Facility_Label";
            this.Facility_Label.Size = new System.Drawing.Size(92, 17);
            this.Facility_Label.TabIndex = 4;
            this.Facility_Label.Text = "Facility Name";
            // 
            // Today_CheckBox
            // 
            this.Today_CheckBox.AutoSize = true;
            this.Today_CheckBox.Checked = true;
            this.Today_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Today_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Today_CheckBox.Location = new System.Drawing.Point(240, 136);
            this.Today_CheckBox.Name = "Today_CheckBox";
            this.Today_CheckBox.Size = new System.Drawing.Size(67, 21);
            this.Today_CheckBox.TabIndex = 5;
            this.Today_CheckBox.Text = "Today";
            this.Today_CheckBox.UseVisualStyleBackColor = true;
            this.Today_CheckBox.CheckStateChanged += new System.EventHandler(this.Control_Changed);
            // 
            // Tomorrow_CheckBox
            // 
            this.Tomorrow_CheckBox.AutoSize = true;
            this.Tomorrow_CheckBox.Checked = true;
            this.Tomorrow_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Tomorrow_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tomorrow_CheckBox.Location = new System.Drawing.Point(360, 136);
            this.Tomorrow_CheckBox.Name = "Tomorrow_CheckBox";
            this.Tomorrow_CheckBox.Size = new System.Drawing.Size(90, 21);
            this.Tomorrow_CheckBox.TabIndex = 5;
            this.Tomorrow_CheckBox.Text = "Tomorrow";
            this.Tomorrow_CheckBox.UseVisualStyleBackColor = true;
            this.Tomorrow_CheckBox.CheckStateChanged += new System.EventHandler(this.Control_Changed);
            // 
            // Availability_DataGridView
            // 
            this.Availability_DataGridView.AllowUserToAddRows = false;
            this.Availability_DataGridView.AllowUserToDeleteRows = false;
            this.Availability_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Availability_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Availability_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_Column,
            this.Timeslot_Column,
            this.MemberName_Column,
            this.Booked_Column,
            this.Available_Column});
            this.Availability_DataGridView.Location = new System.Drawing.Point(40, 184);
            this.Availability_DataGridView.Name = "Availability_DataGridView";
            this.Availability_DataGridView.ReadOnly = true;
            this.Availability_DataGridView.Size = new System.Drawing.Size(624, 256);
            this.Availability_DataGridView.TabIndex = 6;
            // 
            // Proceed_To_Booking_Button
            // 
            this.Proceed_To_Booking_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Proceed_To_Booking_Button.Location = new System.Drawing.Point(200, 456);
            this.Proceed_To_Booking_Button.Name = "Proceed_To_Booking_Button";
            this.Proceed_To_Booking_Button.Size = new System.Drawing.Size(160, 30);
            this.Proceed_To_Booking_Button.TabIndex = 7;
            this.Proceed_To_Booking_Button.Text = "Proceed To Booking";
            this.Proceed_To_Booking_Button.UseVisualStyleBackColor = true;
            this.Proceed_To_Booking_Button.Click += new System.EventHandler(this.Proceed_To_Booking_Button_Click);
            // 
            // Date_Column
            // 
            this.Date_Column.DataPropertyName = "AvailDate";
            this.Date_Column.HeaderText = "Date";
            this.Date_Column.Name = "Date_Column";
            this.Date_Column.ReadOnly = true;
            // 
            // Timeslot_Column
            // 
            this.Timeslot_Column.DataPropertyName = "Timeslot";
            this.Timeslot_Column.HeaderText = "Time Slot";
            this.Timeslot_Column.Name = "Timeslot_Column";
            this.Timeslot_Column.ReadOnly = true;
            // 
            // MemberName_Column
            // 
            this.MemberName_Column.DataPropertyName = "MemberName";
            this.MemberName_Column.HeaderText = "Member Name";
            this.MemberName_Column.Name = "MemberName_Column";
            this.MemberName_Column.ReadOnly = true;
            // 
            // Booked_Column
            // 
            this.Booked_Column.DataPropertyName = "Booked";
            this.Booked_Column.HeaderText = "Booked";
            this.Booked_Column.Name = "Booked_Column";
            this.Booked_Column.ReadOnly = true;
            this.Booked_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Available_Column
            // 
            this.Available_Column.DataPropertyName = "Available";
            this.Available_Column.HeaderText = "Available";
            this.Available_Column.Name = "Available_Column";
            this.Available_Column.ReadOnly = true;
            // 
            // AvailabilityQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(705, 550);
            this.Controls.Add(this.Proceed_To_Booking_Button);
            this.Controls.Add(this.Availability_DataGridView);
            this.Controls.Add(this.Tomorrow_CheckBox);
            this.Controls.Add(this.Today_CheckBox);
            this.Controls.Add(this.Facility_Label);
            this.Controls.Add(this.Facility_ComboBox);
            this.Controls.Add(this.Availibility_Query_Label);
            this.Name = "AvailabilityQueryForm";
            this.Text = "Availability Query Form";
            this.Controls.SetChildIndex(this.Availibility_Query_Label, 0);
            this.Controls.SetChildIndex(this.Facility_ComboBox, 0);
            this.Controls.SetChildIndex(this.Facility_Label, 0);
            this.Controls.SetChildIndex(this.Today_CheckBox, 0);
            this.Controls.SetChildIndex(this.Tomorrow_CheckBox, 0);
            this.Controls.SetChildIndex(this.Availability_DataGridView, 0);
            this.Controls.SetChildIndex(this.Back_Button, 0);
            this.Controls.SetChildIndex(this.Proceed_To_Booking_Button, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Availability_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Availibility_Query_Label;
        private System.Windows.Forms.ComboBox Facility_ComboBox;
        private System.Windows.Forms.Label Facility_Label;
        private System.Windows.Forms.CheckBox Today_CheckBox;
        private System.Windows.Forms.CheckBox Tomorrow_CheckBox;
        private System.Windows.Forms.DataGridView Availability_DataGridView;
        private System.Windows.Forms.Button Proceed_To_Booking_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timeslot_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booked_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Column;
    }
}
