
namespace background_services.Services;

public class CancelableBackgroundService : IHostedService
{
    private readonly CancellationTokenSource _cts = new();

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Task.Run(() => ExecuteAsync(_cts.Token));
        // Task.Run(() => Console.WriteLine("---- Running a background task on different thread 2"));
        return Task.CompletedTask;
    }

    private async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(3000, stoppingToken); // Simulate work
            Console.WriteLine("Cancelable Background task is running.");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Stopping background task...");
        _cts.Cancel();
        return Task.CompletedTask;
    }

    public void StopServiceFromOutside()
    {
        _cts.Cancel();
    }
}
