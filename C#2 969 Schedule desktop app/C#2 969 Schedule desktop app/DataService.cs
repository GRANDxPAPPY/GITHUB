using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Mysqlx.Prepare;


namespace C_2_969_Schedule_desktop_app
{
    public class DataService
    {
        readonly string pathToData = ConfigurationManager.ConnectionStrings["scheduledb"].ConnectionString;



        public bool AddCustomer(customer customer, address address)
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            try
            {
                using (Data) {
                    Data.Open();
                    string addressQuery = "INSERT INTO address (phone) VALUES (@phone)";

                    MySqlCommand addressCommandVar = new MySqlCommand(addressQuery, Data);

                    addressCommandVar.Parameters.AddWithValue("@phone", address.phone);

                    addressCommandVar.ExecuteNonQuery();

                    var newaddId = addressCommandVar.LastInsertedId;

                    string query = "INSERT INTO customer (customerName, addressId) Values (@customerName, @addressId)";
                    
                    MySqlCommand commandVar = new MySqlCommand(query, Data);
                   


                    commandVar.Parameters.AddWithValue("@customerName", customer.customerName);
                    commandVar.Parameters.AddWithValue("@addressId", newaddId);

                   
                    commandVar.ExecuteNonQuery();
                    
                    return true;
                }
                   
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Entering Data to SQL");
                return false;
                
            }
        }

        public bool DeleteCustomer(customer customer, address address)
        {
            //DONT WORRY ABOUT THIS GET DATA FROM GRID SO WE CAN PASS THROUGH HERE!!!
            MySqlConnection Data = new MySqlConnection(pathToData);

            try
            {
                using (Data)
                {
                    Data.Open();
                    var deleteque = "DELETE FROM customer WHERE customerName = @customerName";

                    MySqlCommand myDeleteCommand = new MySqlCommand(deleteque, Data);

                    myDeleteCommand.Parameters.AddWithValue("@customerName", customer.customerName);

                    myDeleteCommand.ExecuteNonQuery();
                    
                    return true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error Deleting customer from Database");
                    return false;
            }
        }

        //get data for datagrid views
        public  List<customer> getCustomers()
        {
            var customerList = new List<customer>();
            MySqlConnection Data = new MySqlConnection(pathToData);

            using (Data)
            {
                Data.Open();
                var getCustomerVar = "SELECT C.customerName, A.customerAddress, A.phone FROM customer as C LEFT JOIN address as A on C.addressId = A.addressId";
                MySqlCommand getCustomerCommand = new MySqlCommand(getCustomerVar, Data);

                

                MySqlDataReader reader = getCustomerCommand.ExecuteReader();
                while (reader.Read())
                {
                    var customer = new customer() { customerName = reader["customerName"].ToString(), customerAddress = reader["customerAddress"].ToString(),
                        phone = reader["phone"].ToString() };
                    customerList.Add(customer);
                }

            }

                return customerList;
        }

        public bool updateCustomer(customer customer, address address)
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            try
            {
                using (Data)
                {
                    {
                        Data.Open();
                        var mySqlString = "UPDATE adress SET phone = @phone, address = @adress  WHERE adressId = @adressId";
                        MySqlCommand mySqlController = new MySqlCommand(mySqlString, Data);
                        mySqlController.Parameters.AddWithValue(mySqlString, address.adressId);
                        mySqlController.Parameters.AddWithValue("@phone", address.phone);
                        //FIX ME!


                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;

            }
        }
    }

}
