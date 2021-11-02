using System;
using System.Collections.Generic;

public class Randoms
{
    public List<char> operatorList { get; set; }
    public char randOperator { get; set; }
    public int randNumber { get; set; }

    public Randoms()
    {
        operatorList = new List<char>();
    }
    Random randNum = new Random();
    // int rando = rand.Next(0, 7);
    Random randOp = new Random();


    public int RandNum()
    {
        randNumber = randNum.Next(3, 7);
        return randNumber;
    }
    public char randomOperator()
    {
        randOperator = operatorList[randOp.Next(0, 2)];
        return randOperator;

    }
}