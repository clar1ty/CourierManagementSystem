using System;
using System.Collections.Generic;

namespace CourierManagementSystem
{
    public class DispatchCourier 
        //purpose: assign couriers for a parcel and then dispatch him/her
        //related with order class
    { 
    
        public string Courier { get; set; }
        public string Order { get; set; }
       

        static void DisplayCourierList()
        {
        var couriers = new List<string>()
            {"Name\t Age\t Proficiency\n",
             "Moriarty 26\t Solid\n",
             "Holmes\t 26\t Solid\n",
             "Clarke\t 20\t AMateur\n"};
                foreach (var name in couriers)
                {
                    Console.Write(name);
                }
        }

        static void DisplayOrder()
        {
            var orders = new List<string>()
            {"Order #\t\tType 2\tDestination",
              "1\tSmall Computer Peripheral\tBinan, Laguna",
              "2\tClothing\tLipa, Batangas",
              "3\tSmall Bicycle Parts\tRizal"};
            foreach (var item in orders)
            {
                Console.Write(item);
            }
        }

        
    }
}
