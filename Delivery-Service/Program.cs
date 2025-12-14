namespace Delivery_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryTruck deliveryTruck = new DeliveryTruck("Delivery Truck", 1000);
            RefrigeratedTruck refrigeratedTruck = new RefrigeratedTruck("Refrigerated Truck", 1200);
            CourirVan courirVan = new CourirVan("Courir Van", 800);

            deliveryTruck.StartEngine();
            refrigeratedTruck.StartEngine();
            courirVan.StartEngine();

            deliveryTruck.LoadCargo(1550);
            deliveryTruck.UnloadCargo(1200);

            Console.WriteLine("__________________________");

            IDeliverable[] myFleet = { deliveryTruck, refrigeratedTruck, courirVan };

            foreach (IDeliverable truck in myFleet)
            {
                deliveryTruck.LoadCargo(50);
                Console.WriteLine("Requires special docking: " + deliveryTruck.RequiresSpecialDocking);
                refrigeratedTruck.LoadCargo(50);
                Console.WriteLine("Requires special docking: " + refrigeratedTruck.RequiresSpecialDocking);
                courirVan.LoadCargo(50);
                Console.WriteLine("Requires special docking: " + courirVan.RequiresSpecialDocking);
            }

            Console.ReadKey();
        }
    }
}
