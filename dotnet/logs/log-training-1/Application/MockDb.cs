namespace log_training_1;

public static class MockDb
{
    public static List<Beast> Beasts { get; set; } = new List<Beast>
    {
        new Beast { Id = 1, Name = "Dragon" },
        new Beast { Id = 2, Name = "Goblin" },
        new Beast { Id = 3, Name = "Orc" },
        new Beast { Id = 4, Name = "Troll" },
        new Beast { Id = 5, Name = "Wyvern" }
    };

    public static List<User> Users { get; set; } = new List<User>
    {
        new User { Id = 1, Name = "Alice" },
        new User { Id = 2, Name = "Bob" },
        new User { Id = 3, Name = "Charlie" },
        new User { Id = 4, Name = "Diana" },
        new User { Id = 5, Name = "Eve" }
    };
}
