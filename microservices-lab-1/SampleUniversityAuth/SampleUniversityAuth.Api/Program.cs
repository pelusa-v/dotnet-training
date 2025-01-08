using SampleUniversityAuth.Api.Application;
using SampleUniversityAuth.Api.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddApplication(builder.Configuration);
builder.Services.AddDataAccess(builder.Configuration["Resources:DbConnection"]);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "SampleUniversityAuth.Api v1");
    });
}

app.UseHttpsRedirection();


app.Run();