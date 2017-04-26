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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window


    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CAccount_Click(object sender, RoutedEventArgs e)
        {
            DBnewLifeEntities1 db = new DBnewLifeEntities1();
            Register_Users register = new Register_Users();

            string F_name, S_name, password,C_phone;
            F_name = Firstname.Text;
            S_name = secondname.Text;
            password = ppassword.Password;
            C_phone = pphone.Text;

            

            if (Firstname.Text.Length == 0 || secondname.Text.Length == 0 || ppassword.Password.Length == 0 ||
                Re_password.Password.Length == 0 || pphone.Text.Length == 0)

            {
                errorMessage.Text = "**** Please fill all Boxes ****";
            }
            else
            {

                if (!Regex.IsMatch(Firstname.Text, "^[a-zA-Z]*$"))
                {
                    errorMessage.Text = "First Name must be Letters";
                    Firstname.Select(0, Firstname.Text.Length);
                    Firstname.Focus();
                }
                else if (!Regex.IsMatch(secondname.Text, "^[a-zA-Z]*$"))
                {
                    errorMessage.Text = "Second Name must be Letters!";
                    secondname.Select(0, secondname.Text.Length);
                    secondname.Focus();
                }
                else if (!Regex.IsMatch(pphone.Text, "^[0-9]+$"))
                {
                    errorMessage.Text = "phone number Cannot be Letter!";
                    pphone.Select(0, pphone.Text.Length);
                    pphone.Focus();
                }
                else if (!Regex.IsMatch(ppassword.Password, "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^(.{8,15})$")) 
                {
                    errorMessage.Text = "password must contain letters and numbers atleast 8";
                    ppassword.SelectAll();
                    ppassword.Focus();


                }
                else if(Re_password.Password != ppassword.Password)
                {
                    errorMessage.Text = "confirmation should be same to password!";
                }
                
                    register.First_Name = F_name;
                    register.Second_Name = S_name;
                    register.Phone_No = C_phone;
             
                register.Password_user = password;
                    db.Register_Users.Add(register);
                    db.SaveChanges();

                    Reset();
                
            }     


        }
        private  void  Reset()
        {
            Firstname.Text = "";
            secondname.Text = "";
            pphone.Text = "";
            ppassword.Password = "";
            Re_password.Password = "";

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
