namespace log_training_1;

public class BeastsService
{
    private readonly ILogger<BeastsService> _logger = null!;

    public BeastsService(ILogger<BeastsService> logger)
    {
        _logger = logger;
    }
    
    public User? CaptureBeast(int beastId, int userId)
    {
        var beast = MockDb.Beasts.FirstOrDefault(b => b.Id == beastId);
        var user = MockDb.Users.FirstOrDefault(u => u.Id == userId);
        if (beast == null)
        {
            _logger.LogCritical("Beast {beastId} not found", beastId);
            return default;
        }
        if (user == null)
        {
            _logger.LogWarning("User {userId} not found", userId);
            return default;
        }

        user.Beasts.Add(beast);
        _logger.LogInformation($"User {user.Name} captured beast {beast.Name}");
        return user;
    }
}
