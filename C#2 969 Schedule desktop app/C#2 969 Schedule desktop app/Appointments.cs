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
        int appointmentId = 0;
        DateTime timeHours;
        public Appointments()
        {
            InitializeComponent();
            deleteAppoinmentUpdateButton.Enabled = false;
            UpdateApointmentButton.Enabled = false;
            timeHours = HourMinutesPicker.Value;
        }



        private void addAppointmentButton_Click(object sender, EventArgs e)
        {


            var returnedList = buildAppoinment();
            var appointment = returnedList.Appointment;
            DataService.AddAppointment(appointment, returnedList.Customer);
            dataGridView1.DataSource = DataService.GetAppointmentUIs();

        }






        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            //everytime page is loaded 


            var returnedList = DataService.getCustomers();

            var returnedAppointmentUI = DataService.GetAppointmentUIs();

            comboBox1.DataSource = returnedList;
            comboBox1.DisplayMember = "CustomerName";
            comboBox1.ValueMember = "customerID";
            dataGridView1.DataSource = DataService.GetAppointmentUIs();


        }

        private void UpdateApointmentButton_Click(object sender, EventArgs e)
        {
            DataService.UpdateAppointment(buildAppoinment().Appointment, buildAppoinment().Customer);
            dataGridView1.DataSource = DataService.GetAppointmentUIs();
            deleteAppoinmentUpdateButton.Enabled = false;
            UpdateApointmentButton.Enabled = false;
        }

        private void deleteAppoinmentUpdateButton_Click(object sender, EventArgs e)
        {
            DataService.DeleteAppointment(buildAppoinment().Appointment);
            dataGridView1.DataSource = DataService.GetAppointmentUIs();
            deleteAppoinmentUpdateButton.Enabled = false;
            UpdateApointmentButton.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                var rowIndex = row;
                AppointmentTypeTextbox.Text = row.Cells["Appoinment"].Value.ToString();
                comboBox1.DisplayMember = row.Cells["customerName"].Value.ToString();
                appointmentId = Convert.ToInt32(row.Cells["AppointmentId"].Value);

                deleteAppoinmentUpdateButton.Enabled = true;
                UpdateApointmentButton.Enabled = true;

            }
        }
        public (customer Customer, appointment Appointment) buildAppoinment()
        {

            var myDate = dateTimePicker1.Value.Date;


            var timeString = HourMinutesPicker.Value.TimeOfDay;


            var passingDate = myDate + timeString;

            var selectedCustomer = (CustomerRecordsUI)comboBox1.SelectedItem;

            var customer = new customer();
            customer.customerName = selectedCustomer.CustomerName;
            customer.customerID = selectedCustomer.customerID;
            var appointment = new appointment();
            if (appointmentId == 0)
            {
                appointment.title = AppointmentTypeTextbox.Text;
                appointment.start = passingDate;
            }
            else
            {
                appointment.title = AppointmentTypeTextbox.Text;
                appointment.start = passingDate;
                appointment.appointmentId = appointmentId;
            }

            return (customer, appointment);

            //takes inputs returns a list of objects

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value.DayOfWeek == 0 || dateTimePicker1.Value.DayOfWeek == (DayOfWeek)6)
            {
                MessageBox.Show("Appointments only avaliable on working hours (9:00 am - 5:00pm, Monday - Friday");
                dateTimePicker1.Value.AddDays(2);

            }
        }

        private void HourMinutesPicker_ValueChanged(object sender, EventArgs e)
        {

            if (HourMinutesPicker.Value.TimeOfDay < TimeSpan.Parse("09:00") || HourMinutesPicker.Value.TimeOfDay > TimeSpan.Parse("17:00"))
            {
                MessageBox.Show("Appointments only avaliable on working hours (9:00 am - 5:00pm, Monday - Friday");
                HourMinutesPicker.Value = timeHours;
                return;
            }

            var myDate = dateTimePicker1.Value.Date;
            var timeString = HourMinutesPicker.Value.TimeOfDay;
            DateTime startTime = myDate + timeString;
            var endTime = startTime.AddHours(1);
            
            foreach (var scheduledAppointments in DataService.GetAppointmentUIs())
            {
                var start = DateTime.Parse(scheduledAppointments.AppoimentTime);
                var end = start.AddHours(1);

                if (start < endTime && end > startTime)
                {
                    MessageBox.Show("Appointments Cannot overlap");
                    return;
                }
            }
        }

        
    }
}


