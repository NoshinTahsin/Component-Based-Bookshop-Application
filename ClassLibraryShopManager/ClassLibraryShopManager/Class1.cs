﻿using System;
using ClassLibraryInventory;

namespace ClassLibraryShopManager
{
    interface IShopManager
    {
        public void confirm_order();
        public void update_cart();
        public void send_order();
    }

    public class ShopManager : IShopManager
    {
        Inventory inventory = new Inventory();
        public void confirm_order()
        {
            inventory.check_inventory();
            Console.WriteLine("Order confirmed.");
        }
        public void update_cart()
        {
            Console.WriteLine("Cart updated.");
        }
        public void send_order()
        {
            Console.WriteLine("We have sent your parcel to the courier service. You'll receive it within 5-7 days. Thank you.");
        }
    }
}