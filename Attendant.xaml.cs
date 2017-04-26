using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace newLife
{
    /// <summary>
    /// Interaction logic for Attendant.xaml
    /// </summary>
    public partial class Attendant : Window
    {
        public Attendant()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Attendant_FirstName, Attendant_LastName, Attendant_phone,Attendant_Card;
            PatientContext check = new PatientContext();
            


            if (AFirst_Name.Text.Length == 0|| ALast_Name_Copy.Text.Length == 0|| Aphone.Text.Length == 0||Acard.Text.Length == 0)
            {
                AttendantError.Text = "all forms should be filled!";
            }
            else
            {
                Attendant_FirstName = AFirst_Name.Text;
                Attendant_LastName = ALast_Name_Copy.Text;
                Attendant_phone = Aphone.Text;
                Attendant_Card = Acard.Text;

                if (!Regex.IsMatch(AFirst_Name.Text, "^[a-zA-Z]*$"))
                {
                    AttendantError.Text = "First Name must be Text";
                    AFirst_Name.SelectAll();
                    AFirst_Name.Focus();
                }
                else if (!Regex.IsMatch(ALast_Name_Copy.Text, "^[a-zA-Z]*$"))
                {
                    AttendantError.Text = "Last Name should be Text";
                }
                else if (!Regex.IsMatch(Aphone.Text, "^[0-9]*$^(.{10,11})$"))
                {
                    AttendantError.Text = "phone number should be integer!";
                }
                else if (true)
                {
                    //something to do with inserting id of patient to attendant automatically
                }

            }



        }

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {
            // ... Get RadioButton reference.
            var button = sender as RadioButton;

            // ... Display button content as title.
            string Attendant_Sex = button.Content.ToString();
        }

       
    }
}
