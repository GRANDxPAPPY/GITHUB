using Org.BouncyCastle.Security.Certificates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_2_969_Schedule_desktop_app
{
    public partial class Appointments : Form
    {

        DataService DataService = new DataService();
        public Appointments()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            var returnedList = buildAppoinment();
            var appointment = returnedList.Appointment;
            DataService.AddAppointment(appointment,returnedList.Customer);
            dataGridView1.DataSource = DataService.GetAppointmentUIs();
        }

        
        
        public (customer Customer, appointment Appointment) buildAppoinment()
        {

            var myDate = dateTimePicker1.Value;

            var timeString = TimeSpan.Parse(HourMinutesPicker.Text);
            var passingDate = myDate + timeString;

            var selectedCustomer = (CustomerRecordsUI)comboBox1.SelectedItem;
            
            var customer = new customer();
            customer.customerName = selectedCustomer.CustomerName;
            customer.customerID = selectedCustomer.customerID;
            var appointment = new appointment() { title = AppointmentTypeTextbox.Text, start = passingDate};

            
            return (customer, appointment);

            //takes inputs returns a list of objects

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            //everytime page is loaded 
            

            var returnedList = DataService.getCustomers();
            
            var returnedAppointmentUI = DataService.GetAppointmentUIs();
            //var allUserNames = new List<string>();
            //foreach (var customer in returnedList)
            //{
            //    allUserNames.Add(customer.CustomerName.ToString());
            //}
            comboBox1.DataSource = returnedList;
            comboBox1.DisplayMember = "CustomerName";
            comboBox1.ValueMember = "customerID";
            dataGridView1.DataSource = DataService.GetAppointmentUIs();


        }

    }

   }

