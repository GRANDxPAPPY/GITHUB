using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_2_969_Schedule_desktop_app
{
    public static class  ErrorDetection
    {
        public static bool IsEmpty(string userString)
        {
            if (String.IsNullOrWhiteSpace(userString))
            {

                MessageBox.Show("All fields must be filled before any submission");
                return true;
            }
            else {
                return false;
            }
        }

        public static void CorrectFormat(string phoneNumber)
        {
            var allowableChar = new string[11] {"1","2","3","4","5","6","7","8","9","0","-" };
            foreach (var element in phoneNumber.ToArray())
            {
                if (allowableChar.Contains(element.ToString()))   
                {
                    return;
                }
                else {
                    break;
                }
            }
            MessageBox.Show("Phone number only allows whole numbers and -");
        }
    }
}
