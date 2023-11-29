using PTWiseApp.API.Data;
using Microsoft.EntityFrameworkCore;
using PTWiseApp.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<PTWiseDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PTWiseConnection"))    
);

// AddScoped -  instances are created once in the scope of the request.
builder.Services.AddScoped<TrainerService>();

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
