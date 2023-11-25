using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using MediatR;
using OneCheck.Application;
using OneCheck.Domain.Contracts;
using OneCheck.Repository;
using Microsoft.EntityFrameworkCore;
using OneRecord.Api.SDK.Client;
using OneCheck.Repository.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IShipmentRepository, ShipmentRepository>();

builder.Services.ConfigureApplicationServices();
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));


//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

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
