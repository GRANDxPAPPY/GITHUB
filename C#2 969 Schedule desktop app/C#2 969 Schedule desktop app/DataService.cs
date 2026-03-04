using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


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
            MySqlConnection Data = new MySqlConnection(pathToData);

            try
            {
                using (Data)
                {

                    return true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error Deleting customer from Database")
                    return false;
            }
        }
    }
}
