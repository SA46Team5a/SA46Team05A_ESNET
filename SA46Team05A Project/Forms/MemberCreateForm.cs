using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLibrary;
using SA46Team05A_Project.Entities;


namespace SA46Team05A_Project.Forms
{
    public partial class MemberMaintenanceForm : BaseForm
    {
        SportsFacBookingEntities context;
        List<Member> mList;        
        Member member;

        public MemberMaintenanceForm(Form caller) : base(caller)
        {
            // Constructor for create mode
            InitializeComponent();

            BirthDay_Date_TextBox.Hide();
            BirthDay_Month_TextBox.Hide();
            Birthday_year_Textbox.Hide();
            Title_TextBox.Hide();
            JoinDate_TextBox.ReadOnly = true;
            ExpiryDate_TextBox.ReadOnly = true;
         
            // Fill birth year combobox
            for (int i = DateTime.Today.Year - 18; i > DateTime.Today.Year - 100; i--)
            {
                BirthDate_Year_Combobox.Items.Add(i);
            }
        }

        public MemberMaintenanceForm(Form caller, Member m) : this(caller)
        {
            // Constructor for edit mode
            member = m;

            MemberName_TextBox.ReadOnly = true;
            JoinDate_TextBox.ReadOnly = false;
            ExpiryDate_TextBox.ReadOnly = false;

            BirthDate_Date_Combobox.Hide();
            BirthDate_Month_Combobox.Hide();
            BirthDate_Year_Combobox.Hide();
            Male_RadioButton.Enabled = false;
            Female_RadioButton.Enabled = false;
            Reset_Button.Hide();

            BirthDay_Date_TextBox.Show();
            BirthDay_Month_TextBox.Show();
            Birthday_year_Textbox.Show();
            Title_TextBox.Show();

            Create_Button.Text = "Save";
        }

        // Helper Functions
        public DateTime GetBirthDay()
        {
            int day, month, year;
            day = Convert.ToInt32(BirthDate_Date_Combobox.Text);
            month = Convert.ToInt32(BirthDate_Month_Combobox.Text);
            year = Convert.ToInt32(BirthDate_Year_Combobox.Text);

            if ((month == 02) && (day == 29))
            {
                MessageBox.Show("Date should not be 29");
            }
            else if ((month == 02) && (day == 30))
            {
                MessageBox.Show("Date should not be 30");
            }
            else if ((month == 02) && (day == 31))
            {
                MessageBox.Show("Date should not be 31");
            }
            return new DateTime(year, month, day);
        }

        public DateTime GetJoinDate()
        {           

            DateTime join = DateTime.Today;
            string trimdate = (join.ToString("dd/MM/yyyy"));         
                      
            JoinDate_TextBox.Text = trimdate;
            return join;
        }

        public DateTime GetExpiryDate()
        {
            string expiryyear;
            DateTime expyears=DateTime.Today;
            //DateTime expyears = DateTime.Now;
            expyears = expyears.AddYears(2);
            expiryyear = Convert.ToString(expyears);
            expiryyear = (expyears.ToString("dd/MM/yyyy"));            
            ExpiryDate_TextBox.Text= expiryyear;            
            return expyears;
        }

        public string GetGender()
        {
            string value="";
            bool rb=Male_RadioButton.Checked;

            if (rb)
                value = "M"; //Male_RadioButton.Text;
            else
                value = "F"; // Female_RadioButton.Text;

            return value;
        }

        public string GetPhoneNumber(string phoneTextBox)
        {
            int n;

            if (phoneTextBox.Length != 8)
            {
                MessageBox.Show("Please enter the eight digit phone Number");
                phoneTextBox = "";
            }
            else
            {
                bool isNumeric = int.TryParse(phoneTextBox, out n);

                if (isNumeric == false)
                {
                    MessageBox.Show("Please enter the integer numbers");
                    phoneTextBox = "";
                }
                else
                {
                    string s = phoneTextBox;
                    string str = s.Substring(0, 1);
                    int num = Convert.ToInt32(str);
                    if (num != 9)
                    {
                        MessageBox.Show("The first digit of Phone Number should be 9");
                        phoneTextBox = "";
                    }
                }
            }

            return phoneTextBox;        
        }

        
        public string GetEmailID()
        {
            if (Email_TextBox.Text != "")
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(Email_TextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter valid EmailID");
                    Email_TextBox.Text = "";
                }
            }

