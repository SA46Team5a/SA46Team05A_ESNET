using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLibrary
{
    public partial class BaseForm : Form
    {
        Form caller;

        public BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(Form caller): this()
        {
            this.caller = caller;
        }
    }
}
