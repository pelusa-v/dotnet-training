using System;
using beasts_game.Core.Interfaces;

namespace beasts_game.Core;

public class BeastStats : IMonitor
{
    private readonly float _experienceFactor;
    private int _experience;
    public int Experience
    {
        get => _experience;
        set
        {
            _experience = value;
            if (_experience >= ExperienceToNextLevel)
            {
                Level++;
                ExperienceToNextLevel = (int)(ExperienceToNextLevel * _experienceFactor);
            }
        }
    }

    public BeastStats(int experience, float experienceFactor = 1.5f, int level = 0)
    {
        Level = level;
        _experience = experience;
        _experienceFactor = experienceFactor;
    }
    
    public int ExperienceToNextLevel { get; set; }
    public int Level { get; set; }

    public void PrintMonitoringData()
    {
        throw new NotImplementedException();
    }
}
