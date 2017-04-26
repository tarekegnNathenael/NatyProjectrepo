using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace newLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

        Boolean login = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string userName, User_password;
            userName = username.Text;
            User_password = password.Password;
            if (userName.Length == 0 || User_password.Length == 0)

            {
                errorMessagelog.Text = "**** Empty form,PLEASE FILL ALL FORMS!! ****";
                username.Select(0, username.Text.Length);
                password.SelectAll();
                password.Focus();
                username.Focus();
            }
            else
            {
                using (var Context = new DBnewLifeEntities1())
                {

                    var result = from p in Context.Register_Users
                                 select p.First_Name;
                    var result2 = from k in Context.Register_Users
                                  select k.Password_user;

                    foreach (var item in result)
                    {
                        if (userName == item)
                        {
                            login = true;
                        }
                    }
                    foreach (var ll in result2)
                    {
                        if (User_password == ll)
                        {
                            login = true;
                        }
                    }

                    if (login)
                    {
                        Whole got = new Whole();
                        got.Show();
                        Close();

                    }
                    else
                    {

                        errorMessagelog.Text = "Wrong password or UserName!";
                    }
                }

            }

        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            CreateAccount hi = new CreateAccount();
            hi.Show();
            Close();

        }

        private void Forgot_Click(object sender, RoutedEventArgs e)
        {
            Whole got = new Whole();
            got.Show();
            Close();
        }
    }
}
