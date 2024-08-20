
namespace background_services.Services;

public class TimerBackgroundService : IHostedService, IDisposable
{
    private Timer? _timer = null;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(PeriodicWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
        return Task.CompletedTask;
    }

    private void PeriodicWork(object? state)
    {
        Console.WriteLine("Timer background service is running.");
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}
