using Newtonsoft.Json;
using System;
using System.IO;

namespace InventoryMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inventory");
            Console.WriteLine("Welcome to inventory");
            InventoryManager manager = new InventoryManager();
            string file = @"C:\Users\Lenovo\Desktop\Inventory Management Application\InventoryMangement\InventoryMangement\json1.json";
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(file));
            Console.WriteLine("Display inventory Press 1-Rice Inventory 2-Wheat Inventory 3-Pulse Inventory ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    manager.DisplayInventory(utility.RiceList);
                    break;
                case 2:
                    manager.DisplayInventory(utility.WheatList);
                    break;
                case 3:
                    manager.DisplayInventory(utility.PulseList);
                    break;
            }
        }
    }
}
