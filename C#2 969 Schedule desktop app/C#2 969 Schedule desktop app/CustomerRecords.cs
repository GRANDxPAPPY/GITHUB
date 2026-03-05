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
    public partial class  CustomerRecords : Form
    {
        DataService DataService = new DataService();
        DataGridViewRow rowIndex = new DataGridViewRow();
        public CustomerRecords()
        {
            InitializeComponent();
            deleteUserRecordButton.Enabled = false;

        }

        
        

        private void addUserRecordButton_Click(object sender, EventArgs e)
        {
            var x = false;           
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox textbox)
                {
                    x = ErrorDetection.IsEmpty(textbox.Text);
                    if(x ==true)
                    {
                        break;
                    }
                }
            }
            if (x == false)
            {
                ErrorDetection.CorrectFormat(customerPhoneNumberTextbox.Text);
            }

            var customer = new customer();
            customer.customerID = 0;
            customer.customerName = customerNameTextbox.Text;
            customer.addressID = 0;

            var address = new address();
            address.phone = customerPhoneNumberTextbox.Text;
            
            
            DataService.AddCustomer(customer, address);
            
            
        }

        private void updateUserRecordButton_Click(object sender, EventArgs e)
        {
            //click on user and populate text boxes to change data
        }

        private void deleteUserRecordButton_Click(object sender, EventArgs e)
        {
        

            //getting data from dataview grid

            var userphone = rowIndex.Cells["phone"].Value.ToString();
            
            var customer = new customer();
            customer.customerID = 0;
            customer.customerName = customerNameTextbox.Text;
            
            customer.customerAddress = customerAddressTextbox.Text;
            var address = new address();
            address.phone = customerPhoneNumberTextbox.Text;

            DataService.DeleteCustomer(customer, address);
            dataGridView1.DataSource=DataService.getCustomers();
            deleteUserRecordButton.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                rowIndex = row;
                customerNameTextbox.Text = row.Cells["customerName"].Value.ToString();
                customerAddressTextbox.Text = row.Cells["customerAddress"].Value.ToString();
                customerPhoneNumberTextbox.Text = row.Cells["phone"].Value.ToString();
                deleteUserRecordButton.Enabled = true;
            }
        }

        private void CustomerRecords_Load(object sender, EventArgs e)
        {
            var customerList = DataService.getCustomers();
            dataGridView1.DataSource = customerList;
        }
    }
}