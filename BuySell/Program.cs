using System;
using System.Collections.Generic;
using System.Linq;

namespace BuySell
{
    class Program
    {
        static void Main(string[] args)
        {
            Metals metal = new Metals();
            metal.metals.Add("gold");
            metal.metals.Add("silver");
            metal.metals.Add("iron");
            metal.metals.Add("bronze");
            metal.metals.Add("titanium");
            metal.metPrices.Add(88);
            metal.metPrices.Add(60);
            metal.metPrices.Add(42);
            metal.metPrices.Add(55);
            metal.metPrices.Add(90);

            Fruits fruit = new Fruits();
            fruit.fruits.Add("apple");
            fruit.fruits.Add("orange");
            fruit.fruits.Add("melon");
            fruit.fruits.Add("grapefruit");
            fruit.fruits.Add("strawberrie");
            fruit.fruPrices.Add(3);
            fruit.fruPrices.Add(5);
            fruit.fruPrices.Add(7);
            fruit.fruPrices.Add(6);
            fruit.fruPrices.Add(2);

            List<object> commodities = new List<object>();
            commodities.Add(metal.metals);
            commodities.Add(fruit.fruits);
            List<object> allPrices = new List<object>();
            allPrices.Add(metal.metPrices);
            allPrices.Add(fruit.fruPrices);

            // user inventory
            Inventory inventory = new Inventory();

            // List of Commodity Dictinary
            Metalfruit metafru = new Metalfruit();

            metafru.dicMetal = metal.metals.Zip(metal.metPrices, (k, v) => new { k, v }).ToDictionary(x => x.k, x => x.v);
            metafru.dicFruit = fruit.fruits.Zip(fruit.fruPrices, (k, v) => new { k, v }).ToDictionary(x => x.k, x => x.v);
            metafru.listOfDic.Add(metafru.dicMetal);
            metafru.listOfDic.Add(metafru.dicFruit);

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
                    metal.DisplayMetal();
                    fruit.DisplayFruit();
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
                    foreach (Dictionary<string, int> i in metafru.listOfDic)
                    {
                        foreach (KeyValuePair<string, int> k in i)
                        {
                            metafru.priceOf(k.Key, userChoice, k.Value);
                        }
                    }
                    int decNum = metafru.price * userQuantity;
                    if (balance.balance > decNum)
                    {
                        if (inventory.inventory.Contains(userChoice))
                        {
                            int index = inventory.inventory.IndexOf(userChoice);
                            inventory.BuyQuanChange(userQuantity, index);
                            balance.DecreaseBalance(userQuantity, decNum);
                        }
                        else
                        {
                            inventory.BuyInvenChange(userChoice);
                            inventory.BuyQChange(userQuantity);
                            balance.DecreaseBalance(userQuantity, decNum);
                        }
                    }
                    else
                    {
                        Console.WriteLine("insufficient funds");
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
                        foreach (Dictionary<string, int> i in metafru.listOfDic)
                        {
                            foreach (KeyValuePair<string, int> k in i)
                            {
                                metafru.priceOf(k.Key, userChoice, k.Value);
                            }
                        }
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
                else if (usrChoice == "6")
                {
                    Random rand = new Random();
                    int rando = rand.Next(0, 7);



                }
                // Method to display current prices of the commodities
                // static void displayList(Dictionary<string, int> list1, Dictionary<string, int> list2)
                // {
                //     foreach (KeyValuePair<string, int> i in list1)
                //     {
                //         Console.Write($"{i.Key} = {i.Value}£ ");
                //     }
                //     Console.WriteLine("");
                //     foreach (KeyValuePair<string, int> i in list2)
                //     {
                //         Console.Write($"{i.Key} = {i.Value}£ ");
                //     }
                //     Console.WriteLine("\n");
                // }
            }
        }
    }
}

