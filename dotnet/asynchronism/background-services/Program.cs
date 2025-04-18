using background_services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// builder.Services.AddSingleton<CancelableBackgroundService>();
// builder.Services.AddHostedService(provider => provider.GetRequiredService<CancelableBackgroundService>());
// builder.Services.AddHostedService<SimpleBackgroundService>();
// builder.Services.AddSingleton<SampleService>();

builder.Services.AddHostedService<TimerBackgroundService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();