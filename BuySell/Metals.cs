using System;
using System.Collections.Generic;

public class Metals : ICommetal
{
    public Dictionary<string, int> listMetals { get; set; }
    public string gold { get; set; }
    public string silver { get; set; }
    public string iron { get; set; }
    public string bronze { get; set; }
    public string titanium { get; set; }
    // public int price { get; set; }



    public Metals(string goldA, string silverA, string ironA, string bronzeA, string titaniumA)
    {
        gold = goldA;
        silver = silverA;
        iron = ironA;
        bronze = bronzeA;
        titanium = titaniumA;

        listMetals = new Dictionary<string, int>();
    }

    public void DisplayMetal()
    {
        foreach (KeyValuePair<string, int> i in listMetals)
        {
            Console.Write($"{i.Key} = {i.Value}£ ");
        }
    }

    // public int priceOfMetal(string userChoice)
    // {

    //     foreach (KeyValuePair<string, int> i in listMetals)
    //     {
    //         if (userChoice == i.Key)
    //         {
    //             price = i.Value;
    //         }

    //     }
    //     return price;
    // }
}

