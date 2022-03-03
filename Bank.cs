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
        //determine difficulty level of bank
        Console.WriteLine("COMRADE. How wimpy is the bank we are engaging with today?");
        try {
            DifficultyLevel = int.Parse(Console.ReadLine());
        } catch (FormatException ex) {
            while (ex != null){
                try {
                    Console.WriteLine("COMRADE, this is represented by a NUMBER with no decimals. Have you even read Lenin?");
                    DifficultyLevel = int.Parse(Console.ReadLine());
                    ex = null;
                } catch (FormatException newEx) {
                    ex = newEx;
                }
            }
        }
        DifficultyLevel += LuckLevel;

    }

    // this method reassigns difficulty level
    public void NewDifficulty()
    {
        //undo luck level to regain initial difficulty level
        DifficultyLevel -= LuckLevel;
        //grab new luck level
        LuckLevel = (new Random().Next(21)) - 10;
        //apply new luck level to difficulty level
        DifficultyLevel += LuckLevel;

    }
}