namespace SA46Team05A_Project.Forms
{
    partial class AppMainMenu
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
            this.Create_Member_Button = new System.Windows.Forms.Button();
            this.Edit_Member_Button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_Member_Button
            // 
            this.Create_Member_Button.Location = new System.Drawing.Point(88, 40);
            this.Create_Member_Button.Name = "Create_Member_Button";
            this.Create_Member_Button.Size = new System.Drawing.Size(152, 23);
            this.Create_Member_Button.TabIndex = 0;
            this.Create_Member_Button.Text = "Add New Member";
            this.Create_Member_Button.UseVisualStyleBackColor = true;
            this.Create_Member_Button.Click += new System.EventHandler(this.Create_Member_Button_Click);
            // 
            // Edit_Member_Button
            // 
            this.Edit_Member_Button.Location = new System.Drawing.Point(88, 64);
            this.Edit_Member_Button.Name = "Edit_Member_Button";
            this.Edit_Member_Button.Size = new System.Drawing.Size(152, 23);
            this.Edit_Member_Button.TabIndex = 0;
            this.Edit_Member_Button.Text = "Edit Member Details";
            this.Edit_Member_Button.UseVisualStyleBackColor = true;
            this.Edit_Member_Button.Click += new System.EventHandler(this.Edit_Member_Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AppMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Edit_Member_Button);
            this.Controls.Add(this.Create_Member_Button);
            this.Name = "AppMainMenu";
            this.Text = "AppMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_Member_Button;
        private System.Windows.Forms.Button Edit_Member_Button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}