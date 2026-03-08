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


            
        }

        

        public List<object> buildAppoinment()
        {

            var myDate = dateTimePicker1.Value;

            var timeString = TimeSpan.Parse(HourMinutesPicker.Text);
            var passingDate = myDate + timeString;
            
            var customer = new customer() { customerName = comboBox1.ValueMember}//add combo box selection here
            ;
            var appointment = new appointment() { title = AppointmentTypeTextbox.Text, start = passingDate};

            var myList = new List<object>();
            myList.Add(customer);
            myList.Add(appointment);
            return myList;

            //takes inputs returns a list of objects

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            //everytime page is loaded 
            // make this only get the names form buildAppoinments

            var returnedList = DataService.getCustomers();
            //FIX ME!
            var returnedAppointmentUI = DataService.GetAppointmentUIs();
            var allUserNames = new List<string>();
            foreach (var customer in returnedList)
            {
                allUserNames.Add(customer.CustomerName.ToString());
            }
            comboBox1.DataSource = allUserNames;
            dataGridView1.DataSource = DataService.GetAppointmentUIs();


        }

    }

   }

