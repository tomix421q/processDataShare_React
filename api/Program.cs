using api.DbData;
using api.Interfaces.Live;
using api.Repository;
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



// INTERFACES IMPLEMENTATION
builder.Services.AddScoped<IMainLiveDataService, MainLiveDataService>();
builder.Services.AddScoped<IAsqLiveDataService, AsqLiveDataRepo>();
builder.Services.AddScoped<IEqcLiveDataService, EqcLiveDataRepo>();

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
