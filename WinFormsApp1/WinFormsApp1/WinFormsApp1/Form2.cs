using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private Inventory _inventory;
        private Part _selectedPart;

        // Initilizing Form with inventory Parameters
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;


        }
        public Form2(Inventory inventory, Part selectedPart)
        {
            InitializeComponent();
            _inventory = inventory;
            _selectedPart = selectedPart;


            //will be adding all the info the boxes here


            textBox14.Text = Convert.ToString(_selectedPart.PartID);
            textBox13.Text = Convert.ToString(_selectedPart.Name);
            textBox11.Text = Convert.ToString(_selectedPart.Price);
            textBox12.Text = Convert.ToString(_selectedPart.InStock);
            textBox9.Text = Convert.ToString(_selectedPart.Min);
            textBox8.Text = Convert.ToString(_selectedPart.Max);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Chaging Label to Company Name on click
            Label_MachID.Text = "Company Name";


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Label_MachID.Text = "Machine ID";
        }

        private void AddPartLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

            // Getting all data From textBoxes and Making them into a part
            var newPart = new Part();

            //Catching if invnentory is between min and max

            var minText = Convert.ToInt32(textBox_Min.Text);
            var maxText = Convert.ToInt32(textBoxMax.Text);
            var current = Convert.ToInt32(textBox3.Text);

            if (current >= minText && current <= maxText)
            {
                newPart.PartID = (Convert.ToInt32(textBox1.Text));
                newPart.Name = (textBox_Name.Text);
                newPart.Price = (decimal.Parse(textBox3.Text));
                newPart.InStock = (Convert.ToInt32(textBox_Price.Text));
                newPart.Min = (Convert.ToInt32(textBox5.Text));
                newPart.Max = (Convert.ToInt32(textBoxMax.Text));
                _inventory.addPart(newPart);
                Close();
            }
            else { MessageBox.Show("Inventory must be between Min and Max values"); }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Inventory box
            textBox3.Text = new AmountItem(_inventory, textBox1.Text).GetAmount();
            //get current parts to put in inventory block


            textBox3.Text = new AmountItem(_inventory, textBox1.Text).GetAmount();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label_MachID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Modify aParts will go here!var minText = Convert.ToInt32(textBox_Min.Text);
            var minText = Convert.ToInt32(textBox9.Text);
            var maxText = Convert.ToInt32(textBox8.Text);
            var current = Convert.ToInt32(textBox12.Text);

            if (current >= minText && current <= maxText)
            {
                var modPart = new Part();
                modPart.PartID = (Convert.ToInt32(textBox14.Text));
                modPart.Name = (textBox13.Text);
                modPart.Price = (decimal.Parse(textBox11.Text));
                modPart.InStock = (Convert.ToInt32(textBox12.Text));
                modPart.Min = (Convert.ToInt32(textBox9.Text));
                modPart.Max = (Convert.ToInt32(textBox8.Text));
                //passing into class UpdatePart made in invetory.cs

                _inventory.UpdatePart(Convert.ToInt32(textBox14.Text), modPart);

                Close();
            }

            else { MessageBox.Show("Inventory must be between Min and Max values"); }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Company Name";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Machine ID";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox14.Text = Convert.ToString(_selectedPart.PartID);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox12.Text = new AmountItem(_inventory, textBox14.Text).GetAmount();
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
