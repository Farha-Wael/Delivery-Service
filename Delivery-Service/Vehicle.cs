using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Service
{
    public class DeliveryTruck: IDeliverable
    {
        string truckName;
        int currentLoadWeight;
        int maxLoadCapacity;
        public DeliveryTruck(string truckName,  int maxLoadCapacity)
        {
            this.truckName = truckName;
            this.maxLoadCapacity = maxLoadCapacity;
            this.currentLoadWeight = 0;
        }
        public string TruckName
        {
            get { return truckName; }
        }
        public int CurrentLoadWeight
        {
            get { return currentLoadWeight; }
            set
            {
                if (value < 0)
                {
                    currentLoadWeight = 0;
                    Console.WriteLine("Warning!!! load capacity can't be negative, so the load capacity setted to 0");

                }
                else if(value> maxLoadCapacity)
                {
                    currentLoadWeight = maxLoadCapacity;
                    Console.WriteLine("Warning!!! load capacity can't exceed " + maxLoadCapacity);
                }
                else
                {
                    currentLoadWeight = value;
                }
            }
        }
        public virtual void StartEngine()
        {
            Console.WriteLine("DeliveryTruck engine started.");
        }
        public virtual bool RequiresSpecialDocking
        {
            get { return false; }
        }
        public virtual void LoadCargo(int weight)
        {
            CurrentLoadWeight += weight;
            Console.WriteLine(TruckName+"'s current load is "+ CurrentLoadWeight);
        }
        public virtual void UnloadCargo(int weight)
        {
            CurrentLoadWeight -= weight;
            Console.WriteLine(TruckName + "'scurrent load is " + CurrentLoadWeight);
        }
    }
}