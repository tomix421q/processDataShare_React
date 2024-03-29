using api.DbData;
using api.Interfaces.CollectToDb;
using api.Interfaces.Live;
using api.Repository;
using api.Repository.DataToDb;
using api.Repository.DataToDB;
using api.Services;
using api.ServicesWorkers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<AsqCollectorDb>();
builder.Services.AddHostedService<EqcCollectorDb>();


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
builder.Services.AddScoped<IOpelLiveDataService, OpelLiveDataRepo>();
//Db interfaces
builder.Services.AddTransient<IAsqDataDb, AsqDbDataRepo>();
builder.Services.AddTransient<IEqcDataDb, EqcDbDataRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:5173")
           .AllowAnyHeader()
           .AllowAnyMethod()
           .AllowCredentials();
}); ;


app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
