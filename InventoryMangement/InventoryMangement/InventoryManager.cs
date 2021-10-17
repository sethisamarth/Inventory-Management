﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMangement
{
    class InventoryManager
    {
        public void DisplayInventory(List<InventoryUtility.Rice> ricelist)
        {
            foreach (InventoryUtility.Rice i in ricelist)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }

        }
        public void DisplayInventory(List<InventoryUtility.Wheat> wheatList)
        {
            foreach (InventoryUtility.Wheat i in wheatList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }
        }
        public void DisplayInventory(List<InventoryUtility.Pulse> pulseList)
        {
            foreach (InventoryUtility.Pulse i in pulseList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }
        }
    }
}
