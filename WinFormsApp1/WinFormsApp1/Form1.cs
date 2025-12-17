using System.ComponentModel;
using System.DirectoryServices;
using System.Security.Cryptography;

namespace WinFormsApp1
{



    public partial class Form1 : Form
    {
        // Initilized and inventory for form 1 and a bindnig source

        // Made sources to grid views for Parts and Productts.


        Inventory inventory = new Inventory();
        BindingSource MyBind = new BindingSource();
        Part selectedPart = new Part();
        BindingSource PartSource = new BindingSource();
        Product product = new Product();

        public Form1()
        {
            InitializeComponent();

            //Making Grids Populate with data from inventory

            MyBind.DataSource = inventory.AllParts;
            dataGridView1.DataSource = MyBind;
            PartSource.DataSource = inventory.Products;
            dataGridView2.DataSource = PartSource;

            DeletePageButt.Enabled = false;
            button2.Enabled = false;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled == false || selectedPart.PartID == 0)
            {
                return;
            }
            else
            {
                var x = new Form2(inventory, selectedPart);
                var Flopping = new Flop(x.panel1, x.panel2);
                Flopping.FlopPage(1);
                x.ShowDialog();

                //Refresh Grid after making changes tells it to read from the source again
                MyBind.ResetBindings(false);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Search Bar textbox

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Search Button

            // Made a new Binding List to hold Search Results we also changed the datasource of my bind to populate the grid
            // so its alwats MyVar.Datasource = <what we want to show> and thendataGridView1.Datasource = MyVar

            BindingList<Part> searchResults = new BindingList<Part>();


            //Making if you search while empty it displays all parts
            if (textBox1.Text == "")
            {
                MyBind.DataSource = inventory.AllParts;

            }
            else
            {
                if(InvalidData.Exception(textBox1.Text))
                searchResults.Add((inventory.LookupPart(Convert.ToInt32(textBox1.Text))));
                MyBind.DataSource = searchResults;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new Form2(inventory);
            var Flopping = new Flop(x.panel1, x.panel2);
            Flopping.FlopPage(0);
            x.ShowDialog();


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



      
        private void AddPageButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var x = new Form3(inventory, product);
            var Flopping = new Flop(x.panel1, x.panel2);
            Flopping.FlopPage(0);
            x.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            if (button2.Enabled == false)
            {
                return;
            }
            else
            {

                var x = new Form3(inventory, product);
                var Flopping = new Flop(x.panel1, x.panel2);
                Flopping.FlopPage(1);
                x.ShowDialog();

                //Refresh Grid after making changes tells it to read from the source again
                PartSource.ResetBindings(false);
            }
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //enable modify button on row select

            //var x = (dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //selectedPart.PartID = Convert.ToInt32(x);
            //MessageBox.Show(x.ToString());



            // obstained data from row and casted it as a part
            selectedPart = (Part)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            DeletePageButt.Enabled = true;


            //Change button 3 color
            ModPageButt.ForeColor = System.Drawing.Color.Black;
            ModPageButt.Refresh();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeletePageButt_Click(object sender, EventArgs e)
        {
            if (InvalidData.confirmDelete())
            {
                // Check if part is associated with any product
                bool isPartInUse = false;
                foreach (var prod in inventory.Products)
                {
                    if (prod.AssociatedParts.Any(p => p.PartID == selectedPart.PartID))
                    {
                        isPartInUse = true;
                        break;
                    }
                }

                if (isPartInUse)
                {
                    MessageBox.Show("Cannot delete this part. It is associated with a product.",
                                    "Delete Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                inventory.deletePart(selectedPart);
                MyBind.ResetBindings(false);
            }
            else
            {
                return;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            product = (Product)dataGridView2.Rows[e.RowIndex].DataBoundItem;
            button2.Enabled = true;
            

            button2.ForeColor = System.Drawing.Color.Black;
            button2.Refresh();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //Product SearchBar
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var x = product.ProductID;
            if (InvalidData.confirmDelete())
            {
                inventory.removeProduct(x);
            }
            else
            {
                return;
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            //Product Search Box

            BindingList<Product> searchResults = new BindingList<Product>();

            if (textBox2.Text == "")
            {
                PartSource.DataSource = inventory.Products;

            }
            else
            {
                if (InvalidData.Exception(textBox2.Text))
                {
                    searchResults.Add((inventory.lookupProduct(Convert.ToInt32(textBox2.Text))));
                    PartSource.DataSource = searchResults;
                }
            }

        }
    }

}

