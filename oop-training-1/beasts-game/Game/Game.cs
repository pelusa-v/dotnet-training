using System;
using beasts_game.Core;

namespace beasts_game.Game;

public class Game
{
    private Owner _mainCharacter;

    public void StartGame()
    {
        Seed.CreateOwners();
        Console.WriteLine("Welcome to Beasts world!");
        Thread.Sleep(2000);
        RequestOwner();
    }

    private void RequestOwner()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        _mainCharacter = new Owner(name);
    }

    private void AssigningBeast()
    {
        Console.WriteLine("Choose your beast:");
        for (int i = 0; i < Seed.BeastsPool.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Seed.BeastsPool[i].Name}");
        }

        if (int.TryParse(Console.ReadLine(), out int number) && number <= Seed.BeastsPool.Count)
        {
            Console.WriteLine($"You entered: {number}");
            _mainCharacter.CaptureBeast(Seed.BeastsPool[number - 1]);
        }
        else
        {
            Console.WriteLine("Enter a valid beast number.");
            AssigningBeast();
        }
    }
}
