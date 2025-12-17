using WinFormsApp1;

namespace WinFormsApp1

{


    public static class InvalidData {


        public static bool Exception(string userInput) {
            try {
                int.Parse(userInput);
                return true;
            }
            catch (FormatException) {
                //throw new ArgumentException("Invalid Data Entered");
                MessageBox.Show("Enter Valid Integer");
                return false;
            }


        }

        public static bool exceptionRed(string numb)
        {
            try
            {
                int.Parse(numb);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static bool confirmDelete() {
            var x = MessageBox.Show("Confirm to delete", "", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                
                return true;
            }
            else {

                return false;
            }
        }
    } }

//foreach (Control ctrl in this.Controls)
//{
//    if (ctrl is TextBox && InvalidData.exceptionRed(ctrl.Text) == false)
//    {
//        ctrl.ForeColor = Color.Red;