using System;
using beasts_game.Core;

namespace beasts_game.Game;

public class Game
{
    private Owner _mainCharacter;

    public void StartGame()
    {
        Seed.CreateOwners();
        Console.WriteLine("---- Welcome to Beasts world! ----");
        Thread.Sleep(2000);
        RequestOwner();
        Thread.Sleep(2000);
        AssignBeast();
        Thread.Sleep(2000);
        StartTutorialBattle();
    }

    private void RequestOwner()
    {
        Console.WriteLine("---- Enter your name: ----");
        string name = Console.ReadLine();
        _mainCharacter = new Owner(name);
    }

    private void AssignBeast()
    {
        Console.WriteLine("---- Choose your beast: ----");
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
            AssignBeast();
        }
    }

    private void StartTutorialBattle()
    {
        Console.WriteLine("---- Start tutorial battle: ----");
        var npcIndex = new Random().Next(0, Seed.OwnersPool.Count() - 1);
        Owner npc = Seed.OwnersPool[npcIndex];
        Battle battle = new Battle(_mainCharacter, npc);
        battle.Fight();
    }
}
