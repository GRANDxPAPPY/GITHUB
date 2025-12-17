using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private readonly Inventory _inventory;
        private readonly Product _product;
        BindingSource MyBind = new BindingSource();
        BindingSource AssociatedParts = new BindingSource();
        BindingSource MyBind2 = new BindingSource();
        BindingSource AssociatedParts2 = new BindingSource();


        public Form3()
        {
            InitializeComponent();

        }

        public Form3(Inventory inventory, Product product)
        {
            InitializeComponent();
            _inventory = inventory;
            _product = product;

            // Panel1 (Add Product) grids
            MyBind.DataSource = _inventory.AllParts;
            dataGridView1.DataSource = MyBind;

            AssociatedParts.DataSource = _product.AssociatedParts;
            dataGridView2.DataSource = AssociatedParts;

            // Panel2 (Modify Product) grids
            MyBind2.DataSource = _inventory.AllParts;
            dataGridView4.DataSource = MyBind2;

            AssociatedParts2.DataSource = _product.AssociatedParts;
            dataGridView3.DataSource = AssociatedParts2;

            textBox13.Text = Convert.ToString(_product.ProductID);
            textBox12.Text = Convert.ToString(_product.Name);
            textBox11.Text = Convert.ToString(_product.InStock);
            textBox10.Text = Convert.ToString(_product.Price);
            textBox9.Text = Convert.ToString(_product.Min);
            textBox8.Text = Convert.ToString(_product.Max);
        }



        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = _product.ProductID.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cancel Button

            Close();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //All Parts Grid - Add associated part

            Part userSelect = (Part)dataGridView4.Rows[e.RowIndex].DataBoundItem;

            _product.addAssociatedPart(userSelect);
            AssociatedParts2.DataSource = _product.AssociatedParts;
            AssociatedParts2.ResetBindings(false);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //All Associated Parts Grid - Remove associated part

            Part userSelect = (Part)dataGridView3.Rows[e.RowIndex].DataBoundItem;
            var userSelectID = userSelect.PartID;
            _product.removeAssociatedPart(userSelectID);

            // Refresh the binding to reflect changes
            AssociatedParts2.ResetBindings(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //.addAssociatedParts

            Part userSelect = (Part)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            _product.addAssociatedPart(userSelect);
            AssociatedParts.DataSource = _product.AssociatedParts;
            AssociatedParts.ResetBindings(false);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //removeAssociatedPart on click

            Part userSelect = (Part)dataGridView2.Rows[e.RowIndex].DataBoundItem;
            var userSelectID = userSelect.PartID;
            _product.removeAssociatedPart(userSelectID);


            // Refresh the binding to reflect changes
            AssociatedParts.ResetBindings(false);
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            // Search Bar textbox
        }

      



        private void Button_Delete_Click(object sender, EventArgs e)
        {
            //removeAssociatd Part
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            //_product.addProduct
            var minText = Convert.ToInt32(textBox7.Text);
            var maxText = Convert.ToInt32(textBox6.Text);
            var current = Convert.ToInt32(textBox3.Text);

            if (current >= minText && current <= maxText)
            {
                Product product = new Product();
                product.ProductID = Convert.ToInt32(textBox1.Text);
                product.Name = textBox2.Text;
                product.Price = Convert.ToDecimal(textBox4.Text);
                product.InStock = Convert.ToInt32(textBox3.Text);
                product.Min = Convert.ToInt32(textBox7.Text);
                product.Max = Convert.ToInt32(textBox6.Text);
                product.AssociatedParts = _product.AssociatedParts;
                _inventory.addProduct(product);

                Close();
            }

            else { MessageBox.Show("Inventory must be between Min and Max values"); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = new AmountItem(_inventory, textBox13.Text).GetAmount();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.Text = new AmountItem(_inventory, textBox13.Text).GetAmount();
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Save Button
            var minText = Convert.ToInt32(textBox9.Text);
            var maxText = Convert.ToInt32(textBox8.Text);
            var current = Convert.ToInt32(textBox11.Text);

            if (current >= minText && current <= maxText)
            {
                _product.ProductID = Convert.ToInt32(textBox13.Text);
                _product.Name = textBox12.Text;
                _product.InStock = Convert.ToInt32(textBox11.Text);
                _product.Price = Convert.ToDecimal(textBox10.Text);
                _product.Min = Convert.ToInt32(textBox9.Text);
                _product.Max = Convert.ToInt32(textBox8.Text);

                _inventory.updateProduct(_product.ProductID, _product);
                Close();
            }

            else { MessageBox.Show("Inventory must be between Min and Max values"); }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
