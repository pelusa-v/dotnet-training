using System;
using beasts_game.Core;
using beasts_game.Core.Powers;

namespace beasts_game.Game;

public class Battle
{
    private Owner _attacker;
    private Owner _defender;
    private Owner _winner;
    private Owner _loser;
    private bool _isOver = false;

    private int _experienceToGain
    {
        get
        {
            return _loser.Beast.Stats.Experience / _winner.Beast.Stats.Experience * 10;
        }
    }


    public Battle(Owner attacker, Owner defender)
    {
        _attacker = attacker;
        _defender = defender;
    }

    public void Fight()
    {
        WelcomeToBattle();
        while (!_isOver)
        {
            DisplayTurnStats();
            ExecuteTurn();
            if (BattleIsOver())
            {
                _isOver = true;
            }
            else
            {
                SwitchTurn();
            }
        }
        SetWinnerAndLoser();
        EndBattle();
    }

    private void WelcomeToBattle()
    {
        Console.WriteLine($"\n----------------------------------------------------");
        Console.WriteLine($"---- Welcome to the battle between {_attacker.Name} and {_defender.Name}! ----");
    }

    private void ExecuteTurn()
    {
        // manual or automatic choice
        Power power = _attacker.Npc ? AutomaticChoice() : ManualChoice();
        _attacker.Beast.UsePower(power, _defender.Beast);
        Console.WriteLine($"\n--------------------------");
        Console.WriteLine($"{_attacker.Beast.Name} uses {power.Name}");
        Console.WriteLine($"{power.Description}");
        Console.WriteLine($"{power.ActionDescription}");
        Console.WriteLine($"\n--------------------------");
    }

    private void DisplayTurnStats()
    {
        Console.WriteLine($"\n----------------------------------------------------");
        Console.WriteLine("---- Battle stats ----");
        Console.WriteLine("Current stats:");
        Console.WriteLine($"---- {_attacker.Name}, Beast: {_attacker.Beast.Name} ----");
        Console.WriteLine($"- health: {_attacker.Beast.Health}");
        Console.WriteLine($"- experience: {_attacker.Beast.Stats.Experience}");
        Console.WriteLine($"---- {_defender.Name}, Beast: {_defender.Beast.Name} ----");
        Console.WriteLine($"- health: {_defender.Beast.Health}");
        Console.WriteLine($"- experience: {_defender.Beast.Stats.Experience}\n");
        Console.WriteLine($"----------------------------------------------------\n");

        Console.WriteLine($"* {_attacker.Name}'s turn now!\n");
    }

    private bool BattleIsOver()
    {
        return _attacker.Beast.Health <= 0 || _defender.Beast.Health <= 0;
    }

    private void SwitchTurn()
    {
        var nextTurn = _defender;
        _defender = _attacker;
        _attacker = nextTurn;
    }

    private void SetWinnerAndLoser()
    {
        _winner = _attacker;
        _loser = _defender;
    }

    private void EndBattle()
    {
        Console.WriteLine($"{_winner.Beast.Name} wins!");
        _winner.Beast.GainExperience(_experienceToGain);
        _winner.Beast.RestoreHealth();
        _loser.Beast.RestoreHealth();
    }

    private Power ManualChoice()
    {
        while (true)
        {
            Console.WriteLine("Choose a power, enter the option number:");

            for (int i = 0; i < _attacker.Beast.Powers.Count(); i++)
            {
                var power = _attacker.Beast.Powers.ElementAt(i);
                Console.WriteLine($"* {i + 1}) {power.Name}:");
                Console.WriteLine($"{power.Description}");
                Console.WriteLine($"{power.ActionDescription}");
            }

            var powerNumberStr = Console.ReadLine();
            if (int.TryParse(powerNumberStr, out int number) && _attacker.Beast.Powers.Count() > number)
            {
                Console.WriteLine($"You entered: {number}");
                return _attacker.Beast.GetPower(number - 1);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid power option");
            }
        }
    }

    private Power AutomaticChoice()
    {
        Thread.Sleep(3000);
        var number = new Random().Next(0, _attacker.Beast.Powers.Count() - 1);
        return _attacker.Beast.Powers.ElementAt(number);
    }
}
