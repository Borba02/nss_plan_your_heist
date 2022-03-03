using System;

class Bank
{
    public string Name {get; set;}
    public int DifficultyLevel {get; set;}

    public Bank(string name) 
    {
        Name = name;
        DifficultyLevel = 100;
    }
}