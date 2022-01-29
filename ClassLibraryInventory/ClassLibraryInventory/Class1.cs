using System;

namespace ClassLibraryInventory
{
    interface IInventory
    {
        public void check_inventory();
     
    }

    public class Inventory : IInventory
    {
        public void check_inventory()
        {
            Console.WriteLine("Checking inventory for the target product...");
            Console.WriteLine();
            Console.WriteLine("The target product is available...");
            Console.WriteLine();
        }

    }
}