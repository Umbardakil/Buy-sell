
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


    // public int price { get; set; }


    public Fruits()
    {
        // apple = appleA;
        // orange = orangeA;
        // melon = melonsA;
        // grapefruit = grapefruitA;
        // strawberrie = strawberrieA;
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
                    Console.Write($"{i} = {k}£ ");
            }
        }
    }
    // public int priceOfFruit(string userChoice)
    // {

    //     foreach (KeyValuePair<string, int> i in listFruits)
    //     {
    //         if (userChoice == i.Key)
    //         {
    //             price = i.Value;
    //         }
    //     }
    //     return price;
    // }
}


