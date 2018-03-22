namespace SA46Team05A_Project.Forms
{
    partial class FacilityBookingForm
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
            this.Bookingform_Label = new System.Windows.Forms.Label();
            this.Facility_Name_Label = new System.Windows.Forms.Label();
            this.Facility_Name_ComboBox = new System.Windows.Forms.ComboBox();
            this.Book_Button = new System.Windows.Forms.Button();
            this.Booking_Form_Cancel_Button = new System.Windows.Forms.Button();
            this.MemberID_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MemberSearch_Button = new System.Windows.Forms.Button();
            this.MemberName_TextBox = new System.Windows.Forms.TextBox();
            this.MemberName_Label = new System.Windows.Forms.Label();
            this.StartTime_ComboBox = new System.Windows.Forms.ComboBox();
            this.EndTime_ComboBox = new System.Windows.Forms.ComboBox();
            this.StartTime_Label = new System.Windows.Forms.Label();
            this.EndTime_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bookingform_Label
            // 
            this.Bookingform_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookingform_Label.Location = new System.Drawing.Point(227, 30);
            this.Bookingform_Label.Name = "Bookingform_Label";
            this.Bookingform_Label.Size = new System.Drawing.Size(237, 43);
            this.Bookingform_Label.TabIndex = 0;
            this.Bookingform_Label.Text = "Book Facility";
            this.Bookingform_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Facility_Name_Label
            // 
            this.Facility_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facility_Name_Label.Location = new System.Drawing.Point(76, 164);
            this.Facility_Name_Label.Name = "Facility_Name_Label";
            this.Facility_Name_Label.Size = new System.Drawing.Size(132, 23);
            this.Facility_Name_Label.TabIndex = 1;
            this.Facility_Name_Label.Text = "Facility Name";
            this.Facility_Name_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Facility_Name_ComboBox
            // 
            this.Facility_Name_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Facility_Name_ComboBox.FormattingEnabled = true;
            this.Facility_Name_ComboBox.Location = new System.Drawing.Point(205, 164);
            this.Facility_Name_ComboBox.Name = "Facility_Name_ComboBox";
            this.Facility_Name_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Facility_Name_ComboBox.TabIndex = 2;
            // 
            // Book_Button
            // 
            this.Book_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Button.Location = new System.Drawing.Point(205, 362);
            this.Book_Button.Name = "Book_Button";
            this.Book_Button.Size = new System.Drawing.Size(120, 40);
            this.Book_Button.TabIndex = 6;
            this.Book_Button.Text = "Book";
            this.Book_Button.UseVisualStyleBackColor = true;
            // 
            // Booking_Form_Cancel_Button
            // 
            this.Booking_Form_Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Form_Cancel_Button.Location = new System.Drawing.Point(426, 362);
            this.Booking_Form_Cancel_Button.Name = "Booking_Form_Cancel_Button";
            this.Booking_Form_Cancel_Button.Size = new System.Drawing.Size(120, 40);
            this.Booking_Form_Cancel_Button.TabIndex = 7;
            this.Booking_Form_Cancel_Button.Text = "Cancel";
            this.Booking_Form_Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // MemberID_Label
            // 
            this.MemberID_Label.AutoSize = true;
            this.MemberID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberID_Label.Location = new System.Drawing.Point(93, 96);
            this.MemberID_Label.Name = "MemberID_Label";
            this.MemberID_Label.Size = new System.Drawing.Size(82, 16);
            this.MemberID_Label.TabIndex = 8;
            this.MemberID_Label.Text = "Memeber ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // MemberSearch_Button
            // 
            this.MemberSearch_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberSearch_Button.Location = new System.Drawing.Point(321, 93);
            this.MemberSearch_Button.Name = "MemberSearch_Button";
            this.MemberSearch_Button.Size = new System.Drawing.Size(28, 23);
            this.MemberSearch_Button.TabIndex = 10;
            this.MemberSearch_Button.Text = "...";
            this.MemberSearch_Button.UseVisualStyleBackColor = true;
            this.MemberSearch_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // MemberName_TextBox
            // 
            this.MemberName_TextBox.Location = new System.Drawing.Point(205, 127);
            this.MemberName_TextBox.Name = "MemberName_TextBox";
            this.MemberName_TextBox.Size = new System.Drawing.Size(144, 20);
            this.MemberName_TextBox.TabIndex = 11;
            // 
            // MemberName_Label
            // 
            this.MemberName_Label.AutoSize = true;
            this.MemberName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberName_Label.Location = new System.Drawing.Point(93, 131);
            this.MemberName_Label.Name = "MemberName_Label";
            this.MemberName_Label.Size = new System.Drawing.Size(106, 16);
            this.MemberName_Label.TabIndex = 12;
            this.MemberName_Label.Text = "Memeber Name";
            // 
            // StartTime_ComboBox
            // 
            this.StartTime_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartTime_ComboBox.FormattingEnabled = true;
            this.StartTime_ComboBox.Location = new System.Drawing.Point(205, 241);
            this.StartTime_ComboBox.Name = "StartTime_ComboBox";
            this.StartTime_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.StartTime_ComboBox.TabIndex = 13;
            // 
            // EndTime_ComboBox
            // 
            this.EndTime_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndTime_ComboBox.FormattingEnabled = true;
            this.EndTime_ComboBox.Location = new System.Drawing.Point(455, 241);
            this.EndTime_ComboBox.Name = "EndTime_ComboBox";
            this.EndTime_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.EndTime_ComboBox.TabIndex = 14;
            // 
            // StartTime_Label
            // 
            this.StartTime_Label.AutoSize = true;
            this.StartTime_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime_Label.Location = new System.Drawing.Point(96, 248);
            this.StartTime_Label.Name = "StartTime_Label";
            this.StartTime_Label.Size = new System.Drawing.Size(69, 16);
            this.StartTime_Label.TabIndex = 15;
            this.StartTime_Label.Text = "Start Time";
            // 
            // EndTime_Label
            // 
            this.EndTime_Label.AutoSize = true;
            this.EndTime_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime_Label.Location = new System.Drawing.Point(366, 246);
            this.EndTime_Label.Name = "EndTime_Label";
            this.EndTime_Label.Size = new System.Drawing.Size(66, 16);
            this.EndTime_Label.TabIndex = 16;
            this.EndTime_Label.Text = "End Time";
            // 
            // Booking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 428);
            this.Controls.Add(this.EndTime_Label);
            this.Controls.Add(this.StartTime_Label);
            this.Controls.Add(this.EndTime_ComboBox);
            this.Controls.Add(this.StartTime_ComboBox);
            this.Controls.Add(this.MemberName_Label);
            this.Controls.Add(this.MemberName_TextBox);
            this.Controls.Add(this.MemberSearch_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MemberID_Label);
            this.Controls.Add(this.Booking_Form_Cancel_Button);
            this.Controls.Add(this.Book_Button);
            this.Controls.Add(this.Facility_Name_ComboBox);
            this.Controls.Add(this.Facility_Name_Label);
            this.Controls.Add(this.Bookingform_Label);
            this.Name = "Booking_Form";
            this.Text = "Booking_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bookingform_Label;
        private System.Windows.Forms.Label Facility_Name_Label;
        private System.Windows.Forms.ComboBox Facility_Name_ComboBox;
        private System.Windows.Forms.Button Book_Button;
        private System.Windows.Forms.Button Booking_Form_Cancel_Button;
        private System.Windows.Forms.Label MemberID_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MemberSearch_Button;
        private System.Windows.Forms.TextBox MemberName_TextBox;
        private System.Windows.Forms.Label MemberName_Label;
        private System.Windows.Forms.ComboBox StartTime_ComboBox;
        private System.Windows.Forms.ComboBox EndTime_ComboBox;
        private System.Windows.Forms.Label StartTime_Label;
        private System.Windows.Forms.Label EndTime_Label;
    }
}

