var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

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

var owners = new List<Owner>()
{
    new Owner { Id = 1, PetId = 1, Name = "Jon Arbuckle" },
    new Owner { Id = 2, PetId = 2, Name = "Lyman" },
    new Owner { Id = 3, PetId = 3, Name = "Liz Wilson" },
    new Owner { Id = 4, PetId = 4, Name = "Arlene" },
    new Owner { Id = 5, PetId = 5, Name = "Jodie" },
};

app.MapGet("/api/pets/{petId}/owner", (int petId) =>
{
    return owners.FirstOrDefault(o => o.PetId == petId);
})
.WithName("GetOwner");

app.Run();

public class Owner
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public string Name { get; set; } = null!;
}