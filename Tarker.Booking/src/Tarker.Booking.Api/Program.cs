using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Persistence.DataBase;
using Tarker.Booking.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseService>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:bookingDB01"]));

// Add services to the container.
builder.Services.AddScoped<IDataBaseService, DataBaseService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();
