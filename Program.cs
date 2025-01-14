using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class Gender
{
    public string name { get; set; }
    public string gender { get; set; }
    public float probablility { get; set; }
    public int count { get; set; }
    public string countryId { get; set; }
}
class GenderDb : DbContext
{
    public GenderDb(DbContextOptions<GenderDb> options)
    : base(options) { }

    public DbSet<Gender> Genderss => Set<Gender>();
}