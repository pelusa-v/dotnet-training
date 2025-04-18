
namespace background_services.Services;

public class SimpleBackgroundService : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Task.Run(async () => 
        {
            while(!cancellationToken.IsCancellationRequested)
            {
                await Task.Delay(2000);  // simulating work
                Console.WriteLine("---- Running a background task on different thread");
            }
        });

        Task.Run(() => Console.WriteLine("---- Running a background task on different thread 2"));

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
