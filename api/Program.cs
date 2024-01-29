using api.DbData;
using api.Interfaces.CollectToDb;
using api.Interfaces.Live;
using api.Repository;
using api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DB IMPLEMENTATION
builder.Services.AddDbContext<ApplicationDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


// 
// INTERFACES IMPLEMENTATION
// 
//Live interfaces
builder.Services.AddScoped<IMainLiveDataService, MainLiveDataService>();
builder.Services.AddScoped<IAsqLiveDataService, AsqLiveDataRepo>();
builder.Services.AddScoped<IEqcLiveDataService, EqcLiveDataRepo>();
//Db interfaces
builder.Services.AddScoped<IAsqDataDb, AsqDbDataRepo>();
// builder.Services.AddScoped<AsqCollectorDb>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Získání služby a spuštění metody StartAsync
var collectorService = app.Services.GetRequiredService<AsqCollectorDb>();
// collectorService.Start();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
