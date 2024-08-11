using System;
using beasts_game.Core.Powers;

namespace beasts_game.Core;

public class Beast
{
    public string Name { get; set; }
    public int MaxHealth { get; }
    public int Health { get; set; }
    public BeastStats Stats { get; }

    public IEnumerable<Power> Powers { get; private set; }

    public Beast(string name, int maxHealth, BeastStats stats, IEnumerable<Power> basicPowers)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Stats = stats;
        Powers = basicPowers;
    }

    public void LearnPower(Power power)
    {
        Powers.Append(power);
    }

    public void GainExperience(int experience)
    {
        Stats.Experience += experience;
    }

    public void RestoreHealth(int health)
    {
        Health += health;
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public void RestoreHealth()
    {
        Health = MaxHealth;
    }

    public Power GetPower(int powerIndex)
    {
        if (powerIndex < 0 || powerIndex >= Powers.Count())
        {
            throw new ArgumentException("Invalid power index.");
        }
        return Powers.ElementAt(powerIndex);
    }

    public void UsePower(int powerIndex, Beast target = null)
    {
        if (powerIndex < 0 || powerIndex >= Powers.Count())
        {
            throw new ArgumentException("Invalid power index.");
        }
        UsePower(Powers.ElementAt(powerIndex), target);
    }

    public void UsePower(Power power, Beast target = null)
    {
        power.Use(this, target);
    }
}
