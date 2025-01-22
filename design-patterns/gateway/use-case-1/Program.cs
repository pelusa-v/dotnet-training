using use_case_1;
using use_case_1.Integrations;
using use_case_1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(PetProfile));
builder.Services.AddScoped<IPetService, PetService>();
builder.Services.AddScoped<IPetOwnerGateway, PetOwnerGateway>();
builder.Services.AddHttpClient<IPetOwnerGateway, PetOwnerGateway>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5076");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "My API V1");
    });
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();