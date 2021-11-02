using System;
using System.Collections.Generic;
using System.Linq;

public class Metalfruit : IComfruit, ICommetal
{
    public int price { get; set; }
    public List<Dictionary<string, int>> listOfDic { get; set; }
    public Dictionary<string, int> dicMetal { get; set; }
    public Dictionary<string, int> dicFruit { get; set; }

    Metals metal = new Metals();
    Fruits fruit = new Fruits();


    public Metalfruit()
    {
        listOfDic = new List<Dictionary<string, int>>();
        dicMetal = new Dictionary<string, int>();
        dicFruit = new Dictionary<string, int>();
    }

    public void dis()
    {
        foreach (KeyValuePair<string, int> i in dicFruit)
        {
            Console.WriteLine($"{i.Key} = {i.Value}");
        }
    }
    public int priceOf(string k, string userChoice, int v)
    {
        if (k.Contains(userChoice))
        {
            price = v;
        }
        return price;
    }



}