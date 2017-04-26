using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace newLife
{
    /// <summary>
    /// Interaction logic for NewPatient.xaml
    /// </summary>
    public partial class NewPatient : UserControl
    {
        // declaration of variable
        

       

        public NewPatient()
        {
          
            InitializeComponent();
           // this.LoadViewFromUri("/ClassLibrary1;component/myusercontrol.xaml");
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Attendant attendant = new Attendant();
            attendant.Show();
        }

        private void Register(object sender, RoutedEventArgs e) {


            //MessageBox.Show("hello " + PCheckIn.SelectedDate.Value);
            // MessageBox.Show);
            Validate();
        }
        private void Validate()
        {
            //declaring local variable that holds text from input forms
            string Patient_firstname, Patient_middlename, Patient_lastname,
            Patient_region, Patient_zone, Patient_town, Patient_kebele,
            Patient_marriage_status, Patient_ethinicity, PatientOccupation,
            Patient_religion, Patient_hospital;
            DateTime Patient_checkin;
            string Patient_age;





            //checks all forms not to be empty !!!!!!!!!!!!!!!
        if (First_Name.Text.Length == 0 || PMiddleName.Text.Length == 0 || PLastName.Text.Length == 0 ||
                PRegionCombo.Text.Length == 0 || POccupation.Text.Length == 0 || PAge.Text.Length == 0 || PCheckIn.Text.Length == 0 ||
                Pethinicity.Text.Length == 0 || PReligion.Text.Length == 0 || PTown.Text.Length == 0 || PZone.Text.Length == 0 ||
                Phospital.Text.Length == 0 || PMarriage.Text.Length == 0 || PKebele.Text.Length == 0 ||
                Patient_Sex.Length == 0)
            {

                ErrorMessageForPatients.Text = "Error!Unfilled form!";
                First_Name.SelectAll();
                First_Name.Focus();
                //First_Name.Select(0, First_Name.Text.Length);
                //First_Name.Focus();

            }
            else {
                Patient_firstname = First_Name.Text;
                Patient_middlename = PMiddleName.Text;
                Patient_lastname = PLastName.Text;
                Patient_region = PRegionCombo.SelectedValue.ToString();
                PatientOccupation = POccupation.Text;
                Patient_age = PAge.Text;
                Patient_checkin = DateTime.Parse(PCheckIn.SelectedDate.Value.ToString());
                Patient_ethinicity = Pethinicity.Text;
                Patient_religion = PReligion.Text;
                Patient_town = PTown.Text;
                Patient_zone = PZone.Text;
                Patient_hospital = Phospital.Text;
                Patient_kebele = PKebele.Text;
                Patient_marriage_status = PMarriage.SelectedValue.ToString();


                if (!Regex.IsMatch(First_Name.Text, "^[a-zA-Z]*$") || !Regex.IsMatch(PMiddleName.Text, "^[a-zA-Z]*$") || !Regex.IsMatch(PLastName.Text, "^[a-zA-Z]*$"))
                {
                    //validate full name
                    ErrorMessageForPatients.Text = "full name should be String!";
                    First_Name.Select(0, First_Name.Text.Length);
                    First_Name.Focus();
                }

                // else if(PCheckIn.Text != DateTime.Now.ToString()) {
                //  ErrorMessageForPatients.Text = "invalid date";

                // }


                else if (!Regex.IsMatch(PZone.Text, "^[a-zA-Z]*$") || !Regex.IsMatch(PTown.Text, "^[a-zA-Z]*$"))
                {
                    ErrorMessageForPatients.Text = "should be correct name";    //validate zone and town should be string
                }
                else if ((!Regex.IsMatch(PKebele.Text, "^[0-9]*$ ") || !Regex.IsMatch(PKebele.Text, "^[a-zA-Z]*$")) && !(PKebele.Text.Length >= 2))
                {
                    ErrorMessageForPatients.Text = "atleast 2 charactes";
                    PKebele.SelectAll();
                    PKebele.Focus();
                }
                else if (!Regex.IsMatch(PAge.Text, "^[0-9]*$"))//&&(!Regex.IsMatch(PAge.Text, "^[\d\D]{0,3}$")

                {
                    ErrorMessageForPatients.Text = "age should be number";
                    PAge.SelectAll();
                    PAge.Focus();
                    
                }
                else if (!Regex.IsMatch(Pethinicity.Text, "^[a-zA-Z]*$") || !Regex.IsMatch(Phospital.Text, "^[a-zA-Z]*$") || !Regex.IsMatch(POccupation.Text, "^[a-zA-Z]*$") || !Regex.IsMatch(PReligion.Text, "^[a-zA-Z]*$"))
                {
                    ErrorMessageForPatients.Text = "field must be string";
                    Pethinicity.SelectAll();
                    Pethinicity.Focus();

                }
                else
                {
                    ErrorMessageForPatients.Text = "";
                   PatientContext PatientsRegistration = new PatientContext();
                    NewPatient Patient_Database = new NewPatient();

                    Patient_Database.Patient_FirstName = Patient_firstname.Trim();
                    Patient_Database.Patient_MiddleName = Patient_middlename.Trim();
                    Patient_Database.Patient_LastName = Patient_lastname.Trim();
                    Patient_Database.Patient_Region = Patient_region.Trim();
                    Patient_Database.Patient_Zone = Patient_zone.Trim();
                    Patient_Database.Patient_Town = Patient_town.Trim();
                    Patient_Database.Patient_Kebele = Patient_kebele.Trim();
                    Patient_Database.Patient_Sex = Patient_Sex.Trim();
                    Patient_Database.Patient_Age = Convert.ToInt16(Patient_age);
                    Patient_Database.Patient_CheckIn = Patient_checkin;
                    Patient_Database.Patient_Marriage_Status = Patient_marriage_status;
                    Patient_Database.Patient_Ethinicity = Patient_ethinicity.Trim();
                    Patient_Database.Patient_occupation = PatientOccupation.Trim();
                    Patient_Database.Patient_Religion = Patient_religion.Trim();
                    Patient_Database.Patient_Referred_From = Patient_hospital.Trim();


                    try
                    {
                        // Your code...
                        // Could also be before try if you know the exception occurs in SaveChanges

                        PatientsRegistration.NewPatients.Add(Patient_Database);
                        PatientsRegistration.SaveChanges();
                        Reset();

                    }
                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                    }

                }

            }

            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // ... Get RadioButton reference.
            var button = sender as RadioButton;

            // ... Display button content as title.
            Patient_Sex = button.Content.ToString();
        }

      
      
        private void Reset()
        {
            First_Name.Text = "";
            PMiddleName.Text = "";
            PLastName.Text = "";
            PRegionCombo.Text = "";
            POccupation.Text = "";
            PAge.Text = "";
            Pethinicity.Text = "";
            PReligion.Text = "";
            Phospital.Text = "";
            PKebele.Text = "";
            PMarriage.Text = "";
            PZone.Text = "";
            PCheckIn.Text = "";
            Patient_Sex = "";

        }

       

    }
}
