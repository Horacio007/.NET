using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Persistence.DataBase;
using Tarker.Booking.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseService>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:bookingDB01"]));

// Add services to the container.
builder.Services.AddScoped<IDataBaseService, DataBaseService>();

var app = builder.Build();

//app.MapPost("/createTest", async (IDataBaseService _dataBaseService) =>
//{
//    var entity = new Tarker.Booking.Domain.Entities.User.UserEntity()
//    {
//        FirstName = "Horacio",
//        LastName = "Gongora",
//        UserName = "user1",
//        Password = "123abx"
//    };
//    await _dataBaseService.User.AddAsync(entity);
//    await _dataBaseService.SaveAsync();

//    return "Create Ok";
//});

//app.MapGet("/getTest", async (IDataBaseService _dataBaseService) =>
//{
//    var result = await _dataBaseService.User.ToListAsync();
//    return result;
//});

// Configure the HTTP request pipeline.

app.Run();
