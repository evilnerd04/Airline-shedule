using System;
using System.Collections;
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
    public partial class frmAirlineReservation : Form
    {
        //db connection
        clsDataAccess db = new clsDataAccess();

        int flight = 0;
        
        

        public frmAirlineReservation()
        {
            InitializeComponent();

            //try catch to connect to and pull flight info from db
            try
            {
                //create a dataset to hold data
                DataSet ds;

                
                //get all the values form the Flight Table
                ds = db.GetFlightInfo();

                //loop through all the values returned
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //add the flight names to the combo box
                    cbFlight.Items.Add(ds.Tables[0].Rows[i][1] + " - " + ds.Tables[0].Rows[i].ItemArray[2].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Handle flight selection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //enable buttons and comboBox
            btnAddPassenger.Enabled = true;
            btnChangeSeat.Enabled = true;
            btnDeletePassenger.Enabled = true;
            cbPassenger.Enabled = true;

            //handle panel changes
            if (cbFlight.Text == "102 - Airbus A380")
            {
                pannelFlightA.Visible = true;
                pannelFlightA.Enabled = true;
                pannelFlightB.Visible = false;
                flight = 1;
                FillPassengerCB();
                FillSeatColor(pannelFlightA);
            }
            else if (cbFlight.Text == "412 - Boeing 767")
            {
                pannelFlightB.Visible = true;
                pannelFlightB.Enabled = true;
                pannelFlightA.Visible = false;
                flight = 2;
                FillPassengerCB();
                FillSeatColor(pannelFlightB);
            }

        }

        public void FillPassengerCB()
        { 
            DataSet ds;
            
            //get all the values form the Flight Table
            
            ds = db.GetPassengerInfo(flight);
            TakenseatNum.Items.Clear();
            cbPassenger.Items.Clear();
            cbPassenger.Text = "";
            //loop through all the values returned
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //add the flight names to the combo box
                
                cbPassenger.Items.Add(ds.Tables[0].Rows[i][1] + " " + ds.Tables[0].Rows[i][2]);
                TakenseatNum.Items.Add(ds.Tables[0].Rows[i][3]);
            }
            
        }

        public void FillSeatColor(Panel fill)
        {
            try
            {
                IEnumerator enumerator = fill.Controls.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        Label label = (Label)enumerator.Current;
                        if (label.Text != "-1")
                        {
                            label.BackColor=Color.Blue;
                        }
                    }
                }
                finally
                {
                    IDisposable disposable = enumerator as IDisposable;
                    if (disposable != null)
                    {
                        disposable.Dispose();
                    }
                }
                
            
                for (int i = 0; i < TakenseatNum.Items.Count; i++)
                {
                    string text = TakenseatNum.GetItemText(TakenseatNum.Items[i]);
                    IEnumerator enumerator2 = fill.Controls.GetEnumerator();
                    try
                    {
                        while (enumerator2.MoveNext())
                        {
                            Label label2 = (Label)enumerator2.Current;
                            if (label2.Text != "-1" && label2.Text == text)
                            {
                                /* if (label2.Tag.ToString() == this.lblSeat.Text())
                                 {
                                     label2.BackColor=Color.Lime;
                                 }
                                 else
                                 {*/
                                label2.BackColor = Color.Red;
                                //}
                            }
                        }
                    }



                    finally
                    {
                        IDisposable disposable2 = enumerator2 as IDisposable;
                        if (disposable2 != null)
                        {
                            disposable2.Dispose();
                        }
                    }
                }
            }
             catch (Exception ex)
            {
                throw new Exception("frmAirline.LoadPanel-> " + ex.Message);
            }
        } 

        /// <summary>
        /// handles add passenger button click (sends to new form)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            AddPassenger frmForm1 = new AddPassenger(flight);
            frmForm1.Show();
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            try
            {
                Label label1 = (Label)sender;
                
                
                    ClickingSeatToSelectMode(label1, (Panel)label1.Parent);
                
                /*if (this.bUpdateSeatMode)
                {
                    this.UpdateSeatMode(label, (Panel)label.Parent);
                }*/
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("frmAirline.Seat_Click-> " + ex.Message);
            }
        }

        private void ClickingSeatToSelectMode(Label MyLabel, Panel MyPanel)
        {
            try
            {
                if (MyLabel.BackColor == Color.Red)
                {
                    IEnumerator enumerator = MyPanel.Controls.GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            Label label = (Label)enumerator.Current;
                            if (label.BackColor == Color.Lime)
                            {
                                label.BackColor=Color.Red;
                            }
                        }
                    }
                    finally
                    {
                        IDisposable disposable = enumerator as IDisposable;
                        if (disposable != null)
                        {
                            disposable.Dispose();
                        }
                    }
                    if (MyLabel.BackColor == Color.Red)
                    {
                        MyLabel.BackColor=Color.Lime;
                    }
                    
                }
                else
                {

                    IEnumerator enumerator = MyPanel.Controls.GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            Label label = (Label)enumerator.Current;
                            if (label.BackColor == Color.Lime)
                            {
                                label.BackColor = Color.Blue;
                            }
                        }
                    }
                    finally
                    {
                        IDisposable disposable = enumerator as IDisposable;
                        if (disposable != null)
                        {
                            disposable.Dispose();
                        }
                    }
                    if (MyLabel.BackColor == Color.Blue)
                    {
                        MyLabel.BackColor = Color.Lime;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("frmAirline.ClickingSeatToSelectMode-> " + ex.Message);
            }
        }


        /// <summary>
        /// when the delete passenger button is clicked it deletes the selected passenger form the passenger table 
        /// and the link from the link table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletePassenger_Click(object sender, EventArgs e)
        {
            //splits the name from Combo box into first and last name
            string first, last;
            string fullname = cbPassenger.SelectedText;
            string[] name1 = fullname.Split(' ');
            first = name1[0];
            last = name1[1];

            // takes the first name and last name and gets passenger ID in order to delete passenger
            int passID;
            passID = (int)db.GetPassengerID(first, last);
            db.DeletePassenger(passID);
            db.DeleteLink(flight, passID);
            //reloads combo box with update
            FillPassengerCB();

            if (flight == 1)
            {
                FillSeatColor(pannelFlightA);
            }
            else
            {
                FillSeatColor(pannelFlightB);
            }
        }

        private void btnChangeSeat_Click(object sender, EventArgs e)
        {
            if (cbPassenger.SelectedIndex>-1)
            {
                if (flight == 1)
                {
                    IEnumerator enumerator = pannelFlightA.Controls.GetEnumerator();

                    Label label = (Label)enumerator.Current;
                    string first, last;
                    string fullname = cbPassenger.SelectedText;
                    string[] name1 = fullname.Split(' ');
                    first = name1[0];
                    last = name1[1];

                    // takes the first name and last name and gets passenger ID in order to delete passenger
                    int passID;
                    passID = (int)db.GetPassengerID(first, last);
                    string seat = label.Text;
                    int seat2 = Int32.Parse(seat);
                    db.UpdateSeatNum(flight, seat2, passID);
                    
                }
                else
                {
                    IEnumerator enumerator = pannelFlightB.Controls.GetEnumerator();

                    Label label = (Label)enumerator.Current;
                    string first, last;
                    string fullname = cbPassenger.SelectedText;
                    string[] name1 = fullname.Split(' ');
                    first = name1[0];
                    last = name1[1];

                    // takes the first name and last name and gets passenger ID in order to delete passenger
                    int passID;
                    passID = (int)db.GetPassengerID(first, last);
                    string seat = label.Text;
                    int seat2 = Int32.Parse(seat);
                    db.UpdateSeatNum(flight, seat2, passID);
                }
            }
        }
    }
}
