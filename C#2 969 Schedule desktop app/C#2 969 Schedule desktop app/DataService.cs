using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C_2_969_Schedule_desktop_app
{
    public class DataService
    {
        readonly string pathToData = ConfigurationManager.ConnectionStrings["client_schedule"].ConnectionString;



        public bool AddCustomer(customer customer, address address)
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            try
            {
                using (Data)
                {
                    Data.Open();
                    string addressQuery = @"INSERT INTO address 
                (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) 
                VALUES (@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

                    MySqlCommand addressCommandVar = new MySqlCommand(addressQuery, Data);

                    addressCommandVar.Parameters.AddWithValue("@address", address.address1);
                    addressCommandVar.Parameters.AddWithValue("@address2", address.address2 ?? "");
                    addressCommandVar.Parameters.AddWithValue("@cityId", 1);
                    addressCommandVar.Parameters.AddWithValue("@postalCode", address.postalCode ?? "");
                    addressCommandVar.Parameters.AddWithValue("@phone", address.phone);
                    addressCommandVar.Parameters.AddWithValue("@createDate", new DateTime(2024, 1, 1));
                    addressCommandVar.Parameters.AddWithValue("@createdBy", "system");
                    addressCommandVar.Parameters.AddWithValue("@lastUpdate", new DateTime(2024, 1, 1));
                    addressCommandVar.Parameters.AddWithValue("@lastUpdateBy", "system");

                    addressCommandVar.ExecuteNonQuery();

                    var newaddId = addressCommandVar.LastInsertedId;

                    string query = @"INSERT INTO customer 
                (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) 
                VALUES (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

                    MySqlCommand commandVar = new MySqlCommand(query, Data);

                    commandVar.Parameters.AddWithValue("@customerName", customer.customerName);
                    commandVar.Parameters.AddWithValue("@addressId", newaddId);
                    commandVar.Parameters.AddWithValue("@active", 1);
                    commandVar.Parameters.AddWithValue("@createDate", new DateTime(2024, 1, 1));
                    commandVar.Parameters.AddWithValue("@createdBy", "system");
                    commandVar.Parameters.AddWithValue("@lastUpdate", new DateTime(2024, 1, 1));
                    commandVar.Parameters.AddWithValue("@lastUpdateBy", "system");

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
        

        public bool DeleteCustomer(customer customer)
        {
            MySqlConnection Data = new MySqlConnection(pathToData);

            try
            {
                using (Data)
                {
                    Data.Open();


                    var deleteque = "DELETE FROM appointment WHERE customerId = @customerId";
                    MySqlCommand myDeleteCommand = new MySqlCommand(deleteque, Data);

                    myDeleteCommand.Parameters.AddWithValue("@customerId",customer.customerID);
                    myDeleteCommand.ExecuteNonQuery();


                    deleteque = "DELETE FROM customer WHERE customerId = @customerId";

                    myDeleteCommand = new MySqlCommand(deleteque, Data);

                    myDeleteCommand.Parameters.AddWithValue("@customerId", customer.customerID);

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
        public List<CustomerRecordsUI> getCustomers()
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            using (Data)
            {
                Data.Open();
                List<CustomerRecordsUI> customerList = new List<CustomerRecordsUI>();

                var sqlString = "SELECT C.customerId, C.customerName, A.address, A.phone, A.addressId FROM customer as C INNER JOIN address as A ON C.addressId = A.addressId";
                MySqlCommand myCommand = new MySqlCommand(sqlString, Data);
                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    CustomerRecordsUI customer = new CustomerRecordsUI();
                    customer.customerID = Convert.ToInt32(reader["customerId"]);
                    customer.CustomerName = reader["customerName"].ToString();
                    customer.CustomerAddress = reader["address"].ToString();
                    customer.Phone = reader["phone"].ToString();
                    customer.addressId = Convert.ToInt32(reader["addressId"]);
                    customerList.Add(customer);
                }
                return customerList;
            }
            
      

        }

        public bool updateCustomer(customer customer, address address)
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            try
            {
                using (Data)
                {
                    Data.Open();

                    var mySqlString = @"UPDATE address SET 
                phone = @phone, 
                address = @address, 
                address2 = @address2,
                cityId = @cityId,
                postalCode = @postalCode,
                lastUpdate = @lastUpdate,
                lastUpdateBy = @lastUpdateBy
                WHERE addressId = @addressId";
                    MySqlCommand mySqlController = new MySqlCommand(mySqlString, Data);
                    mySqlController.Parameters.AddWithValue("@address", address.address1);
                    mySqlController.Parameters.AddWithValue("@address2", address.address2 ?? "");
                    mySqlController.Parameters.AddWithValue("@cityId", 1);
                    mySqlController.Parameters.AddWithValue("@postalCode", address.postalCode ?? "");
                    mySqlController.Parameters.AddWithValue("@phone", address.phone);
                    mySqlController.Parameters.AddWithValue("@addressId", customer.addressID);
                    mySqlController.Parameters.AddWithValue("@lastUpdate", new DateTime(2024, 1, 1));
                    mySqlController.Parameters.AddWithValue("@lastUpdateBy", "system");

                    mySqlController.ExecuteNonQuery();


                    mySqlString = @"UPDATE customer SET 
                customerName = @customerName,
                lastUpdate = @lastUpdate,
                lastUpdateBy = @lastUpdateBy
                WHERE customerId = @customerId";
                    mySqlController = new MySqlCommand(mySqlString, Data);
                    mySqlController.Parameters.AddWithValue("@customerName", customer.customerName);
                    mySqlController.Parameters.AddWithValue("@customerId", customer.customerID);
                    mySqlController.Parameters.AddWithValue("@lastUpdate", new DateTime(2024, 1, 1));
                    mySqlController.Parameters.AddWithValue("@lastUpdateBy", "system");

                    mySqlController.ExecuteNonQuery();


                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error updating user records!");
                return false;


            }
        }


        public bool AddAppointment(appointment appointment, customer customer)
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            try
            {
                using (Data)
                {
                    Data.Open();
                    var mySqlString = @"INSERT INTO appointment
                (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) 
                VALUES
                (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

                    MySqlCommand mySqlCommand = new MySqlCommand(mySqlString, Data);
                    mySqlCommand.Parameters.AddWithValue("@customerId", customer.customerID);
                    mySqlCommand.Parameters.AddWithValue("@userId", 1);
                    mySqlCommand.Parameters.AddWithValue("@title", appointment.title);
                    mySqlCommand.Parameters.AddWithValue("@description", appointment.description ?? "");
                    mySqlCommand.Parameters.AddWithValue("@location", appointment.location ?? "");
                    mySqlCommand.Parameters.AddWithValue("@contact", appointment.contact ?? "");
                    mySqlCommand.Parameters.AddWithValue("@type", appointment.type ?? "");
                    mySqlCommand.Parameters.AddWithValue("@url", appointment.url ?? "");
                    mySqlCommand.Parameters.AddWithValue("@start", TimeZoneInfo.ConvertTimeToUtc(appointment.start));
                    mySqlCommand.Parameters.AddWithValue("@end", TimeZoneInfo.ConvertTimeToUtc(appointment.end));
                    mySqlCommand.Parameters.AddWithValue("@createDate", DateTime.Now);
                    mySqlCommand.Parameters.AddWithValue("@createdBy", "system");
                    mySqlCommand.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                    mySqlCommand.Parameters.AddWithValue("@lastUpdateBy", "system");
                    mySqlCommand.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed Adding Appointment to Table");
                return false;
            }
        }



        public bool UpdateAppointment(appointment appointment, customer customer)
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            try
            {
                using (Data)
                {
                    Data.Open();
                    var mySqlString = @"UPDATE appointment SET 
                start = @start, 
                end = @end,
                title = @title,
                description = @description,
                location = @location,
                contact = @contact,
                type = @type,
                url = @url,
                lastUpdate = @lastUpdate,
                lastUpdateBy = @lastUpdateBy
                WHERE appointmentId = @appointmentId";

                    MySqlCommand mySqlCommand = new MySqlCommand(mySqlString, Data);
                    mySqlCommand.Parameters.AddWithValue("@start", TimeZoneInfo.ConvertTimeToUtc(appointment.start));
                    mySqlCommand.Parameters.AddWithValue("@end", TimeZoneInfo.ConvertTimeToUtc(appointment.end));
                    mySqlCommand.Parameters.AddWithValue("@title", appointment.title);
                    mySqlCommand.Parameters.AddWithValue("@description", appointment.description ?? "");
                    mySqlCommand.Parameters.AddWithValue("@location", appointment.location ?? "");
                    mySqlCommand.Parameters.AddWithValue("@contact", appointment.contact ?? "");
                    mySqlCommand.Parameters.AddWithValue("@type", appointment.type ?? "");
                    mySqlCommand.Parameters.AddWithValue("@url", appointment.url ?? "");
                    mySqlCommand.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                    mySqlCommand.Parameters.AddWithValue("@lastUpdateBy", "system");
                    mySqlCommand.Parameters.AddWithValue("@appointmentId", appointment.appointmentId);
                    mySqlCommand.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Updating User Appointment");
                return false;
            }
        }

        public bool DeleteAppointment(appointment appointment)
        {

            MySqlConnection Data = new MySqlConnection(pathToData);
            try
            {
                using (Data)
                {
                    Data.Open();
                    string MySqlString = @"DELETE FROM appointment WHERE appointmentId = @appointmentId";
                    MySqlCommand mySqlCommand = new MySqlCommand(MySqlString, Data);
                    mySqlCommand.Parameters.AddWithValue("@appointmentId", appointment.appointmentId);

                    mySqlCommand.ExecuteNonQuery();
                    return true;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error Deleteing User From Database");
                return false;
            }

        }

        public bool Adduser(user user)
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            using (Data)
            {
                Data.Open();
                var mySqlString = @"INSERT INTO user (userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                      Values(@userName, @password, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

                MySqlCommand mySqlCommand = new MySqlCommand(mySqlString, Data);
                mySqlCommand.Parameters.AddWithValue("@userName", user.userName);
                mySqlCommand.Parameters.AddWithValue("@password", user.password);
                mySqlCommand.Parameters.AddWithValue("@active", 1);
                mySqlCommand.Parameters.AddWithValue("@createDate", DateTime.Now);
                mySqlCommand.Parameters.AddWithValue("@createdBy", "system");
                mySqlCommand.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                mySqlCommand.Parameters.AddWithValue("@lastUpdateBy", "system");
                mySqlCommand.ExecuteNonQuery();
                return true;
            }
        }
        




        public List<user> GetUsers()
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            using (Data)
            {
                Data.Open();
                var userList = new List<user>();

                var mySqlString = @"SELECT userName,password
                                FROM user";
                MySqlCommand mySqlCommand = new MySqlCommand(mySqlString, Data);
                var reader = mySqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    var user = new user() { userName = reader["userName"].ToString(), password = reader["password"].ToString() };
                    userList.Add(user);
                }
                return userList;
            }
        }
        public List<appointmentUI> GetAppointmentUIs()
        {
            MySqlConnection Data = new MySqlConnection(pathToData);
            using (Data) {
                Data.Open();
                var returningList = new List<appointmentUI>();
                //ADD UI CODE HERE
        //public string customerName { get; set; }
        //public string Appoinment { get; set; }
        //public string AppoimentTime { get; set; }

                var mySqlString = "SELECT C.customerName,C.customerId, A.title, A.start, A.appointmentId FROM customer AS C INNER JOIN appointment as A ON C.customerId = A.customerId";
                MySqlCommand mySqlCommand = new MySqlCommand(mySqlString,Data);
                var reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var appointmentUI = new appointmentUI() { customerId = Convert.ToInt32(reader["customerId"]),customerName = reader["customerName"].ToString(), AppoimentTime = TimeZoneInfo.ConvertTimeFromUtc((DateTime)reader["start"], TimeZoneInfo.Local).ToString(), Appoinment = reader["title"].ToString(), AppointmentId = Convert.ToInt32(reader["appointmentId"])};

                    returningList.Add(appointmentUI);
                }
                return returningList;
            } 
        }

        


    }
}