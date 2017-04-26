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
    /// Interaction logic for Beds.xaml
    /// </summary>
    public partial class Beds : UserControl
    {
        public Beds()
        {
            InitializeComponent();
        }

        private void Button_Submit_Bed_Click(object sender, RoutedEventArgs e)
        {
            BuildingAdder adder = new BuildingAdder();
            Building build = new Building();

            string BuildingName = buildingName.Text;
            string BuildingStory = buildingStory.Text;
            string BuildingWardName = buildingWardName.Text;
            string BuildingFlorr = buildingWardFloor.Text;
            string BuildingRoom = buildingRoom.Text;
            string BuildingCapacity = buildingRoomCapacity.Text;
            

            if(BuildingName.Length == 0|| BuildingStory.Length == 0||
                BuildingWardName.Length == 0|| BuildingFlorr.Length == 0||
                BuildingRoom.Length==0|| BuildingCapacity.Length == 0)
            {
                BuildingError.Text = "**please fill all space provided!! **!";
            }
            else
            {
                if (!Regex.IsMatch(buildingName.Text, "^[a-zA-Z]*$"))
                {
                    BuildingError.Text = "Building Name must be Letters";
                    buildingName.SelectAll();
                    buildingName.Focus();

                }
                else if(!Regex.IsMatch(buildingStory.Text, "^[0-9]+$"))
                {
                    BuildingError.Text = "total Store cannot be letters";
                    buildingStory.SelectAll();
                    buildingStory.Focus();
                }
                else if (!Regex.IsMatch(buildingWardName.Text, "^[a-zA-Z]*$"))
                {
                    BuildingError.Text = "Ward name must be  letters";
                    buildingWardName.SelectAll();
                    buildingWardName.Focus();

                }
                else if (!Regex.IsMatch(buildingWardFloor.Text, "^[0-9]+$"))
                {
                    BuildingError.Text = "Floor number should be Integer!!";
                    buildingWardFloor.SelectAll();
                    buildingWardFloor.Focus();
                }
                else if (!Regex.IsMatch(buildingRoom.Text, "^[0-9]+$"))
                {
                    BuildingError.Text = "Room should Integer!";
                    buildingRoom.SelectAll();
                    buildingRoom.Focus();

                }
                else if (!Regex.IsMatch(buildingRoomCapacity.Text, "^[0-9]+$"))
                {
                    BuildingError.Text = "Room capacity should be Integer";
                    buildingRoomCapacity.SelectAll();
                    buildingRoomCapacity.Focus();
                }
                else
                {
                    BuildingError.Text = "";
                    build.Building_Name = BuildingName;
                    build.Building_totalStory = int.Parse(BuildingStory);
                    build.B_WardName = BuildingWardName;
                    build.B_WardFloor = BuildingFlorr;
                    build.B_RoomNumber = BuildingRoom;
                    build.B_RoomCapacity = int.Parse(BuildingCapacity);
                   

                    try
                    {
                        // Your code...
                        // Could also be before try if you know the exception occurs in SaveChanges

                        adder.Buildings.Add(build);
                        adder.SaveChanges();
                       
                        MessageBox.Show("Successfully Added");
                        Reset();
                       

                    }
                    catch (DbEntityValidationException r)
                    {
                        foreach (var eve in r.EntityValidationErrors)
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

        private void Reset()
        {
            buildingName.Text = "";
            buildingStory.Text = "";
            buildingWardName.Text = "";
            buildingWardFloor.Text = "";
            buildingRoom.Text = "";
            buildingRoomCapacity.Text = "";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillCombo();
        }
        private void fillCombo() {

            using (BuildingAdder c = new BuildingAdder())
            {

                var query = (from a in c.Buildings
                             select new { a.Building_Name }).First();
                if (query != null)
                {
                   // Bed_number.SelectedText =int.Parse( query.Building_Name);
                    // MessageBox.Show(comboBed.SelectedItem.ToString());
                   // Console.WriteLine("this is the tryial", comboBed.SelectedItem.ToString());

                }
                 

            }
        }
    }
}