            return Email_TextBox.Text;
        }

        // Event Handlers
        private void MemberCreateForm_Load(object sender, EventArgs e)
        {
            context = new SportsFacBookingEntities();
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            mList = context.Members.ToList();

            if (Title_ComboBox.Text == "")
            {
                MessageBox.Show("Please Enter the Title");
            }
            else if (MemberName_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the MemberName");
            }
            else if (PhoneNumber_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Phone Number");
            }
            else if (Emergency_Contact_Name_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Emergency Contact Name");
            }
            else if (Emergency_Contact_Number_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Emergency Contact Number");
            }
            else if (BirthDate_Date_Combobox.Text == "")
            {
                MessageBox.Show("Please Enter the Birth date");
            }
            else if (BirthDate_Month_Combobox.Text == "")
            {
                MessageBox.Show("Please Enter the Birth Month");
            }
            else if (BirthDate_Year_Combobox.Text == "")
            {
                MessageBox.Show("Please Enter the Birth Year");
            }            
            else if (Address_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Address");
            }
            else if ((Male_RadioButton.Checked == false) && (Female_RadioButton.Checked == false))
            {
                MessageBox.Show("Please select the gender");
            }
            else if (PhoneNumber_TextBox.Text == Emergency_Contact_Number_TextBox.Text)
            {
                MessageBox.Show("Phone Number and Emergency Contact Number should be different");
                
            }
            else
            {
                member.Salutation = Title_ComboBox.Text;
                member.MemberName = MemberName_TextBox.Text;
                member.Birthday = GetBirthDay();
                member.Sex = GetGender();
                member.PhoneNumber = GetPhoneNumber(PhoneNumber_TextBox.Text);
                member.Address = Address_TextBox.Text;
                member.Email = GetEmailID();
                member.EmergencyContactName = Emergency_Contact_Name_TextBox.Text;
                member.EmergencyContactPhone = GetPhoneNumber(Emergency_Contact_Number_TextBox.Text);
                member.JoinDate = GetJoinDate();
                member.ExpiryDate = GetExpiryDate();

                mList.Add(member);
                context.Members.Add(member);
                context.SaveChanges();
                MessageBox.Show("Member Created successful");
                MessageBox.Show(member.MemberID.ToString());

                Dispose();
            }
        }

        private void Title_ComboBox_TextChanged(object sender, EventArgs e)
        {
            if(Title_ComboBox.Text=="MR")
            {
                Female_RadioButton.Enabled = false;
                Male_RadioButton.Enabled = true;
            }
            else
            {
                Female_RadioButton.Enabled = true;
                Male_RadioButton.Enabled = false;
            }
        }

        private void PhoneNumber_TextBox_Leave(object sender, EventArgs e)
        {
            string phone=GetPhoneNumber(PhoneNumber_TextBox.Text);
            if(phone=="")
            {
                PhoneNumber_TextBox.Text = "";
            }

        }

        private void Emergency_Contact_Number_TextBox_Leave(object sender, EventArgs e)
        {
            string phone = GetPhoneNumber(Emergency_Contact_Number_TextBox.Text);
            if (phone == "")
            {
                Emergency_Contact_Number_TextBox.Text = "";
            }
            
        }

        private void Email_TextBox_Leave(object sender, EventArgs e)
        {
            GetEmailID();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Title_ComboBox.Text = "";
            MemberName_TextBox.Text = "";
            BirthDate_Date_Combobox.Text = "";
            BirthDate_Month_Combobox.Text = "";
            BirthDate_Year_Combobox.Text = "";
            Male_RadioButton.Checked = false;
            Female_RadioButton.Checked = false;
            Email_TextBox.Text = "";
            PhoneNumber_TextBox.Text = "";
            Emergency_Contact_Name_TextBox.Text = "";
            Emergency_Contact_Number_TextBox.Text = "";
            Address_TextBox.Text = "";
        }
    }
 }