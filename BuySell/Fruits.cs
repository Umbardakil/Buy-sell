
using System;
using System.Collections.Generic;
using System.Linq;
public class Fruits : IComfruit
{
    public Dictionary<string, int> listFruits { get; set; }
    public List<string> fruits { get; set; }
    public List<int> fruPrices { get; set; }
    public string apple { get; set; }
    public string orange { get; set; }
    public string melon { get; set; }
    public string grapefruit { get; set; }
    public string strawberrie { get; set; }
    public int priceOfCommodity { get; set; }
    public int ind { get; set; }

    public Fruits()
    {
        listFruits = new Dictionary<string, int>();
        fruits = new List<string>();
        fruPrices = new List<int>();
    }
    public int priceOf(string userChoice)
    {
        ind = fruits.IndexOf(userChoice);
        priceOfCommodity = fruPrices[ind];
        return priceOfCommodity;
    }
    public void DisplayFruit()
    {
        foreach (string i in fruits)
        {
            foreach (int k in fruPrices)
            {
                if (fruits.IndexOf(i) == fruPrices.IndexOf(k))
                    Console.WriteLine($"{i} = {k}£ ");
            }
        }
    }

    public List<int> fruitPriceDec(int random)
    {
        for (int i = 0; i < fruPrices.Count; i++)
        {
            fruPrices[i] -= fruPrices[i] * random / 100;
        }
        return fruPrices;
    }
    public List<int> fruitPriceIncrese(int random)
    {
        for (int i = 0; i < fruPrices.Count; i++)
        {
            fruPrices[i] += fruPrices[i] * random / 100;
        }
        return fruPrices;
    }
}


