using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Service
{
    class CourirVan : DeliveryTruck
    {
        string truckName;
        int currentLoadWeight;
        int maxLoadCapacity;
        bool hasPremiumInterior;
        public CourirVan(string truckName, int maxLoadCapacity) : base(truckName, maxLoadCapacity)
        {
            this.truckName = truckName;
            this.maxLoadCapacity = maxLoadCapacity;
            this.currentLoadWeight = 0;
        }
        public bool HasPremiumInterior
        {
            get { return hasPremiumInterior; }
            set { hasPremiumInterior = value; }
        }

        public void ActivateClimateControl()
        {
            if (hasPremiumInterior)
            {
                Console.WriteLine("Climate control on.");
            }
            else
            {
                Console.WriteLine("Standard AC on.");
            }
        }

        public override bool RequiresSpecialDocking
        {
            get { return true; }

        }

        public override void StartEngine()
        {
            Console.WriteLine("Courir Van engine started smoothly.");
        }
    }
}
