using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _12_2_Assign_Tickets_with_Time_Slots
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        //OK button
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
