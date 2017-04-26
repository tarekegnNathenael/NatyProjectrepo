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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace newLife
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        PatientContext SearchPatient = new PatientContext();
        public Search()
        {
           
            InitializeComponent();
        }

        private void window_loaded(object sender, RoutedEventArgs e)
        {
            
             

            DisplayPatient.ItemsSource = SearchPatient.NewPatients.ToList();
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var searchResult = from pat in SearchPatient.NewPatients
                               where pat.Patient_FirstName.StartsWith("a")
                               select pat;
            MessageBox.Show(searchResult.ToString());
        }
    }
}
