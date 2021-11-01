using System;
using System.Collections.Generic;

public class Inventory : Metalfruit
{
    public List<string> inventory { get; set; }
    public List<int> quantity { get; set; }

    public Inventory()
    {
        inventory = new List<string>();
        quantity = new List<int>();
    }

    // Show current inventory 
    public void showInventory()
    {
        if (inventory.Count > 0)
        {
            for (int i = 0; i < inventory.Count; i++)
            {

                Console.Write($"Commodity: {inventory[i]}, Quantity: {quantity[i]} \n");
            }
        }
        else
        {
            Console.WriteLine("Your inventory in empty! \n");

        }
    }


    //Buy method - increase exist quantity in inventory
    public List<int> BuyQuanChange(int userQuantity, int k)
    {
        quantity[k] += userQuantity;
        return quantity;
    }
    // Buy method - Add commodity to inventory
    public List<string> BuyInvenChange(string userChoice)
    {
        inventory.Add(userChoice);
        return inventory;
    }
    // Buy method - Add quantity into inventory
    public List<int> BuyQChange(int userQuantity)
    {
        quantity.Add(userQuantity);
        return quantity;
    }


    // Sell method - Decrease exist quantity in inventory
    public List<int> SellQuanChange(int userQuantity, int k)
    {
        quantity[k] -= userQuantity;
        return quantity;
    }
    // // Sell method - Remove commodity from inventory
    // public List<string> BuyInvenChange(string userChoice)
    // {
    //     inventory.Add(userChoice);
    //     return inventory;
    // }
    // // Sell method - Remove quantity from inventory
    // public List<int> BuyQChange(int userQuantity)
    // {
    //     quantity.Add(userQuantity);
    //     return quantity;
    // }

}