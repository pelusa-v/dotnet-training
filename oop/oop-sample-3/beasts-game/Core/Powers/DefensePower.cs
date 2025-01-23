using System;
using beasts_game.Core.Interfaces;

namespace beasts_game.Core.Powers;

public class DefensePower : Power
{
    private int _healthToRestore;

    public DefensePower(string name, string description, int restore) : base(name, description)
    {
        _healthToRestore = restore;
    }

    public override string ActionDescription 
    {
        get => $"Restore {_healthToRestore} Health points";
    }

    public override void Use(Beast self, Beast target = null)
    {
        if (self == null)
        {
            throw new ArgumentException("DefensePower requires a self beast.");
        }
        self.RestoreHealth(_healthToRestore);
    }
}
