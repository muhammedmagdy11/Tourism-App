using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_App
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "Skine_Files/Skins/GlassBrown.ssk";
            // Insert Filterations into Combo Boxes

            //List<string> TravelWayList = new List<string>();
            //TravelWayList.Add("");
            //TravelWayList.Add(Type.Bus.ToString());
            //TravelWayList.Add(Type.Plane.ToString());

            //List<string> numOfDaysList = new List<string>();
            //numOfDaysList.Add("");
            //numOfDaysList.Add("1-3");
            //numOfDaysList.Add("3-7");
            //numOfDaysList.Add("7-15");

            IEnumerable<string> TravelWayList = from t in Program._dbContext.Journeys
                                                select t.TravelWay.ToString();
            TravelWayList = TravelWayList.Distinct().ToList();
            List<string> TravelWayListUpdated = new List<string>();
            TravelWayListUpdated.Add("");
            TravelWayListUpdated.AddRange(TravelWayList);


            IEnumerable<string> numOfDaysList = from numofdays in Program._dbContext.Journeys
                                             select numofdays.NumOfDays.ToString();
            numOfDaysList = numOfDaysList.Distinct().ToList();
            List<string> numOfDaysListUpdated = new List<string>();
            numOfDaysListUpdated.Add("");
            numOfDaysListUpdated.AddRange(numOfDaysList);



            IEnumerable<string> LocationsList = from l in Program._dbContext.Journeys
                                                select l.Location;
            LocationsList = LocationsList.Distinct().ToList();
            List<string> LocationsListUpdated = new List<string>();
            LocationsListUpdated.Add("");
            LocationsListUpdated.AddRange(LocationsList);


            IEnumerable<string> DateList = from d in Program._dbContext.Journeys
                                             select d.Date.ToString();
            DateList = DateList.Distinct().ToList();
            List<string> DateListUpdated = new List<string>();
            DateListUpdated.Add("");
            DateListUpdated.AddRange(DateList);

            cmb_Date.DataSource = DateListUpdated;
            cmb_location.DataSource = LocationsListUpdated;
            cmb_numOfDays.DataSource = numOfDaysListUpdated;
            cmb_travelWay.DataSource = TravelWayListUpdated;


            // Insert Jouneys into DataGridView
            

            data_Journeys.ColumnCount = 7;

            data_Journeys.Columns[0].HeaderText = "Title";
            data_Journeys.Columns[0].Name = "Title";

            data_Journeys.Columns[1].HeaderText = "Description";
            data_Journeys.Columns[1].Name = "Description";

            data_Journeys.Columns[2].HeaderText = "Travel Way";
            data_Journeys.Columns[2].Name = "TravelWay";

            data_Journeys.Columns[3].HeaderText = "Cost";
            data_Journeys.Columns[3].Name = "TicketCost";

            data_Journeys.Columns[4].HeaderText = "Duration";
            data_Journeys.Columns[4].Name = "NumOfDays";

            data_Journeys.Columns[5].HeaderText = "Start Date";
            data_Journeys.Columns[5].Name = "Date";

            data_Journeys.Columns[6].HeaderText = "Available Seats";
            data_Journeys.Columns[6].Name = "AvailableSeats";

            //data_Journeys.Rows.Clear();

            IEnumerable<Journey> journeys = from j in Program._dbContext.Journeys
                                            where (j.MaxNumber - j.NumOfReservedChairs) > 0 &&
                                            (j.Date >= DateTime.Now)
                                            select j;

            foreach (var item in journeys)
            {
                data_Journeys.Rows.Add(new string[]
                {
                    item.Title,
                    item.Description,
                    item.TravelWay.ToString(),
                    item.TicketCost.ToString(),
                    item.NumOfDays.ToString(),
                    item.Date.ToString(),
                    (item.MaxNumber - item.NumOfReservedChairs).ToString()
                });
                //data_Journeys.Columns[0] = item.Title;
                //data_Journeys.Columns[1] = item.Description;
                //data_Journeys.Columns[2] = item.TravelWay;
                //data_Journeys.Columns[3] = item.TicketCost;
                //data_Journeys.Columns[4] = item.NumOfDays;
                //data_Journeys.Columns[5] = item.Date;
                //data_Journeys.Columns[6] = (item.MaxNumber - item.NumOfReservedChairs);

            }


            //rerservation data 
            Reservationdgv.ColumnCount = 4;
            Reservationdgv.Columns[0].HeaderText = "Reservation ID";
            Reservationdgv.Columns[0].Name = "ReservationID";

            Reservationdgv.Columns[1].HeaderText = "Journey Name";
            Reservationdgv.Columns[1].Name = "JournyName";

            Reservationdgv.Columns[2].HeaderText = "Passenger Name";
            Reservationdgv.Columns[2].Name = "PassengerName";

            Reservationdgv.Columns[3].HeaderText = "Number of Tickets";
            Reservationdgv.Columns[3].Name = "NumOfTickets";

            loaddata();


        }

        private void data_Journeys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void data_Journeys_MouseEnter(object sender, EventArgs e)
        {

        }

        private void data_Journeys_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void data_Journeys_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_book.Visible = true;

        }

        private void btn_book_Click(object sender, EventArgs e)
        {

            if (data_Journeys.SelectedRows.Count > 0)
            {
                string compare = data_Journeys.SelectedRows[0].Cells[0].Value.ToString();
                //MessageBox.Show(data_Journeys.SelectedRows[0].Cells[0].Value.ToString());
                var journey = (from j in Program._dbContext.Journeys
                                 where (j.Title.Equals( compare ) )
                                 //&& j.Date.ToString() == data_Journeys.SelectedRows[0].Cells[5].Value.ToString()
                                 select j).FirstOrDefault();

                //MessageBox.Show(journey.ID.ToString());
                Booked bookedForm = new Booked(journey.ID);
                this.Hide();
                bookedForm.Show();
            }
            else
                MessageBox.Show("Please Select one row at least..");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int budget = 0;
            if (int.TryParse(txt_budget.Text, out budget) || txt_budget.Text == "")
            {
                lbl_budget.Visible = false;
                IEnumerable<Journey> journeys = from j in Program._dbContext.Journeys
                                                where (j.Date >= DateTime.Now)
                                                select j;


                if (journeys != null)
                {
                    if (cmb_travelWay.SelectedItem.ToString() != "")
                        journeys = journeys.Where(j => (j.TravelWay.ToString() == cmb_travelWay.SelectedItem.ToString()) && (j.Date >= DateTime.Now));

                    if (cmb_location.SelectedItem.ToString() != "")
                        journeys = journeys.Where(j => (j.Location == cmb_location.SelectedItem.ToString()) && (j.Date >= DateTime.Now));

                    if (cmb_numOfDays.SelectedItem.ToString() != "")
                        journeys = journeys.Where(j => (j.NumOfDays.ToString() == cmb_numOfDays.SelectedItem.ToString()) && (j.Date >= DateTime.Now));

                    if (cmb_Date.SelectedItem.ToString() != "")
                        journeys = journeys.Where(j => (j.Date == DateTime.Parse(cmb_Date.SelectedItem.ToString())) && (j.Date >= DateTime.Now));



                    if (budget > 0)
                        journeys = journeys.Where(j => j.TicketCost <= budget);
                }
                else
                    MessageBox.Show("No Journeys avaialable");


                data_Journeys.Rows.Clear();
                foreach (var item in journeys)
                {
                    data_Journeys.Rows.Add(new string[]
                    {
                        item.Title,
                        item.Description,
                        item.TravelWay.ToString(),
                        item.TicketCost.ToString(),
                        item.NumOfDays.ToString(),
                        item.Date.ToString(),
                        (item.MaxNumber - item.NumOfReservedChairs).ToString()
                    });
                }


            }
            else
                lbl_budget.Visible = true;
        }

        private void Reservationdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in Reservationdgv.SelectedRows)
            {
                    int id = int.Parse(Reservationdgv.Rows[item.Index].Cells[0].Value.ToString());

                var deleted = (from d in Program._dbContext.Reserves
                               where d.ID == id
                               select d).First();
                deleted.Journey.NumOfReservedChairs -= deleted.NumOfTickets;
                Program._dbContext.Reserves.Remove(deleted);
                Program._dbContext.SaveChanges();
               
                
              
            }
            Reservationdgv.Rows.Clear();
            loaddata();
            data_Journeys.Rows.Clear();
            loadjourneys();
        }
        public void loaddata()
        {

            IEnumerable<Reserve> Reservations = (from r in Program._dbContext.Reserves.Include("Employee").Include("Passenger").Include("Journey")
                                                 select r) ;
            
            foreach (var item in Reservations)
            {
                Reservationdgv.Rows.Add(new string[] { item.ID.ToString(), item.Journey.Title, item.Passenger.Name,item.NumOfTickets.ToString() });
            }


            

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Reservationdgv.SelectedRows)
            {
              richreserveid.Text =Reservationdgv.Rows[item.Index].Cells[0].Value.ToString();
                richnumoftickets.Text = Reservationdgv.Rows[item.Index].Cells[3].Value.ToString();
            }
            int id = int.Parse(richreserveid.Text);
            var updated = (from d in Program._dbContext.Reserves
                           where d.ID == id
                           select d).FirstOrDefault();
            updated.Journey.NumOfReservedChairs -= updated.NumOfTickets;
            Program._dbContext.SaveChanges();
            btnupdate.Visible = false;
            btnsave.Visible = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(richreserveid.Text);
            var updated = (from d in Program._dbContext.Reserves
                           where d.ID == id
                           select d).FirstOrDefault();
            
            if (updated != null)
            {

                if (updated.Journey.MaxNumber - (updated.Journey.NumOfReservedChairs + int.Parse(richnumoftickets.Text)) >= 0)
                {
                    updated.NumOfTickets = int.Parse(richnumoftickets.Text);
                    updated.Journey.NumOfReservedChairs += updated.NumOfTickets;
                    Program._dbContext.SaveChanges();
                    Reservationdgv.Rows.Clear();
                    loaddata();
                    data_Journeys.Rows.Clear();
                    loadjourneys();
                    cleartextboxs();
                    btnsave.Visible = false;
                    btnupdate.Visible = true;
                }
                else
                {
                    MessageBox.Show("you exceeded the max number");
                }

               
            }
            else
                MessageBox.Show("Not Found");

            
        }
        public void cleartextboxs()
        {
            richnumoftickets.Text = "";
            richreserveid.Text = "";
        }
        public void loadjourneys()
        {
            IEnumerable<Journey> journeys = from j in Program._dbContext.Journeys
                                            where j.Date >= DateTime.Now
                                            select j;
            foreach (var item in journeys)
            {
              
                data_Journeys.Rows.Add(new string[]
                {
                        item.Title,
                        item.Description,
                        item.TravelWay.ToString(),
                        item.TicketCost.ToString(),
                        item.NumOfDays.ToString(),
                        item.Date.ToString(),
                        (item.MaxNumber - item.NumOfReservedChairs).ToString()
                });
            }
        }
    }
}
