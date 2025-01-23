using System;

namespace beasts_game.Core.Powers;

public class TrickPower : Power
{
    public TrickPower(string name, string description) : base(name, description)
    {
        
    }

    public override string ActionDescription
    {
        get
        {
            return "Trick";
        }
    }

    public override void Use(Beast self, Beast target = null)
    {
        throw new NotImplementedException();
    }
}
