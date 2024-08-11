using System;

namespace beasts_game.Core.Powers;

public class AttackPower : Power
{
    private int _damage;
    private int _plusDamage = 0;

    public AttackPower(string name, string description, int damage, int plusDamage = 0) : base(name, description)
    {
        _damage = damage;
        _plusDamage = plusDamage;
    }

    public override void Use(Beast self, Beast target)
    {
        if (target == null)
        {
            throw new ArgumentException("AttackPower requires a target beast.");
        }
        target.Health -= _damage + _plusDamage;
    }
}
