namespace Assignment_6_Part_1
{
    partial class frmAirlineReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxPassengerInformation = new System.Windows.Forms.GroupBox();
            this.cbPassenger = new System.Windows.Forms.ComboBox();
            this.cbFlight = new System.Windows.Forms.ComboBox();
            this.lblPassengerSeat = new System.Windows.Forms.Label();
            this.lblChooseFlight = new System.Windows.Forms.Label();
            this.lblChoosePassenger = new System.Windows.Forms.Label();
            this.grpboxColorKey = new System.Windows.Forms.GroupBox();
            this.lblSeatChosen = new System.Windows.Forms.Label();
            this.lblSeatEmpty = new System.Windows.Forms.Label();
            this.lblSeatTaken = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.btnChangeSeat = new System.Windows.Forms.Button();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.btnDeletePassenger = new System.Windows.Forms.Button();
            this.pannelFlightA = new System.Windows.Forms.Panel();
            this.lblFlightA = new System.Windows.Forms.Label();
            this.lblSeat24 = new System.Windows.Forms.Label();
            this.lblSeat23 = new System.Windows.Forms.Label();
            this.lblSeat22 = new System.Windows.Forms.Label();
            this.lblSeat21 = new System.Windows.Forms.Label();
            this.lblSeat20 = new System.Windows.Forms.Label();
            this.lblSeat19 = new System.Windows.Forms.Label();
            this.lblSeat18 = new System.Windows.Forms.Label();
            this.lblSeat17 = new System.Windows.Forms.Label();
            this.lblSeat16 = new System.Windows.Forms.Label();
            this.lblSeat15 = new System.Windows.Forms.Label();
            this.lblSeat14 = new System.Windows.Forms.Label();
            this.lblSeat13 = new System.Windows.Forms.Label();
            this.lblSeat8 = new System.Windows.Forms.Label();
            this.lblSeat7 = new System.Windows.Forms.Label();
            this.lblSeat6 = new System.Windows.Forms.Label();
            this.lblSeat5 = new System.Windows.Forms.Label();
            this.lblSeat4 = new System.Windows.Forms.Label();
            this.lblSeat3 = new System.Windows.Forms.Label();
            this.lblSeat2 = new System.Windows.Forms.Label();
            this.lblSeat1 = new System.Windows.Forms.Label();
            this.pannelFlightB = new System.Windows.Forms.Panel();
            this.lblFlightB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.TakenseatNum = new System.Windows.Forms.ComboBox();
            this.grpboxPassengerInformation.SuspendLayout();
            this.grpboxColorKey.SuspendLayout();
            this.pannelFlightA.SuspendLayout();
            this.pannelFlightB.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxPassengerInformation
            // 
            this.grpboxPassengerInformation.Controls.Add(this.cbPassenger);
            this.grpboxPassengerInformation.Controls.Add(this.cbFlight);
            this.grpboxPassengerInformation.Controls.Add(this.lblPassengerSeat);
            this.grpboxPassengerInformation.Controls.Add(this.lblChooseFlight);
            this.grpboxPassengerInformation.Controls.Add(this.lblChoosePassenger);
            this.grpboxPassengerInformation.Location = new System.Drawing.Point(486, 34);
            this.grpboxPassengerInformation.Name = "grpboxPassengerInformation";
            this.grpboxPassengerInformation.Size = new System.Drawing.Size(412, 148);
            this.grpboxPassengerInformation.TabIndex = 0;
            this.grpboxPassengerInformation.TabStop = false;
            this.grpboxPassengerInformation.Text = "Passenger Information";
            // 
            // cbPassenger
            // 
            this.cbPassenger.Enabled = false;
            this.cbPassenger.FormattingEnabled = true;
            this.cbPassenger.Location = new System.Drawing.Point(223, 59);
            this.cbPassenger.Name = "cbPassenger";
            this.cbPassenger.Size = new System.Drawing.Size(162, 21);
            this.cbPassenger.TabIndex = 4;
            // 
            // cbFlight
            // 
            this.cbFlight.FormattingEnabled = true;
            this.cbFlight.Location = new System.Drawing.Point(223, 18);
            this.cbFlight.Name = "cbFlight";
            this.cbFlight.Size = new System.Drawing.Size(162, 21);
            this.cbFlight.TabIndex = 3;
            this.cbFlight.SelectedIndexChanged += new System.EventHandler(this.cbFlight_SelectedIndexChanged);
            // 
            // lblPassengerSeat
            // 
            this.lblPassengerSeat.AutoSize = true;
            this.lblPassengerSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerSeat.Location = new System.Drawing.Point(29, 102);
            this.lblPassengerSeat.Name = "lblPassengerSeat";
            this.lblPassengerSeat.Size = new System.Drawing.Size(142, 20);
            this.lblPassengerSeat.TabIndex = 2;
            this.lblPassengerSeat.Text = "Passenger Seat:";
            // 
            // lblChooseFlight
            // 
            this.lblChooseFlight.AutoSize = true;
            this.lblChooseFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFlight.Location = new System.Drawing.Point(29, 16);
            this.lblChooseFlight.Name = "lblChooseFlight";
            this.lblChooseFlight.Size = new System.Drawing.Size(125, 20);
            this.lblChooseFlight.TabIndex = 1;
            this.lblChooseFlight.Text = "Choose Flight:";
            // 
            // lblChoosePassenger
            // 
            this.lblChoosePassenger.AutoSize = true;
            this.lblChoosePassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoosePassenger.Location = new System.Drawing.Point(29, 57);
            this.lblChoosePassenger.Name = "lblChoosePassenger";
            this.lblChoosePassenger.Size = new System.Drawing.Size(165, 20);
            this.lblChoosePassenger.TabIndex = 0;
            this.lblChoosePassenger.Text = "Choose Passenger:";
            // 
            // grpboxColorKey
            // 
            this.grpboxColorKey.Controls.Add(this.lblSeatChosen);
            this.grpboxColorKey.Controls.Add(this.lblSeatEmpty);
            this.grpboxColorKey.Controls.Add(this.lblSeatTaken);
            this.grpboxColorKey.Controls.Add(this.lblGreen);
            this.grpboxColorKey.Controls.Add(this.lblBlue);
            this.grpboxColorKey.Controls.Add(this.lblRed);
            this.grpboxColorKey.Location = new System.Drawing.Point(486, 365);
            this.grpboxColorKey.Name = "grpboxColorKey";
            this.grpboxColorKey.Size = new System.Drawing.Size(412, 288);
            this.grpboxColorKey.TabIndex = 1;
            this.grpboxColorKey.TabStop = false;
            this.grpboxColorKey.Text = "Color Key";
            // 
            // lblSeatChosen
            // 
            this.lblSeatChosen.AutoSize = true;
            this.lblSeatChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatChosen.Location = new System.Drawing.Point(124, 239);
            this.lblSeatChosen.Name = "lblSeatChosen";
            this.lblSeatChosen.Size = new System.Drawing.Size(240, 24);
            this.lblSeatChosen.TabIndex = 5;
            this.lblSeatChosen.Text = "Selected passenger seat";
            this.lblSeatChosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeatEmpty
            // 
            this.lblSeatEmpty.AutoSize = true;
            this.lblSeatEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatEmpty.Location = new System.Drawing.Point(124, 142);
            this.lblSeatEmpty.Name = "lblSeatEmpty";
            this.lblSeatEmpty.Size = new System.Drawing.Size(134, 24);
            this.lblSeatEmpty.TabIndex = 4;
            this.lblSeatEmpty.Text = "Seat is empty";
            this.lblSeatEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeatTaken
            // 
            this.lblSeatTaken.AutoSize = true;
            this.lblSeatTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatTaken.Location = new System.Drawing.Point(124, 49);
            this.lblSeatTaken.Name = "lblSeatTaken";
            this.lblSeatTaken.Size = new System.Drawing.Size(128, 24);
            this.lblSeatTaken.TabIndex = 3;
            this.lblSeatTaken.Text = "Seat is taken";
            this.lblSeatTaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(30, 218);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(55, 60);
            this.lblGreen.TabIndex = 2;
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(30, 123);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(55, 60);
            this.lblBlue.TabIndex = 1;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(30, 33);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(55, 60);
            this.lblRed.TabIndex = 0;
            // 
            // btnChangeSeat
            // 
            this.btnChangeSeat.AutoSize = true;
            this.btnChangeSeat.Enabled = false;
            this.btnChangeSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSeat.Location = new System.Drawing.Point(519, 217);
            this.btnChangeSeat.Name = "btnChangeSeat";
            this.btnChangeSeat.Size = new System.Drawing.Size(124, 30);
            this.btnChangeSeat.TabIndex = 2;
            this.btnChangeSeat.Text = "Change Seat";
            this.btnChangeSeat.UseVisualStyleBackColor = true;
            this.btnChangeSeat.Click += new System.EventHandler(this.btnChangeSeat_Click);
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.AutoSize = true;
            this.btnAddPassenger.Enabled = false;
            this.btnAddPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPassenger.Location = new System.Drawing.Point(519, 297);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(141, 30);
            this.btnAddPassenger.TabIndex = 3;
            this.btnAddPassenger.Text = "Add Passenger";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // btnDeletePassenger
            // 
            this.btnDeletePassenger.AutoSize = true;
            this.btnDeletePassenger.Enabled = false;
            this.btnDeletePassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePassenger.Location = new System.Drawing.Point(709, 297);
            this.btnDeletePassenger.Name = "btnDeletePassenger";
            this.btnDeletePassenger.Size = new System.Drawing.Size(162, 30);
            this.btnDeletePassenger.TabIndex = 4;
            this.btnDeletePassenger.Text = "Delete Passenger";
            this.btnDeletePassenger.UseVisualStyleBackColor = true;
            this.btnDeletePassenger.Click += new System.EventHandler(this.btnDeletePassenger_Click);
            // 
            // pannelFlightA
            // 
            this.pannelFlightA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pannelFlightA.Controls.Add(this.lblFlightA);
            this.pannelFlightA.Controls.Add(this.lblSeat24);
            this.pannelFlightA.Controls.Add(this.lblSeat23);
            this.pannelFlightA.Controls.Add(this.lblSeat22);
            this.pannelFlightA.Controls.Add(this.lblSeat21);
            this.pannelFlightA.Controls.Add(this.lblSeat20);
            this.pannelFlightA.Controls.Add(this.lblSeat19);
            this.pannelFlightA.Controls.Add(this.lblSeat18);
            this.pannelFlightA.Controls.Add(this.lblSeat17);
            this.pannelFlightA.Controls.Add(this.lblSeat16);
            this.pannelFlightA.Controls.Add(this.lblSeat15);
            this.pannelFlightA.Controls.Add(this.lblSeat14);
            this.pannelFlightA.Controls.Add(this.lblSeat13);
            this.pannelFlightA.Controls.Add(this.lblSeat8);
            this.pannelFlightA.Controls.Add(this.lblSeat7);
            this.pannelFlightA.Controls.Add(this.lblSeat6);
            this.pannelFlightA.Controls.Add(this.lblSeat5);
            this.pannelFlightA.Controls.Add(this.lblSeat4);
            this.pannelFlightA.Controls.Add(this.lblSeat3);
            this.pannelFlightA.Controls.Add(this.lblSeat2);
            this.pannelFlightA.Controls.Add(this.lblSeat1);
            this.pannelFlightA.Enabled = false;
            this.pannelFlightA.Location = new System.Drawing.Point(30, 34);
            this.pannelFlightA.Name = "pannelFlightA";
            this.pannelFlightA.Size = new System.Drawing.Size(441, 497);
            this.pannelFlightA.TabIndex = 5;
            this.pannelFlightA.Visible = false;
            // 
            // lblFlightA
            // 
            this.lblFlightA.AutoSize = true;
            this.lblFlightA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightA.Location = new System.Drawing.Point(151, 0);
            this.lblFlightA.Name = "lblFlightA";
            this.lblFlightA.Size = new System.Drawing.Size(107, 20);
            this.lblFlightA.TabIndex = 26;
            this.lblFlightA.Text = "Airbus A380";
            // 
            // lblSeat24
            // 
            this.lblSeat24.BackColor = System.Drawing.Color.Blue;
            this.lblSeat24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat24.Location = new System.Drawing.Point(306, 408);
            this.lblSeat24.Name = "lblSeat24";
            this.lblSeat24.Size = new System.Drawing.Size(58, 60);
            this.lblSeat24.TabIndex = 24;
            this.lblSeat24.Text = "20";
            this.lblSeat24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat24.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat23
            // 
            this.lblSeat23.BackColor = System.Drawing.Color.Blue;
            this.lblSeat23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat23.Location = new System.Drawing.Point(242, 408);
            this.lblSeat23.Name = "lblSeat23";
            this.lblSeat23.Size = new System.Drawing.Size(58, 60);
            this.lblSeat23.TabIndex = 23;
            this.lblSeat23.Text = "19";
            this.lblSeat23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat23.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat22
            // 
            this.lblSeat22.BackColor = System.Drawing.Color.Blue;
            this.lblSeat22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat22.Location = new System.Drawing.Point(178, 408);
            this.lblSeat22.Name = "lblSeat22";
            this.lblSeat22.Size = new System.Drawing.Size(58, 60);
            this.lblSeat22.TabIndex = 22;
            this.lblSeat22.Text = "18";
            this.lblSeat22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat22.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat21
            // 
            this.lblSeat21.BackColor = System.Drawing.Color.Blue;
            this.lblSeat21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat21.Location = new System.Drawing.Point(39, 408);
            this.lblSeat21.Name = "lblSeat21";
            this.lblSeat21.Size = new System.Drawing.Size(58, 60);
            this.lblSeat21.TabIndex = 21;
            this.lblSeat21.Text = "17";
            this.lblSeat21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat21.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat20
            // 
            this.lblSeat20.BackColor = System.Drawing.Color.Blue;
            this.lblSeat20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat20.Location = new System.Drawing.Point(306, 338);
            this.lblSeat20.Name = "lblSeat20";
            this.lblSeat20.Size = new System.Drawing.Size(58, 60);
            this.lblSeat20.TabIndex = 20;
            this.lblSeat20.Text = "16";
            this.lblSeat20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat20.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat19
            // 
            this.lblSeat19.BackColor = System.Drawing.Color.Blue;
            this.lblSeat19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat19.Location = new System.Drawing.Point(242, 338);
            this.lblSeat19.Name = "lblSeat19";
            this.lblSeat19.Size = new System.Drawing.Size(58, 60);
            this.lblSeat19.TabIndex = 19;
            this.lblSeat19.Text = "15";
            this.lblSeat19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat19.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat18
            // 
            this.lblSeat18.BackColor = System.Drawing.Color.Blue;
            this.lblSeat18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat18.Location = new System.Drawing.Point(178, 338);
            this.lblSeat18.Name = "lblSeat18";
            this.lblSeat18.Size = new System.Drawing.Size(58, 60);
            this.lblSeat18.TabIndex = 18;
            this.lblSeat18.Text = "14";
            this.lblSeat18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat18.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat17
            // 
            this.lblSeat17.BackColor = System.Drawing.Color.Blue;
            this.lblSeat17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat17.Location = new System.Drawing.Point(39, 338);
            this.lblSeat17.Name = "lblSeat17";
            this.lblSeat17.Size = new System.Drawing.Size(58, 60);
            this.lblSeat17.TabIndex = 17;
            this.lblSeat17.Text = "13";
            this.lblSeat17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat17.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat16
            // 
            this.lblSeat16.BackColor = System.Drawing.Color.Blue;
            this.lblSeat16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat16.Location = new System.Drawing.Point(306, 261);
            this.lblSeat16.Name = "lblSeat16";
            this.lblSeat16.Size = new System.Drawing.Size(58, 60);
            this.lblSeat16.TabIndex = 16;
            this.lblSeat16.Text = "12";
            this.lblSeat16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat16.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat15
            // 
            this.lblSeat15.BackColor = System.Drawing.Color.Blue;
            this.lblSeat15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat15.Location = new System.Drawing.Point(242, 261);
            this.lblSeat15.Name = "lblSeat15";
            this.lblSeat15.Size = new System.Drawing.Size(58, 60);
            this.lblSeat15.TabIndex = 15;
            this.lblSeat15.Text = "11";
            this.lblSeat15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat15.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat14
            // 
            this.lblSeat14.BackColor = System.Drawing.Color.Blue;
            this.lblSeat14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat14.Location = new System.Drawing.Point(178, 263);
            this.lblSeat14.Name = "lblSeat14";
            this.lblSeat14.Size = new System.Drawing.Size(58, 60);
            this.lblSeat14.TabIndex = 14;
            this.lblSeat14.Text = "10";
            this.lblSeat14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat14.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat13
            // 
            this.lblSeat13.BackColor = System.Drawing.Color.Blue;
            this.lblSeat13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat13.Location = new System.Drawing.Point(39, 263);
            this.lblSeat13.Name = "lblSeat13";
            this.lblSeat13.Size = new System.Drawing.Size(58, 60);
            this.lblSeat13.TabIndex = 13;
            this.lblSeat13.Text = "9";
            this.lblSeat13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat13.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat8
            // 
            this.lblSeat8.BackColor = System.Drawing.Color.Blue;
            this.lblSeat8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat8.Location = new System.Drawing.Point(306, 113);
            this.lblSeat8.Name = "lblSeat8";
            this.lblSeat8.Size = new System.Drawing.Size(58, 60);
            this.lblSeat8.TabIndex = 7;
            this.lblSeat8.Text = "8";
            this.lblSeat8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat8.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat7
            // 
            this.lblSeat7.BackColor = System.Drawing.Color.Blue;
            this.lblSeat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat7.Location = new System.Drawing.Point(242, 113);
            this.lblSeat7.Name = "lblSeat7";
            this.lblSeat7.Size = new System.Drawing.Size(58, 60);
            this.lblSeat7.TabIndex = 6;
            this.lblSeat7.Text = "7";
            this.lblSeat7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat7.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat6
            // 
            this.lblSeat6.BackColor = System.Drawing.Color.Blue;
            this.lblSeat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat6.Location = new System.Drawing.Point(178, 113);
            this.lblSeat6.Name = "lblSeat6";
            this.lblSeat6.Size = new System.Drawing.Size(58, 60);
            this.lblSeat6.TabIndex = 5;
            this.lblSeat6.Text = "6";
            this.lblSeat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat6.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat5
            // 
            this.lblSeat5.BackColor = System.Drawing.Color.Blue;
            this.lblSeat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat5.Location = new System.Drawing.Point(39, 113);
            this.lblSeat5.Name = "lblSeat5";
            this.lblSeat5.Size = new System.Drawing.Size(58, 60);
            this.lblSeat5.TabIndex = 4;
            this.lblSeat5.Text = "5";
            this.lblSeat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat5.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat4
            // 
            this.lblSeat4.BackColor = System.Drawing.Color.Blue;
            this.lblSeat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat4.Location = new System.Drawing.Point(306, 36);
            this.lblSeat4.Name = "lblSeat4";
            this.lblSeat4.Size = new System.Drawing.Size(58, 60);
            this.lblSeat4.TabIndex = 3;
            this.lblSeat4.Text = "4";
            this.lblSeat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat4.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat3
            // 
            this.lblSeat3.BackColor = System.Drawing.Color.Blue;
            this.lblSeat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat3.Location = new System.Drawing.Point(242, 36);
            this.lblSeat3.Name = "lblSeat3";
            this.lblSeat3.Size = new System.Drawing.Size(58, 60);
            this.lblSeat3.TabIndex = 2;
            this.lblSeat3.Text = "3";
            this.lblSeat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat3.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat2
            // 
            this.lblSeat2.BackColor = System.Drawing.Color.Blue;
            this.lblSeat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat2.Location = new System.Drawing.Point(178, 36);
            this.lblSeat2.Name = "lblSeat2";
            this.lblSeat2.Size = new System.Drawing.Size(58, 60);
            this.lblSeat2.TabIndex = 1;
            this.lblSeat2.Text = "2";
            this.lblSeat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat2.Click += new System.EventHandler(this.Seat_Click);
            // 
            // lblSeat1
            // 
            this.lblSeat1.BackColor = System.Drawing.Color.Blue;
            this.lblSeat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeat1.Location = new System.Drawing.Point(39, 38);
            this.lblSeat1.Name = "lblSeat1";
            this.lblSeat1.Size = new System.Drawing.Size(58, 60);
            this.lblSeat1.TabIndex = 0;
            this.lblSeat1.Text = "1";
            this.lblSeat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeat1.Click += new System.EventHandler(this.Seat_Click);
            // 
            // pannelFlightB
            // 
            this.pannelFlightB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pannelFlightB.Controls.Add(this.lblFlightB);
            this.pannelFlightB.Controls.Add(this.label1);
            this.pannelFlightB.Controls.Add(this.label2);
            this.pannelFlightB.Controls.Add(this.label3);
            this.pannelFlightB.Controls.Add(this.label4);
            this.pannelFlightB.Controls.Add(this.label5);
            this.pannelFlightB.Controls.Add(this.label6);
            this.pannelFlightB.Controls.Add(this.label7);
            this.pannelFlightB.Controls.Add(this.label8);
            this.pannelFlightB.Controls.Add(this.label9);
            this.pannelFlightB.Controls.Add(this.label10);
            this.pannelFlightB.Controls.Add(this.label11);
            this.pannelFlightB.Controls.Add(this.label12);
            this.pannelFlightB.Controls.Add(this.label13);
            this.pannelFlightB.Controls.Add(this.label14);
            this.pannelFlightB.Controls.Add(this.label15);
            this.pannelFlightB.Controls.Add(this.label16);
            this.pannelFlightB.Controls.Add(this.label17);
            this.pannelFlightB.Controls.Add(this.label18);
            this.pannelFlightB.Controls.Add(this.label19);
            this.pannelFlightB.Controls.Add(this.label20);
            this.pannelFlightB.Controls.Add(this.label21);
            this.pannelFlightB.Controls.Add(this.label22);
            this.pannelFlightB.Controls.Add(this.label23);
            this.pannelFlightB.Controls.Add(this.label24);
            this.pannelFlightB.Enabled = false;
            this.pannelFlightB.Location = new System.Drawing.Point(30, 34);
            this.pannelFlightB.Name = "pannelFlightB";
            this.pannelFlightB.Size = new System.Drawing.Size(441, 497);
            this.pannelFlightB.TabIndex = 6;
            this.pannelFlightB.Visible = false;
            // 
            // lblFlightB
            // 
            this.lblFlightB.AutoSize = true;
            this.lblFlightB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightB.Location = new System.Drawing.Point(151, 16);
            this.lblFlightB.Name = "lblFlightB";
            this.lblFlightB.Size = new System.Drawing.Size(100, 20);
            this.lblFlightB.TabIndex = 25;
            this.lblFlightB.Text = "Boeing 767";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(306, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 60);
            this.label1.TabIndex = 24;
            this.label1.Text = "24";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(242, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 60);
            this.label2.TabIndex = 23;
            this.label2.Text = "23";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(103, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 60);
            this.label3.TabIndex = 22;
            this.label3.Text = "22";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 60);
            this.label4.TabIndex = 21;
            this.label4.Text = "21";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(306, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 60);
            this.label5.TabIndex = 20;
            this.label5.Text = "20";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(242, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 60);
            this.label6.TabIndex = 19;
            this.label6.Text = "19";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(103, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 60);
            this.label7.TabIndex = 18;
            this.label7.Text = "18";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(39, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 60);
            this.label8.TabIndex = 17;
            this.label8.Text = "17";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(306, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 60);
            this.label9.TabIndex = 16;
            this.label9.Text = "16";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Blue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(242, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 60);
            this.label10.TabIndex = 15;
            this.label10.Text = "15";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Blue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(103, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 60);
            this.label11.TabIndex = 14;
            this.label11.Text = "14";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Blue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(39, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 60);
            this.label12.TabIndex = 13;
            this.label12.Text = "13";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Blue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(306, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 60);
            this.label13.TabIndex = 12;
            this.label13.Text = "12";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Blue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(242, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 60);
            this.label14.TabIndex = 11;
            this.label14.Text = "11";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Blue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(103, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 60);
            this.label15.TabIndex = 10;
            this.label15.Text = "10";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Blue;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(39, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 60);
            this.label16.TabIndex = 9;
            this.label16.Text = "9";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Blue;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(306, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 60);
            this.label17.TabIndex = 7;
            this.label17.Text = "8";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Blue;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(242, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 60);
            this.label18.TabIndex = 6;
            this.label18.Text = "7";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Blue;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(103, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 60);
            this.label19.TabIndex = 5;
            this.label19.Text = "6";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Blue;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(39, 113);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 60);
            this.label20.TabIndex = 4;
            this.label20.Text = "5";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Blue;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(306, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 60);
            this.label21.TabIndex = 3;
            this.label21.Text = "4";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Blue;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(242, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 60);
            this.label22.TabIndex = 2;
            this.label22.Text = "3";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Blue;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(103, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 60);
            this.label23.TabIndex = 1;
            this.label23.Text = "2";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Click += new System.EventHandler(this.Seat_Click);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Blue;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(39, 38);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 60);
            this.label24.TabIndex = 0;
            this.label24.Text = "1";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Click += new System.EventHandler(this.Seat_Click);
            // 
            // TakenseatNum
            // 
            this.TakenseatNum.FormattingEnabled = true;
            this.TakenseatNum.Location = new System.Drawing.Point(826, 188);
            this.TakenseatNum.Name = "TakenseatNum";
            this.TakenseatNum.Size = new System.Drawing.Size(45, 21);
            this.TakenseatNum.TabIndex = 7;
            this.TakenseatNum.Visible = false;
            // 
            // frmAirlineReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 665);
            this.Controls.Add(this.TakenseatNum);
            this.Controls.Add(this.pannelFlightA);
            this.Controls.Add(this.pannelFlightB);
            this.Controls.Add(this.btnDeletePassenger);
            this.Controls.Add(this.btnAddPassenger);
            this.Controls.Add(this.btnChangeSeat);
            this.Controls.Add(this.grpboxColorKey);
            this.Controls.Add(this.grpboxPassengerInformation);
            this.Name = "frmAirlineReservation";
            this.Text = "Airline Reservation System";
            this.grpboxPassengerInformation.ResumeLayout(false);
            this.grpboxPassengerInformation.PerformLayout();
            this.grpboxColorKey.ResumeLayout(false);
            this.grpboxColorKey.PerformLayout();
            this.pannelFlightA.ResumeLayout(false);
            this.pannelFlightA.PerformLayout();
            this.pannelFlightB.ResumeLayout(false);
            this.pannelFlightB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxPassengerInformation;
        private System.Windows.Forms.ComboBox cbFlight;
        private System.Windows.Forms.Label lblPassengerSeat;
        private System.Windows.Forms.Label lblChooseFlight;
        private System.Windows.Forms.Label lblChoosePassenger;
        private System.Windows.Forms.GroupBox grpboxColorKey;
        private System.Windows.Forms.Label lblSeatChosen;
        private System.Windows.Forms.Label lblSeatEmpty;
        private System.Windows.Forms.Label lblSeatTaken;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnChangeSeat;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Button btnDeletePassenger;
        private System.Windows.Forms.ComboBox cbPassenger;
        private System.Windows.Forms.Panel pannelFlightA;
        private System.Windows.Forms.Label lblSeat24;
        private System.Windows.Forms.Label lblSeat23;
        private System.Windows.Forms.Label lblSeat22;
        private System.Windows.Forms.Label lblSeat21;
        private System.Windows.Forms.Label lblSeat20;
        private System.Windows.Forms.Label lblSeat19;
        private System.Windows.Forms.Label lblSeat18;
        private System.Windows.Forms.Label lblSeat17;
        private System.Windows.Forms.Label lblSeat16;
        private System.Windows.Forms.Label lblSeat15;
        private System.Windows.Forms.Label lblSeat14;
        private System.Windows.Forms.Label lblSeat13;
        private System.Windows.Forms.Label lblSeat8;
        private System.Windows.Forms.Label lblSeat7;
        private System.Windows.Forms.Label lblSeat6;
        private System.Windows.Forms.Label lblSeat5;
        private System.Windows.Forms.Label lblSeat4;
        private System.Windows.Forms.Label lblSeat3;
        private System.Windows.Forms.Label lblSeat2;
        private System.Windows.Forms.Label lblSeat1;
        private System.Windows.Forms.Label lblFlightA;
        private System.Windows.Forms.Panel pannelFlightB;
        private System.Windows.Forms.Label lblFlightB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox TakenseatNum;
    }
}

