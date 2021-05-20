using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_App
{
    public partial class Booked : Form
    {
        //Data_Context Context = new Data_Context();
        Passenger p = new Passenger();
        int Passenger_ID;
        Reserve R = new Reserve();
        public int Journeys_id;
        int avilable;
        public Booked(int id)
        {
            this.Journeys_id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = textBox1.Text;
            p.Age = int.Parse(textBox2.Text);
            p.Phone = textBox3.Text;
            p.NationalID = textBox4.Text;

            // Context.Passengers.Add(p);
            //Context.SaveChanges();

            Passenger_ID = p.ID;
            R.JourneyID = this.Journeys_id;
            R.PassengerID = Passenger_ID;
            R.NumOfTickets = int.Parse(textBox5.Text);
            R.EmployeeID = LoginForm.EmpID;

            //R.Passenger = p;

            // Context.Reserves.Add(R);
            Journey J = (from j in Program._dbContext.Journeys
                         where j.ID == Journeys_id
                         select j).FirstOrDefault();

            avilable = J.MaxNumber - J.NumOfReservedChairs;
            if (avilable < int.Parse(textBox5.Text))
            {
                MessageBox.Show("Number of Tickets are more than avilable \n avilable= " + avilable);
            }
            else
            {
                Program._dbContext.Passengers.Add(p);
                Program._dbContext.SaveChanges();

                //MessageBox.Show(J.NumOfReservedChairs.ToString());
                J.NumOfReservedChairs += int.Parse(textBox5.Text);
                //MessageBox.Show(J.NumOfReservedChairs.ToString());

                R.PassengerID = p.ID;
                Program._dbContext.Reserves.Add(R);
                Program._dbContext.SaveChanges();
                MessageBox.Show("Booked Done");

                #region Send e-mail To Passenger on his Mail

                try
                {

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("tourismappteam@gmail.com");
                    msg.To.Add(txt_email.Text);
                    msg.Subject = "Tourism App Team";
                    msg.Body = $"Dear {p.Name},\nThis Mail confirms that you have just booked {R.NumOfTickets} Tickets " +
                        $"In our Journey \"{J.Title}\" with ResrvationID: {R.ID} at " +
                        $"{DateTime.Now.ToShortDateString().ToString()}\nHope for You a nice Journey,\nTourism App Team,\nRegards.\n" +
                        $"\n\nNote: The Reservation ID you need to keep it if you need to update your number of Tickets";

                    msg.Attachments.Add(new Attachment("../../Resources/ticket.jpg"));

                    SmtpClient smt = new SmtpClient();

                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    smt.UseDefaultCredentials = false;
                    ntcd.UserName = "tourismappteam@gmail.com";
                    ntcd.Password = "123456789asdasd++";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Your Mail is sended");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                #endregion

                EmployeeForm empForm = new EmployeeForm();
                empForm.Show();
                this.Hide();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.EmptyString(textBox1.Text))
            {
                if (Validation.NameValidation(textBox1.Text))
                {
                    label6.Text = "";
                    label6.Visible = false;
                }
                else
                {
                    label6.Text = " invalid Name format";
                    label6.Visible = true;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.EmptyString(textBox2.Text))
            {
                label7.Text = "";
                label7.Visible = false;
            }

            else
            {
                label7.Text = " requird";
                label7.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.EmptyString(textBox3.Text))
            {
                if (Validation.MobileValidation(textBox3.Text))
                {
                    label5.Text = "";
                    label5.Visible = false;
                }
                else
                {
                    label5.Text = " invalid Mobile format";
                    label5.Visible = true;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.EmptyString(textBox4.Text))
            {
                if (Validation.NationalIDValidation(textBox4.Text))
                {
                    label8.Text = "";
                    label8.Visible = false;
                }
                else
                {
                    label8.Text = " invalid National ID";
                    label8.Visible = true;
                }
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Booked_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "Skine_Files/Skins/GlassBrown.ssk";
        }
    }
}
