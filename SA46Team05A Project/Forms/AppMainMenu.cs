using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team05A_Project.Forms
{
    public partial class AppMainMenu : Form
    {
        public AppMainMenu()
        {
            InitializeComponent();
        }

        private void Create_Member_Button_Click(object sender, EventArgs e)
        {
            MemberMaintenanceForm f = new MemberMaintenanceForm(this);
            f.Show();
        }

        private void Edit_Member_Button_Click(object sender, EventArgs e)
        {
            MemberQueryForm f = new MemberQueryForm(this);
            f.Show();
        }
    }
}
