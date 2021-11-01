using System;
using System.Collections.Generic;
namespace BuySell
{
    class Program
    {
        static void Main(string[] args)
        {
            Metals metal = new Metals("gold", "silver", "iron", "bronze", "titanium");
            metal.listMetals.Add(metal.gold, 88);
            metal.listMetals.Add(metal.silver, 44);
            metal.listMetals.Add(metal.iron, 15);
            metal.listMetals.Add(metal.bronze, 8);
            metal.listMetals.Add(metal.titanium, 98);

            Fruits fruit = new Fruits("apple", "orange", "melon", "grapefriut", "strawberrie");
            fruit.listFruits.Add(fruit.apple, 2);
            fruit.listFruits.Add(fruit.orange, 3);
            fruit.listFruits.Add(fruit.melon, 5);
            fruit.listFruits.Add(fruit.grapefruit, 4);
            fruit.listFruits.Add(fruit.strawberrie, 5);

            List<Dictionary<string, int>> dicti = new List<Dictionary<string, int>>();
            dicti.Add(metal.listMetals);
            dicti.Add(fruit.listFruits);

            // user inventory
            Inventory inventory = new Inventory();

            Metalfruit metafru = new Metalfruit();
            // int balance;
            Balance balance = new Balance();
            balance.balance = 400;

            while (true)
            {
                List<string> menu = new List<string>
                {"1 - current prices","2 - Show current inventory",
                "3 - Show current Cash Balance","4 - Buy something",
                "5 - Sell something","6 - End turn"};

                Console.WriteLine("== choose from the list ==");
                menu.ForEach(i => Console.WriteLine(i));
                string usrChoice = Console.ReadLine();

                if (usrChoice == "1")
                {
                    displayList(metal.listMetals, fruit.listFruits);
                }
                else if (usrChoice == "2")
                {
                    inventory.showInventory();
                }
                else if (usrChoice == "3")
                {
                    balance.ShowBalance();
                }
                else if (usrChoice == "4")
                {
                    Console.WriteLine("Enter commodity name to buy: ");
                    string userChoice = Console.ReadLine();
                    Console.WriteLine("Enter quantity: ");
                    int userQuantity = Convert.ToInt32(Console.ReadLine());
                    foreach (Dictionary<string, int> i in dicti)
                    {
                        foreach (KeyValuePair<string, int> k in i)
                        {
                            if (userChoice == k.Key)
                            {
                                int priceOfCommodity = k.Value;
                                int decNum = priceOfCommodity * userQuantity;
                                if (balance.balance > decNum)
                                {
                                    if (inventory.inventory.Contains(userChoice))
                                    {
                                        int index = inventory.inventory.IndexOf(userChoice);
                                        inventory.BuyQuanChange(userQuantity, index);
                                        balance.DecreaseBalance(userQuantity, decNum);
                                        break;
                                    }
                                    else
                                    {
                                        inventory.BuyInvenChange(userChoice);
                                        inventory.BuyQChange(userQuantity);
                                        balance.DecreaseBalance(userQuantity, decNum);
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("insufficient funds");
                                }
                            }
                        }
                    }
                }
                else if (usrChoice == "5")
                {
                    Console.WriteLine("Enter commodity name to sell: ");
                    string userChoice = Console.ReadLine();
                    Console.WriteLine("Enter quantity: ");
                    int userQuantity = Convert.ToInt32(Console.ReadLine());

                    if (inventory.inventory.Contains(userChoice))
                    {
                        int index = inventory.inventory.IndexOf(userChoice);
                        metafru.priceOf(dicti, userChoice);
                        int sellPrice = metafru.price * userQuantity;
                        inventory.SellQuanChange(userQuantity, index);
                        balance.IncreaseBalance(userQuantity, sellPrice);
                        if (inventory.quantity[index] == 0)
                        {
                            inventory.quantity.Remove(inventory.quantity[index]);
                            inventory.inventory.Remove(inventory.inventory[index]);
                        }

                    }

                }
                else
                {
                }
                // Method to display current prices of the commodities
                static void displayList(Dictionary<string, int> list1, Dictionary<string, int> list2)
                {
                    foreach (KeyValuePair<string, int> i in list1)
                    {
                        Console.Write($"{i.Key} = {i.Value}£ ");
                    }
                    Console.WriteLine("");
                    foreach (KeyValuePair<string, int> i in list2)
                    {
                        Console.Write($"{i.Key} = {i.Value}£ ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}

