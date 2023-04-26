using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneServiceApp
{
    class Drone
    {
        // 6.1	Create a separate class file to hold the data items of the Drone. Use separate getter and setter methods, ensure the attributes are private and the accessor methods are public.
        // Add a display method that returns a string for Client Name and Service Cost.
        // Add suitable code to the Client Name and Service Problem accessor methods so the data is formatted as Title case or Sentence case. Save the class as “Drone.cs”.

        private string clientName;
        private string droneModel;
        private string serviceProblem;
        private string serviceCost;
        private string serviceTag;

        public void displayDrone ()
        {

        }

        public string getClientName () { return clientName; }
        public string getDroneModel () { return droneModel; }
        public string getServiceProblem () { return serviceProblem;}
        public string getServiceCost () { return serviceCost;}
        public string getServiceTag () { return serviceTag;}

        public void setClientName (string input) { clientName = input; }
        public void setDroneModel (string input) { droneModel = input; }
        public void setServiceProblem (string input) { serviceProblem = input; }
        public void setServiceCost (string input) { serviceCost = input; }
        public void setServiceTag (string input) { serviceTag = input; }


    }
}
