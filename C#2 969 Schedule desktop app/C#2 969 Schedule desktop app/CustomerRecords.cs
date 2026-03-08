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
    public partial class CustomerRecords : Form
    {
        DataService DataService = new DataService();
        DataGridViewRow rowIndex = null;

        public CustomerRecords()
        {
            InitializeComponent();
            deleteUserRecordButton.Enabled = false;
            updateUserRecordButton.Enabled = false;
        }

        private void addUserRecordButton_Click(object sender, EventArgs e)
        {
            var x = false;
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox textbox)
                {
                    x = ErrorDetection.IsEmpty(textbox.Text);
                    if (x == true)
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
            customer.customerName = customerNameTextbox.Text;

            var address = new address();
            address.phone = customerPhoneNumberTextbox.Text;
            address.address1 = customerAddressTextbox.Text;
            

            DataService.AddCustomer(customer, address);
            dataGridView1.DataSource = DataService.getCustomers();
            ClearFields();
        }

        private void updateUserRecordButton_Click(object sender, EventArgs e)
        {
            //click on user and populate text boxes to change data

            var customer = new customer
            {
                customerName = customerNameTextbox.Text,
                customerID = Convert.ToInt32(rowIndex.Cells["customerID"].Value),
                addressID = Convert.ToInt32(rowIndex.Cells["addressID"].Value)
            };

            var address = new address()
            {
                address1 = customerAddressTextbox.Text,
                
                phone = customerPhoneNumberTextbox.Text
            };

            DataService.updateCustomer(customer, address);
            dataGridView1.DataSource = DataService.getCustomers();
            deleteUserRecordButton.Enabled = false;
            updateUserRecordButton.Enabled = false;
            ClearFields();

        }

        private void deleteUserRecordButton_Click(object sender, EventArgs e)
        {
            var customer = new customer();
            customer.customerID = Convert.ToInt32(rowIndex.Cells["customerID"].Value);

            DataService.DeleteCustomer(customer);
            dataGridView1.DataSource = DataService.getCustomers();
            deleteUserRecordButton.Enabled = false;
            updateUserRecordButton.Enabled = false;
            ClearFields();
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
                updateUserRecordButton.Enabled = true;

            }
        }

        private void CustomerRecords_Load(object sender, EventArgs e)
        {
            var customerList = DataService.getCustomers();
            dataGridView1.DataSource = customerList;
        }

        private void ClearFields()
        {
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
        }

        private void appointmentPortalButton_Click(object sender, EventArgs e)
        {
            var x = new Appointments();
            x.ShowDialog();
        }
    }
}