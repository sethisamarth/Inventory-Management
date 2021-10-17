using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMangement
{
    class InventoryManager
    {
        public void DisplayInventory(List<InventoryUtility.Rice> Ricelist)
        {
            foreach (InventoryUtility.Rice i in Ricelist)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }

        }
        public void DisplayInventory(List<InventoryUtility.Wheat> WheatList)
        {
            foreach (InventoryUtility.Wheat i in WheatList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }
        }
        public void DisplayInventory(List<InventoryUtility.Pulse> PulseList)
        {
            foreach (InventoryUtility.Pulse i in PulseList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }
        }
    }
}
