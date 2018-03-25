using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BaseLibrary.Entities;
using BaseLibrary.ParentForms;

namespace SA46Team05A_Project.Forms
{
    public partial class MemberQueryForm : BaseForm
    {
        TextBox idTextBox;
        TextBox nameTextBox;
        SportsFacBookingEntities context;

        BindingSource searchBinding;

        public MemberQueryForm(Form caller, TextBox id, TextBox name) : base(caller)
        {
            InitializeComponent();
            context = new SportsFacBookingEntities();
            idTextBox = id;
            nameTextBox = name;

            // Prepare Search_DataGridView
            Search_DataGridView.AutoGenerateColumns = false;
            searchBinding = new BindingSource();
            RefreshLookupOutput();
            Search_DataGridView.DataSource = searchBinding;
        }

        // Refresh Search_DataGridView
        private void RefreshLookupOutput()
        {
            searchBinding.DataSource = context.Members.ToList();
        }

        // Event Handlers

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            string idSubStr = Member_ID_TextBox.Text;
            string nameSubStr = Member_Name_TextBox.Text;

            searchBinding.DataSource = context.Members.Where(x =>
                                        x.MemberName.Contains(nameSubStr)
                                        && x.MemberID.ToString().Contains(idSubStr)).ToList();

            Status.Text = String.Format("{0} results found.", searchBinding.Count);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Status.Text = "";

            if (!(Search_DataGridView.SelectedCells is null))
            {
                DataGridViewRow row = Search_DataGridView.Rows[Search_DataGridView.SelectedCells[0].RowIndex];
                idTextBox.Text = row.Cells["Member_ID_Column"].Value.ToString();
                nameTextBox.Text = row.Cells["Member_Name_Column"].Value.ToString();
                Dispose();
            }
            else
            {
                Status.Text = "Please select one customer, or press Cancel to return to the Loan form";
            }
        }
    }
}
