using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BaseLibrary;
using SA46Team05A_Project.Entities;

namespace SA46Team05A_Project.Forms
{
    public partial class AvailabilityQueryForm : BaseLibrary.BaseForm
    {
        SportsFacBookingEntities context;
        BindingSource availBinding;

        public AvailabilityQueryForm(Form caller): base(caller)
        {
            InitializeComponent();

            context = new SportsFacBookingEntities();

            // Fill Facility_ComboBox
            List<string> facilities = context.Facilities.Select(x => x.FacilityName).ToList();
            foreach (string facility in facilities)
            {
                Facility_ComboBox.Items.Add(facility);
            }

            // Prepare datagridview
            availBinding = new BindingSource();
            Availability_DataGridView.DataSource = availBinding;
            Availability_DataGridView.AutoGenerateColumns = false;
        }

        // Query functions
        public void Control_Changed(object sender, EventArgs e)
        {
            availBinding.Clear();
            if (Facility_ComboBox.Text != "")
            {
                DateTime tomorrow = DateTime.Today.AddDays(1);
                Facility facility = context.Facilities.Where(x =>
                    x.FacilityName == Facility_ComboBox.Text).First();
                var availability = context.Availability
                    .Select(x => new {x.AvailDate,
                                      x.Timeslot,
                                      x.Members.MemberName,
                                      x.FacilityID,
                                      x.Booked,
                                      x.Available}).ToList();

                // Both days selected
                if (Today_CheckBox.Checked && Tomorrow_CheckBox.Checked)
                {
                    availBinding.DataSource = availability.Where(
                        x => ((x.AvailDate == DateTime.Today && x.Timeslot > DateTime.Today.Hour)
                            || x.AvailDate == tomorrow)
                            && x.FacilityID == facility.FacilityID).ToList();
                }
                // Today selected
                else if (Today_CheckBox.Checked)
                {
                    availBinding.DataSource = availability.Where(
                        x => x.AvailDate == DateTime.Today && x.Timeslot > DateTime.Today.Hour
                            && x.FacilityID == facility.FacilityID).ToList();
                }
                // Tomorrow selected
                else if (Tomorrow_CheckBox.Checked)
                {
                    availBinding.DataSource = availability.Where(
                       x => x.AvailDate == tomorrow
                           && x.FacilityID == facility.FacilityID).ToList();
                }
            }

            if (Availability_DataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Availability_DataGridView.Rows)
                {
                    if (!(bool)row.Cells["Available_Column"].Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkGray;
                    }
                    else if ((bool)row.Cells["Booked_Column"].Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;
                    }
                }
            }
        }

        private void Proceed_To_Booking_Button_Click(object sender, EventArgs e)
        {
            FacilityBookingForm f = new FacilityBookingForm(this);
            f.Show();
            Hide();
        }
    }
}