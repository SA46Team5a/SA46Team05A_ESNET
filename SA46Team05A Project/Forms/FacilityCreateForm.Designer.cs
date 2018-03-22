namespace SA46Team05A_Project.Forms
{
    partial class FacilityCreateForm
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
            this.Create_Facilities_Label = new System.Windows.Forms.Label();
            this.FacilityID_Label = new System.Windows.Forms.Label();
            this.FacilityID_TextBox = new System.Windows.Forms.TextBox();
            this.FacilityName_Label = new System.Windows.Forms.Label();
            this.FacilityName_TextBox = new System.Windows.Forms.TextBox();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_Facilities_Label
            // 
            this.Create_Facilities_Label.AutoSize = true;
            this.Create_Facilities_Label.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Facilities_Label.Location = new System.Drawing.Point(290, 69);
            this.Create_Facilities_Label.Name = "Create_Facilities_Label";
            this.Create_Facilities_Label.Size = new System.Drawing.Size(363, 49);
            this.Create_Facilities_Label.TabIndex = 1;
            this.Create_Facilities_Label.Text = "Create Facilities Form";
            // 
            // FacilityID_Label
            // 
            this.FacilityID_Label.AutoSize = true;
            this.FacilityID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityID_Label.Location = new System.Drawing.Point(216, 182);
            this.FacilityID_Label.Name = "FacilityID_Label";
            this.FacilityID_Label.Size = new System.Drawing.Size(139, 32);
            this.FacilityID_Label.TabIndex = 2;
            this.FacilityID_Label.Text = "Facility ID";
            // 
            // FacilityID_TextBox
            // 
            this.FacilityID_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityID_TextBox.Location = new System.Drawing.Point(462, 175);
            this.FacilityID_TextBox.Name = "FacilityID_TextBox";
            this.FacilityID_TextBox.Size = new System.Drawing.Size(260, 39);
            this.FacilityID_TextBox.TabIndex = 3;
            // 
            // FacilityName_Label
            // 
            this.FacilityName_Label.AutoSize = true;
            this.FacilityName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityName_Label.Location = new System.Drawing.Point(216, 278);
            this.FacilityName_Label.Name = "FacilityName_Label";
            this.FacilityName_Label.Size = new System.Drawing.Size(187, 32);
            this.FacilityName_Label.TabIndex = 4;
            this.FacilityName_Label.Text = "Facility Name";
            // 
            // FacilityName_TextBox
            // 
            this.FacilityName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityName_TextBox.Location = new System.Drawing.Point(462, 271);
            this.FacilityName_TextBox.Name = "FacilityName_TextBox";
            this.FacilityName_TextBox.Size = new System.Drawing.Size(260, 39);
            this.FacilityName_TextBox.TabIndex = 5;
            // 
            // Create_Button
            // 
            this.Create_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Button.Location = new System.Drawing.Point(283, 390);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(120, 40);
            this.Create_Button.TabIndex = 6;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(554, 390);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(120, 40);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Create_Facilities_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 486);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.FacilityName_TextBox);
            this.Controls.Add(this.FacilityName_Label);
            this.Controls.Add(this.FacilityID_TextBox);
            this.Controls.Add(this.FacilityID_Label);
            this.Controls.Add(this.Create_Facilities_Label);
            this.Name = "Create_Facilities_Form";
            this.Text = "Create Facilities Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Create_Facilities_Label;
        private System.Windows.Forms.Label FacilityID_Label;
        private System.Windows.Forms.TextBox FacilityID_TextBox;
        private System.Windows.Forms.Label FacilityName_Label;
        private System.Windows.Forms.TextBox FacilityName_TextBox;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}

