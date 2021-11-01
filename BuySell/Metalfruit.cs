using System;
using System.Collections.Generic;

public class Metalfruit
{
    public int price { get; set; }

    public int priceOf(List<Dictionary<string, int>> dicti, string userChoice)
    {
        foreach (Dictionary<string, int> i in dicti)
        {
            foreach (KeyValuePair<string, int> k in i)
            {
                if (userChoice == k.Key)
                {
                    price = k.Value;
                }
            }
        }
        return price;
    }

    public int priceOf(string userChoice, Dictionary<string, int> list)
    {

        foreach (KeyValuePair<string, int> i in list)
        {
            if (userChoice == i.Key)
            {
                price = i.Value;
            }
        }
        return price;
    }
    // public int Fprice()
    // {
    //     fruit.priceOf();
    // }

    // public int Mprice()
    // {
    //     metal.priceOf;
    // }


}