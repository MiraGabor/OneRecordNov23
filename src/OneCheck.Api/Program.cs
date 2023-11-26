using OneCheck.Application;
using OneCheck.Domain.Contracts;
using OneCheck.Repository;
using Microsoft.EntityFrameworkCore;
using Neone.ServiceClient;
using OneCheck.Repository.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IShipmentRepository, ShipmentRepository>();
builder.Services.AddScoped<ICorrespondenceTableRepository, CorrespondenceTableRepository>();

builder.Services.ConfigureApplicationServices();
builder.Services.AddTransient<IConfiguration>(sp =>
{
    IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
    configurationBuilder.AddJsonFile("appsettings.json");
    return configurationBuilder.Build();
});
builder.Services.AddScoped<IClient, Client>();

builder.Services.AddControllers();
builder.Services.AddDbContext<CorrespondenceTableContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("myDb")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
