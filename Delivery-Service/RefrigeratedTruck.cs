using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Service
{
    public class RefrigeratedTruck : DeliveryTruck
    {
        string truckName;
        int currentLoadWeight;
        int maxLoadCapacity;
        public RefrigeratedTruck(string truckName, int maxLoadCapacity) : base(truckName, maxLoadCapacity)
        {
            this.truckName = truckName;
            this.maxLoadCapacity = maxLoadCapacity;
            this.currentLoadWeight = 0;
        }

        public override bool RequiresSpecialDocking
        {
            get { return true; }
        }

        public override void StartEngine()
        {
            Console.WriteLine("RefrigeratedTruck engine started with cooling system.");
        }
    }


}