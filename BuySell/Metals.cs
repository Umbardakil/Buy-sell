using System;
using System.Collections.Generic;
using System.Linq;

public class Metals : ICommetal
{
    public Dictionary<string, int> listMetals { get; set; }
    public List<string> metals { get; set; }
    public List<int> metPrices { get; set; }
    public string gold { get; set; }
    public string silver { get; set; }
    public string iron { get; set; }
    public string bronze { get; set; }
    public string titanium { get; set; }
    public int priceOfCommodity { get; set; }
    public int ind { get; set; }

    public int priceOf(string userChoice)
    {


        ind = metals.IndexOf(userChoice);
        priceOfCommodity = metPrices[ind];



        return priceOfCommodity;
    }



    public Metals()
    {

        metals = new List<string>();
        metPrices = new List<int>();
        listMetals = new Dictionary<string, int>();
    }

    public void DisplayMetal()
    {
        foreach (string i in metals)
        {
            foreach (int k in metPrices)
            {
                if (metals.IndexOf(i) == metPrices.IndexOf(k))
                    Console.WriteLine($"{i} = {k}£ ");
            }
        }
    }

    public List<int> metalPriceDec(int random)
    {
        for (int i = 0; i < metPrices.Count; i++)
        {
            metPrices[i] -= metPrices[i] * random / 100;
        }
        return metPrices;
    }
    public List<int> metalPriceIncrese(int random)
    {
        for (int i = 0; i < metPrices.Count; i++)
        {
            metPrices[i] += metPrices[i] * random / 100;
        }
        return metPrices;
    }

    // public Dictionary<string, int> DisplayNewDi(int rando)
    // {
    //     for (int i = 0; i < listMetals.Count; i++)
    //     {


    //         // KeyValuePair<string, int> entry = listMetals.ElementAt(i);
    //         // item = entry.Value;
    //         // Console.WriteLine(item);
    //         // item += 1;
    //         // (item * rando) / 100;

    //     }
    //     return listMetals;
    // }

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

