using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_2_969_Schedule_desktop_app
{
    
    public partial class Login : Form
    {
        DataService DataService = new DataService();
        string errorMessage = "Incorrect UserName or Password";
        string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login_History.txt");
        bool messageBoxShown = true;
        public Login()
        {
            InitializeComponent();
        }

        private void helloLabel_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var userLogin = new user() { userName = userNameTextbox.Text, password = passwordTextBox.Text };
            var userList = DataService.GetUsers();
                foreach(var user in userList)
            {
                if(user.userName == userLogin.userName && user.password == userLogin.password )
                {
                        var x = new CustomerRecords();
                        x.ShowDialog();
                    string logEntry = userNameTextbox.Text + " " + DateTime.Now.ToString() + Environment.NewLine;
                    File.AppendAllText(logPath, logEntry);
                    messageBoxShown = false;
                }
                

                
            }
            if (messageBoxShown == true)
            {
                MessageBox.Show("Incorrect UserName or Password");
            }
        }

        public void Lang()
        {
            var x = System.Globalization.CultureInfo.CurrentCulture; ;
            var y =System.Globalization.CultureInfo.CurrentUICulture;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var location = CultureInfo.CurrentCulture;
            //en-US
            //MessageBox.Show(location.ToString());
            
            if (CultureInfo.CurrentUICulture.Name.StartsWith("fr"))
            {
                helloLabel.Text = "bienvenu";
                loginLabel.Text = "se connecter";
                usernameLabel.Text = "nom d'utilisateur";
                passwordLabel.Text = "mot de passe";
                submitButton.Text = "soumettre";
                errorMessage = "Nom d'utilisateur ou mot de passe incorrect";
                return;
            }
            else
            {
                return;
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            var user = new user() { userName = userNameTextbox.Text, password = passwordTextBox.Text};
            if (String.IsNullOrWhiteSpace(userNameTextbox.Text) || String.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                return;
            }
            else
            {
                DataService.Adduser(user);
            }
        }
    }
}
