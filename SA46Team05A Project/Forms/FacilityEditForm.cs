using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SA46Team05A_Project.Entities;
using BaseLibrary;

namespace SA46Team05A_Project.Forms
{
    public partial class Facility_Edit_Form : BaseForm
    {
        Facility facility;
        bool todayNotAvailable;
        bool tomorrowNotAvailable;
        SportsFacBookingEntities context;
        DateTime tmr = DateTime.Today.AddDays(1);

        public Facility_Edit_Form() // Review for deletion
        {
            InitializeComponent();
        }

        public Facility_Edit_Form(Form caller, Facility facility):base(caller)
        {
            InitializeComponent();
            
            this.facility = facility;
            FacilityEditForm_Auto_Label.Text = facility.FacilityName;
            context = new SportsFacBookingEntities();

            todayNotAvailable = CheckAvailabilityByDate(DateTime.Today);
            Not_In_Use_Today_CheckBox.Checked = todayNotAvailable;
            
            tomorrowNotAvailable = CheckAvailabilityByDate(tmr);
            Not_In_Use_Tmr_CheckBox.Checked = tomorrowNotAvailable;
        }


        private bool CheckAvailabilityByDate(DateTime date)
        {
            List<Availability> availability = context.Availability.Where(
                x => x.Available == false
                && x.AvailDate == date
                && x.Facilities.FacilityName == facility.FacilityName)
                .ToList();
            if (availability.Count == 0)
                return false;
            else
                return true;
        }

        private void ToggleAvailabityByDateAndFacility(DateTime dt, Facility facility, bool available)
        {
            var s = context.Availability.Where(x => 
                x.AvailDate == dt 
                && x.Facilities.FacilityName == facility.FacilityName)
                .ToList();
            foreach (Availability a in s)
                a.Available = available;
            context.SaveChanges();
        }


        private void FacilityEditForm_Confirm_Button_Click(object sender, EventArgs e)
        {
            // Check if edits made
            //if (Not_In_Use_Today_CheckBox.Checked == todayNotAvailable
            //    && Not_In_Use_Tmr_CheckBox.Checked == tomorrowNotAvailable)
            //{
            //    // Nothing changed
            //    string message = "no change made, do u want to change?";
            //     string title = "no change made";
            //     MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //    DialogResult result = MessageBox.Show(message, title, buttons);
            //    //if (result == DialogResult.No)
            //    //{ 

            //    //    Facility_Edit_Form editform= new Facility_Edit_Form(this);
            //    //    editform.Show(); 
            //    //    // return to main page
            //    //}

            //}
            //else
            //{
                ToggleAvailabityByDateAndFacility(DateTime.Today, facility, !Not_In_Use_Today_CheckBox.Checked);
                ToggleAvailabityByDateAndFacility(DateTime.Today.AddDays(1), facility, !Not_In_Use_Tmr_CheckBox.Checked);

                if (Not_In_Use_Today_CheckBox.Checked != todayNotAvailable
                    || Not_In_Use_Tmr_CheckBox.Checked != tomorrowNotAvailable)
                {
                    MessageBox.Show("Changes have been saved.");
                    Dispose();
                }
                else
                {
                    DialogResult result = MessageBox.Show("No changes have been made, do you wish to change something?", "No changes made", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                        Dispose();
                }

                //if (Not_In_Use_Today_CheckBox.Checked == true && Not_In_Use_Tmr_CheckBox.Checked == false)
                //{
                //    String.Format("Change made,{0} is not in use for today ", facility.FacilityName);
                //    MessageBox.Show(String.Format("Change made,{0} is not in use for today ", facility.FacilityName));
                //}
                //else if (Not_In_Use_Today_CheckBox.Checked == false && Not_In_Use_Tmr_CheckBox.Checked  ==true)
                //{
                //    string.Format("Change made,{0} is not in use for tomorrow ", facility.FacilityName);
                //    MessageBox.Show(string.Format("Change made,{0} is not in use for tomorrow ", facility.FacilityName));
                //}
                //else if (Not_In_Use_Today_CheckBox.Checked == true && Not_In_Use_Today_CheckBox.Checked == true)
                //{
                //    string.Format("Change made,{0} is not in use for today&tomorrow ", facility.FacilityName);
                //    MessageBox.Show(String.Format("Change made,{0} is not in use for today&tomorrow ", facility.FacilityName));
                //}
            //}

            // SportsFacBookingEntities context = new SportsFacBookingEntities();
           // //string value = FacilityEditForm_Tomorrow_CheckBox.Text["Tomorrow"];
           //// MessageBox.Show("Change made,{0} is not in use for{1} ",FacilityEditForm_Auto_Label,Checkbox.Selected);
           // MessageBox.Show("no change made, do u want to change?");
           // string message = "no change made, do u want to change?";
           // string title = "no change made";
           // MessageBoxButtons buttons = MessageBoxButtons.YesNo;

           // DialogResult result = MessageBox.Show(message, title, buttons);
         
            
           // //if(result==DialogResult.No)
           // //{ 

           // //    Facility_Edit_Form editform= new Facility_Edit_Form(this);
           // //    editform.Show(); 
           // //    //next page
           // //}
        }


    }
}
