using System;
using System.Collections.Generic;

class Bank
{
    public string Name { get; set; }
    public int DifficultyLevel { get; set; }

    public int LuckLevel { get; set; }

    public Bank(string name)
    {
        Name = name;
        LuckLevel = (new Random().Next(21)) - 10;
        DifficultyLevel = 100 + LuckLevel;

    }

    // this method reassigns difficulty level
    public void NewDifficulty()
    {
        DifficultyLevel = (new Random().Next(21)) + 90;
    }
}