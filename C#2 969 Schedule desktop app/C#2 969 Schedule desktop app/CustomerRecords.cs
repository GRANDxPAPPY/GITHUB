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
        
        
        public CustomerRecords()
        {
            InitializeComponent();

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

        }

        private void updateUserRecordButton_Click(object sender, EventArgs e)
        {
            //click on user and populate text boxes to change data
        }

        private void deleteUserRecordButton_Click(object sender, EventArgs e)
        {
           //ADD A LIST THAT FINDS USER AND LETS YOU CLICK ON THEM to delete
        }
    }
}