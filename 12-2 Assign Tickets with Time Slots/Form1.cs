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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region BUTTONS
        //Exit Button to close application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Options button: instantiate a new Options form that is modal
        private void btnOptions_Click(object sender, EventArgs e)
        {
            var myForm = new frmOptions();
            myForm.ShowDialog();
        }

        //Adds a ticket to the list box
        private void btnIssueTicket_Click(object sender, EventArgs e)
        {

        }
        #endregion

        
    }
}
