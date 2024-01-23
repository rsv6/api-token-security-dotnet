using ApiTokenSecurity.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar registro de contexto;
var config = builder.Configuration; 
builder.Services.AddDbContext<DbScreenSoundContext>(options =>
    options.UseSqlServer(config.GetConnectionString("ScreenSound"))
);

builder.Services.AddDbContext<DbHubContext>(options =>
    options.UseSqlServer(config.GetConnectionString("DbHub"))
);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
