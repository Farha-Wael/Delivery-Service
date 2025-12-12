using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Service
{
    interface IDeliverable
    {
        bool RequiresSpecialDocking { get; }
        void LoadCargo(int weight);
        void UnloadCargo(int weight);
    }
}
