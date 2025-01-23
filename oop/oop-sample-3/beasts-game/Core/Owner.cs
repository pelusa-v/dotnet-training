using System;

namespace beasts_game.Core;

public class Owner
{
    public string Name { get; set; }
    public Beast Beast { get; set; }
    public bool Npc { get; }

    public Owner(string name, Beast beast, bool npc = true)
    {
        Name = name;
        Beast = beast;
        Npc = npc;
    }

    public Owner(string name)
    {
        Name = name;
        Npc = false;
    }

    public void CaptureBeast(Beast beast)
    {
        Beast = beast;
    }
}
