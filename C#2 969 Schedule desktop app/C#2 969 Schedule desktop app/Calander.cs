using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_2_969_Schedule_desktop_app
{
    public partial class Calander : Form
    {

        DataService DataService = new DataService();
        



        public Calander()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //make it only show when you click on day
            var tempHold = DataService.GetAppointmentUIs();
            var dataList = new List<UI>();
            foreach (var appointment in tempHold)
            {
                if (DateTime.Parse(appointment.AppoimentTime).Date == monthCalendar1.SelectionStart.Date)
                { 
                var ui = new UI() { appointmentName = appointment.Appoinment, customerName = appointment.customerName };
                dataList.Add(ui);
           
                }
            }
            //first Lamba
            var countPerMonthList = tempHold.Where(n => DateTime.Parse(n.AppoimentTime).Month == monthCalendar1.SelectionStart.Month && DateTime.Parse(n.AppoimentTime).Year == monthCalendar1.SelectionStart.Year)
                .GroupBy(n => n.Appoinment)
                .Select(n => new countUI
                {
                    Type = n.Key,
                    count = n.Count()
                }).ToList();
            
            //secon
            var countPTODays = tempHold.Where(n => DateTime.Parse(n.AppoimentTime).Month == monthCalendar1.SelectionStart.Month && DateTime.Parse(n.AppoimentTime).Year == monthCalendar1.SelectionStart.Year)
                .GroupBy(n => n.customerName)
                .Select(n => new scheduleUI
                {
                    CustomerName = n.Key,
                    PTO_Used = n.Count()

                }).ToList();



            //3rd will display user and number of logins
            var logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login_History.txt");
            var logLines = File.ReadAllLines(logPath);

            var countLoginsPerMonth = logLines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line =>
                {
                    var parts = line.Split(new[] { ' ' }, 2);
                    return new
                    {
                        UserName = parts[0],
                        LoginDate = DateTime.Parse(parts[1])
                    };
                })
                .Where(log => log.LoginDate.Month == monthCalendar1.SelectionStart.Month
                           && log.LoginDate.Year == monthCalendar1.SelectionStart.Year)
                .GroupBy(log => log.UserName)
                .Select(g => new LoginUI
                {
                    UserName = g.Key,
                    LoginCount = g.Count()
                })
                .ToList();


            dataGridView3.DataSource = countLoginsPerMonth;
            dataGridReports.DataSource = countPerMonthList;
            dataGridView1.DataSource = dataList;
            dataGridView2.DataSource = countPTODays;
        }

        

        private void Calander_Load(object sender, EventArgs e)
        {
            List<DateTime> appointmentArray = new List<DateTime>();
            
            //Wouldnt have to do this if i just followed the system and didnt try to be a smart ass with it
            foreach (var appointment in DataService.GetAppointmentUIs())
            {

                appointmentArray.Add(DateTime.Parse(appointment.AppoimentTime));
                
            }
            
            monthCalendar1.BoldedDates = appointmentArray.ToArray();

            
        }


       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    internal class UI
    {
        public string customerName { get; set; }
        public string appointmentName { get; set; }
        
    }

    internal class countUI
    {
        public string Type { get; set; }
        public int count { get; set; }
    }

    internal class scheduleUI
    {
        public string CustomerName { get; set; }
        public int PTO_Used { get; set; }
    }
    internal class LoginUI
    {
        public string UserName { get; set; }
        public int LoginCount { get; set; }
    }
}
