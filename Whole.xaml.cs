using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for Whole.xaml
    /// </summary>
    public partial class Whole : Window
    {
        public Whole()
        {
            InitializeComponent();
           
        }

    

        private void MenuItem_Patient(object sender, RoutedEventArgs e)
        {
            NewPatient patientPage = new NewPatient();
            center.Children.Add(patientPage);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            update updata = new update();
            center.Children.Add(updata);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Report rep = new Report();
            center.Children.Add(rep);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Search search = new Search();
            center.Children.Add(search);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Building build = new Building();
            center.Children.Add(build);
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            ShowUser ward = new ShowUser();
            center.Children.Add(ward);
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Users room = new Users();
            center.Children.Add(room);
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Beds bed = new Beds();
            center.Children.Add(bed);
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            Users addUser = new Users();
            center.Children.Add(addUser);
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            ShowBed showBed = new ShowBed();
            center.Children.Add(showBed);

        }
    }
}
