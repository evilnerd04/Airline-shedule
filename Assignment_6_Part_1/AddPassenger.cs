using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment_6_Part_1
{
    public partial class AddPassenger : Form
    {
        int passid = 1;
       int flight2;
        public AddPassenger(int flight)
        {
            InitializeComponent();
            flight2 = flight;
        }

        /// <summary>
        /// handles cancel button click returns to main menu and fills the comb box with new passenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAirlineReservation fill = new frmAirlineReservation();
            fill.FillPassengerCB();
            base.Hide();
        }

        /// <summary>
        /// handles save button click, adds passenger to passenger table and adds a link for the passenger in the link table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //db connection
                clsDataAccess db = new clsDataAccess();

                db.InsertPassenger(passid, txtFirstName.Text, txtLastName.Text);
                db.InsertLinkTable(flight2, 0, passid);
                passid++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

            base.Hide();
        }
    }
}
