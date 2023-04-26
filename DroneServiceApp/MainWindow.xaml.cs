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

// Mauriza Arianne
// DroneServiceApp
// 26/04/2023

namespace DroneServiceApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 6.2	Create a global List<T> of type Drone called “FinishedList”. 
        // 6.3	Create a global Queue<T> of type Drone called “RegularService”.
        // 6.4	Create a global Queue<T> of type Drone called “ExpressService”.
        List<Drone> FinishedList = new List<Drone>();
        Queue<Drone> RegularService = new Queue<Drone>();
        Queue<Drone> ExpressService = new Queue<Drone>();

        // 6.5	Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority.
        // Use TextBoxes for the Client Name, Drone Model, Service Problem and Service Cost.
        // Use a numeric up/down control for the Service Tag.
        // The new service item will be added to the appropriate Queue based on the Priority radio button.
        public void AddNewItem()
        {
            Drone newDrone = new Drone();
            newDrone.setClientName(txtClientName.Text);
            newDrone.setDroneModel(txtDroneModel.Text);
            newDrone.setServiceProblem(txtServiceProblem.Text);
            newDrone.setServiceTag(txtServiceTag.Text);
            newDrone.setServiceCost(txtServiceCost.Text);
            


        }

        private void btnServiceTagInc_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtServiceTag.Text, out int tag))
            {
                if(tag < 900) txtServiceTag.Text = (tag + 10).ToString();
            }
        }
        private void btnServiceTagDec_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtServiceTag.Text, out int tag))
            {
                if (tag > 100) txtServiceTag.Text = (tag - 10).ToString();
            }
        }
    }
}
