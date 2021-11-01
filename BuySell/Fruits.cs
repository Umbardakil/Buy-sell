
using System;
using System.Collections.Generic;
public class Fruits : IComfruit
{
    public Dictionary<string, int> listFruits { get; set; }
    public string apple { get; set; }
    public string orange { get; set; }
    public string melon { get; set; }
    public string grapefruit { get; set; }
    public string strawberrie { get; set; }
    // public int price { get; set; }


    public Fruits(string appleA, string orangeA, string melonsA, string grapefruitA, string strawberrieA)
    {
        apple = appleA;
        orange = orangeA;
        melon = melonsA;
        grapefruit = grapefruitA;
        strawberrie = strawberrieA;
        listFruits = new Dictionary<string, int>();
    }

    public void DisplayFruits()
    {
        foreach (KeyValuePair<string, int> i in listFruits)
        {
            Console.Write($"{i.Key} = {i.Value}£ ");
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


