namespace SA46Team05A_Project.Forms
{
    partial class FacilityCancelForm
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
            this.Cancel_Booking_Label = new System.Windows.Forms.Label();
            this.MemberID_Label = new System.Windows.Forms.Label();
            this.MemberID_TextBox = new System.Windows.Forms.TextBox();
            this.MemberIDSearch_Button = new System.Windows.Forms.Button();
            this.MemberName_TextBox = new System.Windows.Forms.TextBox();
            this.MemberName_Label = new System.Windows.Forms.Label();
            this.GetBookings_Button = new System.Windows.Forms.Button();
            this.Cancel_dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Booking_Label
            // 
            this.Cancel_Booking_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Booking_Label.Location = new System.Drawing.Point(206, 27);
            this.Cancel_Booking_Label.Name = "Cancel_Booking_Label";
            this.Cancel_Booking_Label.Size = new System.Drawing.Size(214, 42);
            this.Cancel_Booking_Label.TabIndex = 0;
            this.Cancel_Booking_Label.Text = "Cancel Booking";
            this.Cancel_Booking_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberID_Label
            // 
            this.MemberID_Label.AutoSize = true;
            this.MemberID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberID_Label.Location = new System.Drawing.Point(141, 90);
            this.MemberID_Label.Name = "MemberID_Label";
            this.MemberID_Label.Size = new System.Drawing.Size(82, 16);
            this.MemberID_Label.TabIndex = 9;
            this.MemberID_Label.Text = "Memeber ID";
            // 
            // MemberID_TextBox
            // 
            this.MemberID_TextBox.Location = new System.Drawing.Point(255, 89);
            this.MemberID_TextBox.Name = "MemberID_TextBox";
            this.MemberID_TextBox.Size = new System.Drawing.Size(100, 20);
            this.MemberID_TextBox.TabIndex = 10;
            // 
            // MemberIDSearch_Button
            // 
            this.MemberIDSearch_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDSearch_Button.Location = new System.Drawing.Point(379, 86);
            this.MemberIDSearch_Button.Name = "MemberIDSearch_Button";
            this.MemberIDSearch_Button.Size = new System.Drawing.Size(28, 23);
            this.MemberIDSearch_Button.TabIndex = 11;
            this.MemberIDSearch_Button.Text = "...";
            this.MemberIDSearch_Button.UseVisualStyleBackColor = true;
            // 
            // MemberName_TextBox
            // 
            this.MemberName_TextBox.Location = new System.Drawing.Point(255, 128);
            this.MemberName_TextBox.Name = "MemberName_TextBox";
            this.MemberName_TextBox.Size = new System.Drawing.Size(144, 20);
            this.MemberName_TextBox.TabIndex = 12;
            // 
            // MemberName_Label
            // 
            this.MemberName_Label.AutoSize = true;
            this.MemberName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberName_Label.Location = new System.Drawing.Point(132, 132);
            this.MemberName_Label.Name = "MemberName_Label";
            this.MemberName_Label.Size = new System.Drawing.Size(106, 16);
            this.MemberName_Label.TabIndex = 13;
            this.MemberName_Label.Text = "Memeber Name";
            // 
            // GetBookings_Button
            // 
            this.GetBookings_Button.Location = new System.Drawing.Point(255, 176);
            this.GetBookings_Button.Name = "GetBookings_Button";
            this.GetBookings_Button.Size = new System.Drawing.Size(110, 23);
            this.GetBookings_Button.TabIndex = 14;
            this.GetBookings_Button.Text = "Get Bookings";
            this.GetBookings_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_dataGridView
            // 
            this.Cancel_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cancel_dataGridView.Location = new System.Drawing.Point(144, 217);
            this.Cancel_dataGridView.Name = "Cancel_dataGridView";
            this.Cancel_dataGridView.Size = new System.Drawing.Size(320, 150);
            this.Cancel_dataGridView.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancel Booking";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cancel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel_dataGridView);
            this.Controls.Add(this.GetBookings_Button);
            this.Controls.Add(this.MemberName_Label);
            this.Controls.Add(this.MemberName_TextBox);
            this.Controls.Add(this.MemberIDSearch_Button);
            this.Controls.Add(this.MemberID_TextBox);
            this.Controls.Add(this.MemberID_Label);
            this.Controls.Add(this.Cancel_Booking_Label);
            this.Name = "Cancel_Form";
            this.Text = "Cancel_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cancel_Booking_Label;
        private System.Windows.Forms.Label MemberID_Label;
        private System.Windows.Forms.TextBox MemberID_TextBox;
        private System.Windows.Forms.Button MemberIDSearch_Button;
        private System.Windows.Forms.TextBox MemberName_TextBox;
        private System.Windows.Forms.Label MemberName_Label;
        private System.Windows.Forms.Button GetBookings_Button;
        private System.Windows.Forms.DataGridView Cancel_dataGridView;
        private System.Windows.Forms.Button button1;
    }
}