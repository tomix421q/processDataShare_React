using api.DbData;
using api.Interfaces.Live;
using api.Repository;
<<<<<<< HEAD
=======
using api.ServicesWorkers;
>>>>>>> 2f7b742 (utorok)
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<AsqCollectorDb>();


//DB IMPLEMENTATION
builder.Services.AddDbContext<ApplicationDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});



// INTERFACES IMPLEMENTATION
builder.Services.AddScoped<IMainLiveDataService, MainLiveDataService>();
builder.Services.AddScoped<IAsqLiveDataService, AsqLiveDataRepo>();
builder.Services.AddScoped<IEqcLiveDataService, EqcLiveDataRepo>();
<<<<<<< HEAD
=======
//Db interfaces
builder.Services.AddTransient<IAsqDataDb, AsqDbDataRepo>();


>>>>>>> 2f7b742 (utorok)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

<<<<<<< HEAD
=======


>>>>>>> 2f7b742 (utorok)
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
