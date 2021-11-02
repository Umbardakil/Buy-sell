using System;
using System.Collections.Generic;

public class Randoms
{
    public List<char> operatorList { get; set; }
    public char randOperator { get; set; }
    public int randBigNumber { get; set; }
    public int randSmallNumber { get; set; }

    public Randoms()
    {
        operatorList = new List<char>();
    }
    Random randNum = new Random();
    Random randOp = new Random();


    public int RandBigChange()
    {
        randBigNumber = randNum.Next(4, 9);
        return randBigNumber;
    }
    public int RandSmallChange()
    {
        randSmallNumber = randNum.Next(1, 4);
        return randSmallNumber;
    }
    public char randomOperator()
    {
        randOperator = operatorList[randOp.Next(0, 2)];
        return randOperator;

    }
}