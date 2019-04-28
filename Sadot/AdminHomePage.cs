/*
 * AdminHomePage form code
 * class with the code of the form of admin control panel the main form of the admin to manage evrtything
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class AdminHomePage : Form
    {
        private LoginPage login;
        private DBSQL db = new DBSQL();
        private RestaurantStatus restaurantStatus;
        private OrdersTracking ordersTracking;
        private StockReports stockReports;
        private Event newEvent;
        private Event[] eventsToDay;

        /// <summary>
        /// form constractor
        /// </summary>
        public AdminHomePage(LoginPage loginPage)
        {
            InitializeComponent();
            login = loginPage;
        }

        /// <summary>
        /// method wich works when AdminHomePage form load
        /// </summary>
        private void AdminHomePageTest_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurantPic.BackColor = Color.White;
            btnRestaurantPic.ForeColor = Color.Black;

            //set the users controls to the center of tabs
            restaurantStatus = new RestaurantStatus();
            restaurantStatus.Location = new Point(tpResturantStatus.Width / 2 - restaurantStatus.Width / 2, tpResturantStatus.Height / 2 - restaurantStatus.Height / 2);
            restaurantStatus.Anchor = AnchorStyles.None;

            ordersTracking = new OrdersTracking();
            ordersTracking.Location = new Point(tpResturantStatus.Width / 2 - ordersTracking.Width / 2, tpResturantStatus.Height / 2 - ordersTracking.Height / 2);
            ordersTracking.Anchor = AnchorStyles.None;

            stockReports = new StockReports();
            stockReports.Location = new Point(tpResturantStatus.Width / 2 - stockReports.Width / 2, tpResturantStatus.Height / 2 - stockReports.Height / 2);
            stockReports.Anchor = AnchorStyles.None;

            tpResturantStatus.Controls.Add(restaurantStatus);
            tpOrdersTracking.Controls.Add(ordersTracking);
            tpStockReports.Controls.Add(stockReports);
            //set dates of the month calendar
            monthCalendar.MinDate = DateTime.Today;
            dtpEventDate.MinDate = DateTime.Today;
            monthCalendar.SetDate(DateTime.Now);
        }

        #region  Functions **Button - btn___**

        /*----------------------------right side bar buttons----------------------------*/

        /// <summary>
        /// method wich works when the user press on the right side bar button "resturant picture"
        /// the method will make the correct button as pressed and the others as realsed
        /// and move to the correct tab page
        /// </summary>
        private void btnRestaurantPic_Click(object sender, EventArgs e)
        {
            SetAllSideBarButtonsToRelese();
            SetButtonAsPressed((Button)sender);
            tcMain.SelectedTab = tpResturantStatus;
        }

        /// <summary>
        /// method wich works when the user press on the right side bar button "orders tracking"
        /// the method will make the correct button as pressed and the others as realsed
        /// and move to the correct tab page
        /// </summary>
        private void btnOrdersTracking_Click(object sender, EventArgs e)
        {
            SetAllSideBarButtonsToRelese();
            SetButtonAsPressed((Button)sender);
            tcMain.SelectedTab = tpOrdersTracking;
        }

        /// <summary>
        /// method wich works when the user press on the right side bar button "stock reports"
        /// the method will make the correct button as pressed and the others as realsed
        /// and move to the correct tab page
        /// </summary>
        private void btnStockReports_Click(object sender, EventArgs e)
        {
            SetAllSideBarButtonsToRelese();
            SetButtonAsPressed((Button)sender);
            tcMain.SelectedTab = tpStockReports;

        }

        /// <summary>
        /// method wich works when the user press on the right side bar button "events"
        /// the method will make the correct button as pressed and the others as realsed
        /// and move to the correct tab page
        /// </summary>
        private void btnEvents_Click(object sender, EventArgs e)
        {
            SetAllSideBarButtonsToRelese();
            SetButtonAsPressed((Button)sender);
            tcMain.SelectedTab = tpEvnets;
            btnEditEvent.Visible = true;
            CleanFields();
        }

        /// <summary>
        /// method to set the spcific right side bar button color to pressed
        /// </summary>
        /// <param name="btn">the button to change his color</param>
        public void SetButtonAsPressed(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        /// <summary>
        /// method to set all right sidebar buttons color to relese
        /// </summary>
        public void SetAllSideBarButtonsToRelese()
        {
            btnRestaurantPic.BackColor = Color.Black;
            btnRestaurantPic.ForeColor = Color.White;

            btnOrdersTracking.BackColor = Color.Black;
            btnOrdersTracking.ForeColor = Color.White;

            btnEvents.BackColor = Color.Black;
            btnEvents.ForeColor = Color.White;

            btnStockReports.BackColor = Color.Black;
            btnStockReports.ForeColor = Color.White;
        }

        /*----------------------------upward navbar buttons----------------------------*/

        /// <summary>
        /// method wich works when the user press on the upward navbar button "manage dish"
        /// the method will open the correct form
        /// </summary>
        private void btnManageDish_Click(object sender, EventArgs e)
        {
            ManageDishPage adminManageDishPageTest = new ManageDishPage();
            adminManageDishPageTest.ShowDialog();
        }

        /// <summary>
        /// method wich works when the user press on the upward navbar button "manage products"
        /// the method will open the correct form
        /// </summary>
        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct adminManageProduct = new ManageProduct();
            adminManageProduct.ShowDialog();
        }

        /// <summary>
        /// method wich works when the user press on the upward navbar button "manage wine"
        /// the method will open the correct form
        /// </summary>
        private void btnManageWine_Click(object sender, EventArgs e)
        {
            ManageWine adminManageWine = new ManageWine();
            adminManageWine.ShowDialog();
        }

        /// <summary>
        /// method wich works when the user press on the upward navbar button "manage customers"
        /// the method will open the correct form
        /// </summary>
        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.ShowDialog();
        }

        /// <summary>
        /// method wich works when the user press on the upward navbar button "exit"
        /// the method close the admin panel and open the login form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        /// <summary>
        /// method wich works when the user press on the upward navbar button "manage users"
        /// the method will open the correct form
        /// </summary>
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers newUser = new ManageUsers();
            newUser.ShowDialog();
        }

        /// <summary>
        /// method wich works when the user press on the upward navbar button "manage employees"
        /// the method will open the correct form
        /// </summary>
        private void btnManageWorkers_Click(object sender, EventArgs e)
        {
            ManageEmployees manageEmployees = new ManageEmployees();
            manageEmployees.ShowDialog();
        }
        
        #endregion


        #region  Functions **events**
        /// <summary>
        /// function to clean all the fields of events tabPage
        /// </summary>
        public void CleanFields()
        {
            txtOwnerFname.Text = string.Empty;
            txtOwnerLname.Text = string.Empty;
            txtOwnerPhone.Text = string.Empty;
            txtOwnerMail.Text = string.Empty;
            txtEventType.Text = string.Empty;
            dtpEventDate.Value = DateTime.Today;
            dtpEventTime.Value = DateTime.Today;
            txtEventParticipants.Text = string.Empty;
            txtEventNotes.Text = string.Empty;
            btnUpdateEvent.Enabled = false;
            btnAddEvent.Enabled = true;
            dgvExistEventDetails.Visible = false;
        }

        /// <summary>
        /// methos wich works when the user pressed on clean fields button the method will call the function CleanFields
        /// </summary>
        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            CleanFields();
            MessageBox.Show("השדות נוקו בהצלחה!");
        }

        /// <summary>
        /// method to check if the user put correct input in the event fields
        /// </summary>
        /// <returns>
        /// res = true - all inputs correct
        /// res = false - one or more from the inputs is incorrect
        /// </returns>
        public bool inputChecks()
        {
            bool res = true;
            if (Checks.IsEmptyString(txtOwnerFname.Text) || Checks.IsEmptyString(txtOwnerLname.Text)
                || Checks.IsEmptyString(txtOwnerPhone.Text) || Checks.IsEmptyString(txtOwnerMail.Text) ||
                Checks.IsEmptyString(txtEventType.Text) || Checks.IsEmptyString(txtEventParticipants.Text))
            {
                MessageBox.Show("אחד או יותר מהשדות ריקים, אנא הכנס את כל השדות");
                res = false;
            }
            else
            {
                if (!Checks.IsValidEmail(txtOwnerMail.Text))
                {
                    MessageBox.Show("מייל לא תקין!");
                    res = false;
                }
                else if (!Checks.IsValidPhone(txtOwnerPhone.Text))
                {
                    MessageBox.Show("טלפון לא תקין!");
                    res = false;
                }
                else if (!Checks.IsValidPhone(txtEventParticipants.Text))
                {
                    MessageBox.Show("השדה מספר משתפפים יכול להכיל רק מספרים!");
                    res = false;
                }
                else if (int.Parse(txtEventParticipants.Text) < 1)
                {
                    MessageBox.Show("מספר המשתתפים חייב להיות גדול מ 0!");
                    res = false;
                }
                else if (dtpEventTime.Text == "00:00:00")
                {
                    MessageBox.Show("הכנס שעת האירוע!");
                    res = false;
                }
            }
            return res;
        }

        /// <summary>
        /// method wich works when the user press on "add event" button
        /// the method will check the inputs and insert the new event to data base
        /// </summary>
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (inputChecks())
            {
                newEvent = new Event();
                FillEventObjectWithDetails();
                db.InsertNewEvent(newEvent);
                MessageBox.Show("האירוע נשמר בהצלה!");
                monthCalendar.SetDate(DateTime.Now);
                CleanFields();
            }
        }

        /// <summary>
        /// method wich fill the event object with the details from fields
        /// </summary>
        private void FillEventObjectWithDetails()
        {
            newEvent.OwnerFname = txtOwnerFname.Text;
            newEvent.OwnerLname = txtOwnerLname.Text;
            newEvent.OwnerPhone = txtOwnerPhone.Text;
            newEvent.OwnerEmail = txtOwnerMail.Text;
            newEvent.EventType = txtEventType.Text;
            newEvent.EventDate = dtpEventDate.Value;
            newEvent.EventTime = dtpEventTime.Value;
            newEvent.NumOfParticipants = int.Parse(txtEventParticipants.Text);
            newEvent.EventNotes = txtEventNotes.Text;
        }

        /// <summary>
        /// method wich works when the user change date in the right date calendar
        /// the method will get all the pressed day events from data base and show on events list
        /// </summary>
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lstEventsList.Items.Clear();
            eventsToDay = db.GetEventsDataByDate(monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"));
            for (int i = 0; i < eventsToDay.Length; i++)
            {
                lstEventsList.Items.Add(i + 1 + ") " + eventsToDay[i].ToString());
            }
        }

        /// <summary>
        /// method wich works when the user change the chosen event in the events list
        /// the method will shoe the pressed event details on the details table
        /// </summary>
        private void lstEventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Checks.IsItemSelected(lstEventsList))
            {
                btnEditEvent.Enabled = true;
                newEvent = eventsToDay[lstEventsList.SelectedIndex];
                FillExistEventDataGrid();
            }
        }

        /// <summary>
        /// method wich filles the exists event data grid with the pressed event details
        /// </summary>
        private void FillExistEventDataGrid()
        {
            dgvExistEventDetails.Rows.Clear();
            dgvExistEventDetails.Rows.Add(newEvent.EventType, newEvent.EventDate.ToString("dd/MM/yyyy"), newEvent.EventTime.ToString("HH:mm"), newEvent.OwnerFname + " " + newEvent.OwnerLname, newEvent.OwnerPhone, newEvent.NumOfParticipants);
            dgvExistEventDetails.Rows[0].Selected = false;
            dgvExistEventDetails.Visible = true;
        }

        /// <summary>
        /// method wich works when the user press on "edit event" button
        /// the method will pass to events tab and put all the chosen events
        /// details on the fields
        /// </summary>
        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (Checks.IsItemSelected(lstEventsList))
            {
                tcMain.SelectedTab = tpEvnets;
                btnUpdateEvent.Enabled = true;
                btnAddEvent.Enabled = false;
                FillFieldsWithExistEvent();
            }
            else
                MessageBox.Show("בחר אירוע מהרשימה ואז לחץ על עריכת אירוע!");
        }

        /// <summary>
        /// method wich fill the fields with the chosen event to edit
        /// </summary>
        public void FillFieldsWithExistEvent()
        {
            txtOwnerFname.Text = newEvent.OwnerFname;
            txtOwnerLname.Text = newEvent.OwnerLname;
            txtOwnerPhone.Text = newEvent.OwnerPhone;
            txtOwnerMail.Text = newEvent.OwnerEmail;
            txtEventType.Text = newEvent.EventType;
            dtpEventDate.Value = newEvent.EventDate;
            dtpEventTime.Value = newEvent.EventTime;
            txtEventParticipants.Text = newEvent.NumOfParticipants.ToString();
            txtEventNotes.Text = newEvent.EventNotes;
            FillExistEventDataGrid();
        }

        /// <summary>
        /// method wich works when the user press on "update event" button
        /// the method will check all the fields and if all ok update the spcific event details in the data base
        /// </summary>
        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if(inputChecks())
            {
                FillEventObjectWithDetails();
                db.UpdateEvent(newEvent);
                MessageBox.Show("האירוע עודכן בהצלה!");
                monthCalendar.SetDate(DateTime.Now);
                CleanFields();
            }
        }

        #endregion

    }
}
