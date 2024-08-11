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
        while (!_isOver)
        {
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

    private void ExecuteTurn()
    {
        // manual or automatic
        Power power = _attacker.Npc ? AutomaticChoice() : ManualChoice();
        _attacker.Beast.UsePower(power, _defender.Beast);
    }

    private bool BattleIsOver()
    {
        return _attacker.Beast.Health <= 0 && _defender.Beast.Health <= 0;
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
            // Show powers from beast (maybe)
            var powerNumberStr = Console.ReadLine();

            if (int.TryParse(powerNumberStr, out int number) && _attacker.Beast.Powers.Count() > number)
            {
                Console.WriteLine($"You entered: {number}");
                return _attacker.Beast.GetPower(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid power option");
            }
        }
    }

    private Power AutomaticChoice()
    {
        var number = new Random().Next(0, _attacker.Beast.Powers.Count() - 1);
        return _attacker.Beast.Powers.ElementAt(number);
    }
}
